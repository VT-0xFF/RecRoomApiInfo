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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7629880", Offset = "0x7628880", VA = "0x187629880")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MKEMNPIIMEB
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum MALNMCBCNKL
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
	public string EFCGCEGKMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string HNMINCDIAIH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MALNMCBCNKL AFAJHOLELHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(MALNMCBCNKL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PFLOLJIAHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x22E1850", Offset = "0x22E0850", VA = "0x1822E1850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NHEEGJMGGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x19A1CF0", Offset = "0x19A0CF0", VA = "0x1819A1CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x76291A0", Offset = "0x76281A0", VA = "0x1876291A0")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static MKEMNPIIMEB MIFAEMCECOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7629110", Offset = "0x7628110", VA = "0x187629110")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static MKEMNPIIMEB KEEGDKOGOFO([Optional] string JDMJMCKEBDL, [Optional] string IAGEDNEDFLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public MKEMNPIIMEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BFOBFLKGLKA
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string GJGAFBHFKMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string PPIBMEJLINM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface AHLHLMFHOEL
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BFOBFLKGLKA> HMLMLNGIOHL(string NJPDPBODLFC, string HDAKANCKKDM, string ILMAJBEODOH, VoiceOption LJACCABGBPN, string? HPDKLMKJBCF, float FPLFDLIJGBK, [Optional] CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ACNHELPKEEL : AHLHLMFHOEL
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	JAMDEOPMLEI? EBFICMLMLNA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	FHLIAIDPCMK<NHOIAIMJPHM> KJAJCHFPENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	FHLIAIDPCMK<DEHMPFFKIBP> FKDNMGPKIJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	FHLIAIDPCMK<CKJGODBGMBM> LHGNOAKAGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	LELKCPPPMEI CMPHGKHKEOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJKPJELHHIJ();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<NKCJNDJFNDM<byte>> LDGJDDNHNDA(string HDCLHHGFDJB, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<MPKGNLKJDEG> HECBHOBDAGF(bool OMHKKMGBJFB, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<PMFNJIOOINF<OENAFGIDDAM>> KAJEHHLMOLL(bool GBHJJPCINNF = false, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<MPKGNLKJDEG> BJAIOICKICJ(long DJJNJEHBMJK, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<KGOJLHJNIOD<KNKBLKHAIDL>> EKBDAFPPCAE(long DJJNJEHBMJK, bool AFAPOAPAHPJ = false, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<HHANLBFAHIP> LILPPBEDIKM(bool AFAPOAPAHPJ = false, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<PGCCEHPFAPF> KILHNGOHKOP([Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<MPKGNLKJDEG> IJFCBCJGENK(bool AFAPOAPAHPJ = false, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task<MPKGNLKJDEG> ONGNMCBACGG([Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<MPKGNLKJDEG> CNNNOJIEGLH(string NJPDPBODLFC, Guid FPEFAGEMFCB, long DJJNJEHBMJK, long MPFABJAKBKF, decimal OLIJFABHDCO, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<PMFNJIOOINF<OENAFGIDDAM>> CCPCCJKKDOF(Guid FPEFAGEMFCB, long DJJNJEHBMJK, long MPFABJAKBKF, decimal OLIJFABHDCO, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task HJHGCFDOAPF(string DIKAKHCHMCD, string ALJGFANPBEH, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<CMGGAJLPODH> BMNOJKDNCPE(string HDAKANCKKDM, string CJJNGPGIOOB, bool BEKIOMHIJEH, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task<CKJGODBGMBM> IIDPOELIPLL(long DJJNJEHBMJK, string EDGKMDMPDFP, string MHAJOEPCBAD, string CJJNGPGIOOB, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<CKJGODBGMBM> IAKKNNNAKAD(long AGMCJLJPKKI, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<AMCHEHLLFPF> IEHOJEMLAMK(string? HDAKANCKKDM, string CJJNGPGIOOB, string GOLEPIKMENG, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<AMCHEHLLFPF> IEHOJEMLAMK(string? HDAKANCKKDM, string CJJNGPGIOOB, byte[] JOEBPODDKIN, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<AMCHEHLLFPF> IABNIMEBCJL(long DJJNJEHBMJK, string? HDAKANCKKDM, string CJJNGPGIOOB, string GOLEPIKMENG, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Task<AMCHEHLLFPF> IABNIMEBCJL(long DJJNJEHBMJK, string? HDAKANCKKDM, string CJJNGPGIOOB, byte[] JOEBPODDKIN, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task<CMGGAJLPODH> FLGCBJICBPP(long DJJNJEHBMJK, BEPAKPHEHKG LIPNPCINFLG, byte[] JOEBPODDKIN, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task<CMGGAJLPODH> JJNFJFDGOBH(BEPAKPHEHKG LIPNPCINFLG, string EDGKMDMPDFP, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<CMGGAJLPODH> ACBELJCKBOL(long DJJNJEHBMJK, string HDAKANCKKDM, string CJJNGPGIOOB, bool BEKIOMHIJEH, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<KFKCCDLPIHJ> NFPHBKMNAGN(string? HDAKANCKKDM, string CJJNGPGIOOB, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task<JAMDEOPMLEI> NPBBOEIEDGC(string CJJNGPGIOOB, CKEIKLKOBKE? NIILCLOOKFN, IReadOnlyList<CKEIKLKOBKE>? EKHCAAANHMK, IReadOnlyList<string> FBNPKLGBGPF, FLJIPBEPCNH ANJJOFOGAJP, [Optional] string? DGPCCKDKGDP, [Optional] string? JKBIPPJJIJO, [Optional] string? ANNHOHFJDOJ, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<JAMDEOPMLEI> PFDIFDHKHOD(string KBDMNJDINLK, CKEIKLKOBKE? NIILCLOOKFN, IReadOnlyList<string> FBNPKLGBGPF, FLJIPBEPCNH ANJJOFOGAJP, [Optional] string? JKBIPPJJIJO, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task<List<string>> PDPBIKDPHAJ(string CJJNGPGIOOB, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task<string> KIECIFICPEI(FLJIPBEPCNH ANJJOFOGAJP, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task<ADFPNAMGPEC> OHCGFPHFPPP(string JMJJABEKOFI, VoiceOption LJACCABGBPN, string? ILMAJBEODOH, Action<string> CKNHPEFEIML, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<JPLLGHHHFIE> FBCEAPJMHMO(List<IBOADFBIPJF> GDNHGAFAMNE, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<JPLLGHHHFIE> KLCIJGPHMJE([Optional] CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class JMHHOKPEFKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private string BHDBIDCBDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private string JLENGFEHEML;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string IEPKLCLLCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public string HFLIEMAIODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public string FNMEILNIIHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string AIHCHOHGMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int? DDHHLKELLOC
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int? JGPGGONDOAN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7626DB0", Offset = "0x7625DB0", VA = "0x187626DB0")]
	public JMHHOKPEFKH(string NBMCBFDHLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7626D80", Offset = "0x7625D80", VA = "0x187626D80")]
	public void PFNJGNKCKMI(string FAELNFLMIAO = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7626C80", Offset = "0x7625C80", VA = "0x187626C80")]
	private void IJGMBNLJPIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EPDAKMGELNC
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NPOGFCNMGND MEBNPJGIHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<OFAPHHCEFHC> AEKAFANKNHF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<COECAHPGEJM> GEOGMALKGCJ;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<COECAHPGEJM> LNNEFFJJIGI(bool DGGBADKLHKA = false, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NDJNCBGIINJ([Out] COECAHPGEJM BEIJJKCFGGN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JAIOOJKNFPK
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7626260", Offset = "0x7625260", VA = "0x187626260")]
	public static bool DICJCGNIBGC(this EPDAKMGELNC GHHBEHKABJL, [Out] OFAPHHCEFHC FFAFFHJDAFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7626170", Offset = "0x7625170", VA = "0x187626170")]
	public static bool CGGPHNBKMEK(this EPDAKMGELNC GHHBEHKABJL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LGFGOBCCLLH
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DHFHMJBLLHA(CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NMCFAIFAHJB(int HMIMAAKHBNF, [Out] AHAGMKDFAGG? ANJJOFOGAJP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AHAGMKDFAGG
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int IODIEHDGGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string? GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string? FMJEMOMMPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool? CIICKCLPNHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string? JBDOJJNPAMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string? PONNENAJBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	CBHKILNNDIO? ELGKGMEEINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool EKGBHGDAKKA(string NOABIOPHFPD, [Out] AGHPIFAAPIE? ANJJOFOGAJP);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface AGHPIFAAPIE
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string? GPMDGHINACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	string? FNEADOLJELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string? PNHHONFBCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	IReadOnlyList<GLIPLPOGIKP>? JINEFPFDAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	CBHKILNNDIO? ELGKGMEEINF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	long? PNPHGOECEGH
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GLIPLPOGIKP
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string FNEADOLJELE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	string HHDOJPCILPE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ANJMGFKKLLJ MFAMNHLGPPE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CBHKILNNDIO
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string FNEADOLJELE
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	string? GKAFLDAPONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[KGCDFDOGPOJ]
public class COBLLDMANDM
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int IPPLPEJMEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public List<KHJJMPNLHAC> AGNIFEHIFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Dictionary<string, string> PECFKLKPFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7621190", Offset = "0x7620190", VA = "0x187621190")]
	public COBLLDMANDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[KGCDFDOGPOJ]
public class KHJJMPNLHAC
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int IODIEHDGGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string FMJEMOMMPEK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string JBDOJJNPAMG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string PONNENAJBJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool? CIICKCLPNHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xE4F7A0", Offset = "0xE4E7A0", VA = "0x180E4F7A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xE4F7B0", Offset = "0xE4E7B0", VA = "0x180E4F7B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public DAODJEAINNI ELGKGMEEINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA674F0", Offset = "0xA664F0", VA = "0x180A674F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Dictionary<string, CCJCBMMDCEK> DJKJKLPJLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA68520", Offset = "0xA67520", VA = "0x180A68520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7627FE0", Offset = "0x7626FE0", VA = "0x187627FE0")]
	public KHJJMPNLHAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[KGCDFDOGPOJ]
public class DAODJEAINNI
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public string FNEADOLJELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string GKAFLDAPONG
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public DAODJEAINNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[KGCDFDOGPOJ]
public class CCJCBMMDCEK
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string GPMDGHINACB
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string FNEADOLJELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string PNHHONFBCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public List<FLPAHJIGDGJ> JINEFPFDAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public DAODJEAINNI ELGKGMEEINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public long PNPHGOECEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA672F0", Offset = "0xA662F0", VA = "0x180A672F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7620E30", Offset = "0x761FE30", VA = "0x187620E30")]
	public CCJCBMMDCEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum ANJMGFKKLLJ
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
[KGCDFDOGPOJ]
public class FLPAHJIGDGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string FNEADOLJELE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string HHDOJPCILPE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public ANJMGFKKLLJ MFAMNHLGPPE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return default(ANJMGFKKLLJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAAD190", VA = "0x180AAE190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public FLPAHJIGDGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct HOAGJBHPLOO : IEquatable<HOAGJBHPLOO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly bool LNMKMKKFLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly DateTime IDCAOFFCCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly bool LDOFABINGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly NLJFAOJNHDJ? LCOEGNLHEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly string MDKPCGJFKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int? LKEADEOEBIP;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static HOAGJBHPLOO JEMKANIADFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x29C5F70", Offset = "0x29C4F70", VA = "0x1829C5F70")]
		get
		{
			return default(HOAGJBHPLOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x76250C0", Offset = "0x76240C0", VA = "0x1876250C0")]
	public HOAGJBHPLOO(DateTime LLKEIIMPOFC, bool ENIPMPCLGHM, NLJFAOJNHDJ? GHKHLJHDOCF, string JPDDBGDJFEG, int? INDCHIMDBGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7624F30", Offset = "0x7623F30", VA = "0x187624F30")]
	public OFAPHHCEFHC MCAPAKOHOOH(NPOGFCNMGND HGGNFBFIEPG)
	{
		return default(OFAPHHCEFHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7624BF0", Offset = "0x7623BF0", VA = "0x187624BF0")]
	private static OFAPHHCEFHC DMAGNLLIBCJ(NPOGFCNMGND HGGNFBFIEPG, DateTime LLKEIIMPOFC)
	{
		return default(OFAPHHCEFHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7624C70", Offset = "0x7623C70", VA = "0x187624C70", Slot = "4")]
	public bool Equals(HOAGJBHPLOO EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7624DD0", Offset = "0x7623DD0", VA = "0x187624DD0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7624E80", Offset = "0x7623E80", VA = "0x187624E80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7624FC0", Offset = "0x7623FC0", VA = "0x187624FC0")]
	public static bool PHGIAKEDBEK(HOAGJBHPLOO AKPAAKDLPCB, HOAGJBHPLOO AIKJCCNDBKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7624BB0", Offset = "0x7623BB0", VA = "0x187624BB0")]
	public static bool BDCEBPMLGHE(HOAGJBHPLOO AKPAAKDLPCB, HOAGJBHPLOO AIKJCCNDBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7624FF0", Offset = "0x7623FF0", VA = "0x187624FF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct COECAHPGEJM : IEquatable<COECAHPGEJM>
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly COECAHPGEJM JEMKANIADFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool KJIKLILMPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly OFAPHHCEFHC MEBENICJDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly HOAGJBHPLOO LNAMCOINPPG;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x76217E0", Offset = "0x76207E0", VA = "0x1876217E0")]
	public COECAHPGEJM(OFAPHHCEFHC FFAFFHJDAFC, HOAGJBHPLOO EAPCLKJGCHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7621340", Offset = "0x7620340", VA = "0x187621340", Slot = "4")]
	public bool Equals(COECAHPGEJM EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x76213F0", Offset = "0x76203F0", VA = "0x1876213F0", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7621520", Offset = "0x7620520", VA = "0x187621520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x76215E0", Offset = "0x76205E0", VA = "0x1876215E0")]
	public static bool PHGIAKEDBEK(COECAHPGEJM AKPAAKDLPCB, COECAHPGEJM AIKJCCNDBKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7621220", Offset = "0x7620220", VA = "0x187621220")]
	public static bool BDCEBPMLGHE(COECAHPGEJM AKPAAKDLPCB, COECAHPGEJM AIKJCCNDBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x76216F0", Offset = "0x76206F0", VA = "0x1876216F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum OFAPHHCEFHC : byte
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Expired,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Active
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EKKLOHCJKIG : NPOGFCNMGND
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public const string HHGMFLAMFEF = "ServerTime";

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly Stopwatch KPJHGEAOHJJ;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static DateTimeOffset? LPFLIHBLMLB;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly EKKLOHCJKIG KLKDHLJDBBB;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static NPOGFCNMGND KONBGMLOLPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x76239B0", Offset = "0x76229B0", VA = "0x1876239B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	internal static EKKLOHCJKIG PCNIACINOKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7623960", Offset = "0x7622960", VA = "0x187623960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public static DateTimeOffset GNJOKACMEBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7623D40", Offset = "0x7622D40", VA = "0x187623D40")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static DateTime OKHHPAHIAKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x76238D0", Offset = "0x76228D0", VA = "0x1876238D0")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DateTime GKANKFMDPDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7623C80", Offset = "0x7622C80", VA = "0x187623C80", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public DateTimeOffset BGLIJPMHIGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7623A00", Offset = "0x7622A00", VA = "0x187623A00", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	private EKKLOHCJKIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7623A60", Offset = "0x7622A60", VA = "0x187623A60")]
	internal static void IJNHKKEHNAN(DateTime? LIDJFOMHAFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum LKCKEMAEFKH
{
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Front,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Back
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum BPIIFOAMGDA
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	AnimatedPuppet,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Imposter
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[KGCDFDOGPOJ]
public class GICBMFJFHLI : JIEDBCKBNMB, HCJBFOICEDA, PDDMBELEHHJ, GBHAIMFMHCK, BEOKPOAAHPI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct LOILJLIKFDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public GICBMFJFHLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7628820", Offset = "0x7627820", VA = "0x187628820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7628BD0", Offset = "0x7627BD0", VA = "0x187628BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[IgnoreDataMember]
	public static PGLIGOEGHJD BIECGDFEFCF;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Guid ELCENCJKGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE60", Offset = "0xE5DE60", VA = "0x180E5EE60", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE70", Offset = "0xE5DE70", VA = "0x180E5EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int AOGOJDELICJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAAD190", VA = "0x180AAE190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0", Slot = "40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public string FMJEMOMMPEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int CCNIGPGEOLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA7E570", Offset = "0xA7D570", VA = "0x180A7E570", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xE85250", Offset = "0xE84250", VA = "0x180E85250")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public KLKIFENPGNG HLPFIPKJLFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA7E580", Offset = "0xA7D580", VA = "0x180A7E580", Slot = "44")]
		[CompilerGenerated]
		get
		{
			return default(KLKIFENPGNG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x16B9510", Offset = "0x16B8510", VA = "0x1816B9510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool DHDHDOCNEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xD243D0", Offset = "0xD233D0", VA = "0x180D243D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xDCFD40", Offset = "0xDCED40", VA = "0x180DCFD40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool KPLGPOICBAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xE9F190", Offset = "0xE9E190", VA = "0x180E9F190", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xE9EC50", Offset = "0xE9DC50", VA = "0x180E9EC50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool BCPDELNEAJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2100AF0", Offset = "0x20FFAF0", VA = "0x182100AF0", Slot = "41")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x21003E0", Offset = "0x20FF3E0", VA = "0x1821003E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int? HDOIABFHJGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x76247B0", Offset = "0x76237B0", VA = "0x1876247B0", Slot = "43")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7624510", Offset = "0x7623510", VA = "0x187624510", Slot = "14")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string ELAHHMIGECH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA631E0", Offset = "0xA621E0", VA = "0x180A631E0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA631D0", Offset = "0xA621D0", VA = "0x180A631D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public string HMMEHGMBMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA63170", Offset = "0xA62170", VA = "0x180A63170", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA631B0", Offset = "0xA621B0", VA = "0x180A631B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string MDNFIIEDKLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA63190", Offset = "0xA62190", VA = "0x180A63190", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA631F0", Offset = "0xA621F0", VA = "0x180A631F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public DateTime POBHENPHPIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA63200", Offset = "0xA62200", VA = "0x180A63200", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xF87030", Offset = "0xF86030", VA = "0x180F87030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public DateTime GIPIHLKJPLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA631A0", Offset = "0xA621A0", VA = "0x180A631A0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xF86350", Offset = "0xF85350", VA = "0x180F86350")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public LKCKEMAEFKH DMLGKBPHPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xAD32E0", Offset = "0xAD22E0", VA = "0x180AD32E0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(LKCKEMAEFKH);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xFF9D10", Offset = "0xFF8D10", VA = "0x180FF9D10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public string DPMHKJDBLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA6EEA0", Offset = "0xA6DEA0", VA = "0x180A6EEA0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA6F010", Offset = "0xA6E010", VA = "0x180A6F010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int GIEMNBHFHNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xD4ECD0", Offset = "0xD4DCD0", VA = "0x180D4ECD0", Slot = "42")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xD4EFD0", Offset = "0xD4DFD0", VA = "0x180D4EFD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public IReadOnlyList<LGJPMPJMEPN> HHFCJFHFLNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xAC8EE0", Offset = "0xAC7EE0", VA = "0x180AC8EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xAC54F0", Offset = "0xAC44F0", VA = "0x180AC54F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public IReadOnlyList<NOGPCPONLFN> DMOOABKHCDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xAC8EE0", Offset = "0xAC7EE0", VA = "0x180AC8EE0", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public ODENGGBLDCP OAOGALEEKFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA6EE70", Offset = "0xA6DE70", VA = "0x180A6EE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA6EFE0", Offset = "0xA6DFE0", VA = "0x180A6EFE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public string EFMCBJLHONN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x76246D0", Offset = "0x76236D0", VA = "0x1876246D0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public NNIJHHALHAM FIFPILEIAAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xC20970", Offset = "0xC1F970", VA = "0x180C20970", Slot = "24")]
		get
		{
			return default(NNIJHHALHAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public string CMGKJAEFCGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x76246D0", Offset = "0x76236D0", VA = "0x1876246D0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public string MDMHNCCIHNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool JMFDMFFPKIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public LCEGHIAIKNO BINKMCLKKCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xAB2410", Offset = "0xAB1410", VA = "0x180AB2410", Slot = "30")]
		get
		{
			return default(LCEGHIAIKNO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public string MAAJPELBEBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public NHKFIOBDEOB? GFOCKIGHJLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x76246F0", Offset = "0x76236F0", VA = "0x1876246F0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public FCEOMOKNMBM EIOIDAPMIGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xC20970", Offset = "0xC1F970", VA = "0x180C20970", Slot = "33")]
		get
		{
			return default(FCEOMOKNMBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool CAGJLKHEGMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public GICBMFJFHLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x10A13E0", Offset = "0x10A03E0", VA = "0x1810A13E0")]
	public GICBMFJFHLI([Optional] Guid GKOPHJCJIFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7624520", Offset = "0x7623520", VA = "0x187624520", Slot = "35")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7624440", Offset = "0x7623440", VA = "0x187624440", Slot = "36")]
	[AsyncStateMachine(typeof(LOILJLIKFDK))]
	public Task AHKNCNAGGLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7624740", Offset = "0x7623740", VA = "0x187624740")]
	public GICBMFJFHLI PBLMCCENHMO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[KGCDFDOGPOJ]
public class KKOJBEFNMCA : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public string FMJEMOMMPEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int CCNIGPGEOLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAAD190", VA = "0x180AAE190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public int? HDOIABFHJGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x13447D0", Offset = "0x13437D0", VA = "0x1813447D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1036A60", Offset = "0x1035A60", VA = "0x181036A60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string ELAHHMIGECH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public KLKIFENPGNG HLPFIPKJLFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA7E570", Offset = "0xA7D570", VA = "0x180A7E570")]
		[CompilerGenerated]
		get
		{
			return default(KLKIFENPGNG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xE85250", Offset = "0xE84250", VA = "0x180E85250")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public LKCKEMAEFKH? DMLGKBPHPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xAB01F0", Offset = "0xAAF1F0", VA = "0x180AB01F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xAB0200", Offset = "0xAAF200", VA = "0x180AB0200")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public KKOJBEFNMCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[KGCDFDOGPOJ]
public class MCEHDHECECM : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public int AOGOJDELICJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int? HDOIABFHJGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1344790", Offset = "0x1343790", VA = "0x181344790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x134F680", Offset = "0x134E680", VA = "0x18134F680")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public string HMMEHGMBMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public string ELAHHMIGECH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public MCEHDHECECM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[KGCDFDOGPOJ]
public class LAIGIFOGEEF : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int? HDOIABFHJGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public string ELAHHMIGECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public LAIGIFOGEEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct CAEAOLJGJJG
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static int FMHKBIDBFKK;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static int PHPMMICPAOB;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int OMBEIOFJGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xD8A410", Offset = "0xD89410", VA = "0x180D8A410")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x14E7060", Offset = "0x14E6060", VA = "0x1814E7060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int MLBFJMOOJPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7620CF0", Offset = "0x761FCF0", VA = "0x187620CF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public static CAEAOLJGJJG HPFHFAKCNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7620D40", Offset = "0x761FD40", VA = "0x187620D40")]
		get
		{
			return default(CAEAOLJGJJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7620DE0", Offset = "0x761FDE0", VA = "0x187620DE0")]
	public CAEAOLJGJJG(int MPGOJNFFOCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[KGCDFDOGPOJ]
public class JAPPHCIDNOE : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int KEILPENKGPI
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public int? IFEDNGCJHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x1344790", Offset = "0x1343790", VA = "0x181344790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x134F680", Offset = "0x134E680", VA = "0x18134F680")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public string? PKCPPLKFBIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7626340", Offset = "0x7625340", VA = "0x187626340")]
	public JAPPHCIDNOE(int NFLPOBMAEIC, int? ECAPDPKHFJP, string? OBCNAJEENCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public JAPPHCIDNOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[KGCDFDOGPOJ]
public class IIGOGLBODJE : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public HECOHKEBNCH.KNJAGINBKLC OLGEMOHDHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(HECOHKEBNCH.KNJAGINBKLC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public string POHGFELOPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public int? FKOMAKLKKMO
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xDCBC10", Offset = "0xDCAC10", VA = "0x180DCBC10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public IIGOGLBODJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface NOGPCPONLFN
{
	[Cpp2IlInjected.Token(Token = "0x17000076")]
	long HIMOPBJGEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Guid ELCENCJKGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Guid HFOOKKOGBFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	string BPJJFBMKJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	string BONMGGIFIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	int MGCKOPBBIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	string OKENAAEAHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	string DKCJDPMMLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	string NPHIPHJELPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	string OBBHGFINHGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	int GIEMNBHFHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[KGCDFDOGPOJ]
public class LGJPMPJMEPN : NOGPCPONLFN, PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public long HIMOPBJGEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Guid ELCENCJKGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xD36D60", Offset = "0xD35D60", VA = "0x180D36D60", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xF0BE40", Offset = "0xF0AE40", VA = "0x180F0BE40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Guid HFOOKKOGBFK
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x13AC120", Offset = "0x13AB120", VA = "0x1813AC120", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x14BC880", Offset = "0x14BB880", VA = "0x1814BC880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public DateTime POBHENPHPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA672F0", Offset = "0xA662F0", VA = "0x180A672F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public string BPJJFBMKJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA674F0", Offset = "0xA664F0", VA = "0x180A674F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public string BONMGGIFIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA68520", Offset = "0xA67520", VA = "0x180A68520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int MGCKOPBBIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xE55690", Offset = "0xE54690", VA = "0x180E55690", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xFA3790", Offset = "0xFA2790", VA = "0x180FA3790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public string OKENAAEAHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA63170", Offset = "0xA62170", VA = "0x180A63170", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xA631B0", Offset = "0xA621B0", VA = "0x180A631B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public string DKCJDPMMLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xA63190", Offset = "0xA62190", VA = "0x180A63190", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA631F0", Offset = "0xA621F0", VA = "0x180A631F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public string NPHIPHJELPB
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xA63200", Offset = "0xA62200", VA = "0x180A63200", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA631C0", Offset = "0xA621C0", VA = "0x180A631C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public string OBBHGFINHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA631A0", Offset = "0xA621A0", VA = "0x180A631A0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA63180", Offset = "0xA62180", VA = "0x180A63180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int GIEMNBHFHNI
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xAD32E0", Offset = "0xAD22E0", VA = "0x180AD32E0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xFF9D10", Offset = "0xFF8D10", VA = "0x180FF9D10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "15")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public LGJPMPJMEPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Flags]
public enum NEJIBLDMMMK
{
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Shirt = 1,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum PBFFECJMOHO
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
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class NOIMMCGLAKI
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x76297E0", Offset = "0x76287E0", VA = "0x1876297E0")]
	public static int? NDHEADNDCCM(NEJIBLDMMMK? CCECKECFFLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7629750", Offset = "0x7628750", VA = "0x187629750")]
	public static int? DOHNAMNIDMP(PBFFECJMOHO? NOBBCIBBGDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[KGCDFDOGPOJ]
public class OECIPFCLMKF : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public string FMJEMOMMPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public int? CCNIGPGEOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xDCBC10", Offset = "0xDCAC10", VA = "0x180DCBC10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public KLKIFENPGNG? HLPFIPKJLFA
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xA683D0", Offset = "0xA673D0", VA = "0x180A683D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public OECIPFCLMKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[KGCDFDOGPOJ]
public class KIENMMJAMGO : MDEIMOHHOIO, PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Guid ELCENCJKGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE60", Offset = "0xE5DE60", VA = "0x180E5EE60")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE70", Offset = "0xE5DE70", VA = "0x180E5EE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public byte NCCGFBHCLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xA68390", Offset = "0xA67390", VA = "0x180A68390")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA68440", Offset = "0xA67440", VA = "0x180A68440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public KIENMMJAMGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class ODECOFLEEEI
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7629D10", Offset = "0x7628D10", VA = "0x187629D10")]
	public static OEGPLENCKHH FECIJKIONBE(this KIENMMJAMGO OLHDOIOOPGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface JIEDBCKBNMB
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	Guid ELCENCJKGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	int AOGOJDELICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	string FMJEMOMMPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	int CCNIGPGEOLH
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	KLKIFENPGNG HLPFIPKJLFA
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	bool DHDHDOCNEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	bool KPLGPOICBAH
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	bool BCPDELNEAJP
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	int? HDOIABFHJGD
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	string ELAHHMIGECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	string HMMEHGMBMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string MDNFIIEDKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	DateTime POBHENPHPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	DateTime GIPIHLKJPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	LKCKEMAEFKH DMLGKBPHPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	string DPMHKJDBLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	int GIEMNBHFHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	string EFMCBJLHONN
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7626970", Offset = "0x7625970", VA = "0x187626970", Slot = "19")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface BEOKPOAAHPI
{
	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	IReadOnlyList<NOGPCPONLFN> DMOOABKHCDD
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	Guid ELCENCJKGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	int AOGOJDELICJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	bool BCPDELNEAJP
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	int GIEMNBHFHNI
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	int? HDOIABFHJGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	KLKIFENPGNG HLPFIPKJLFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class EADLCOCJAGD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct MHGCLPFJDHA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public IEnumerable<GBHAIMFMHCK> list;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7628C70", Offset = "0x7627C70", VA = "0x187628C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7628F20", Offset = "0x7627F20", VA = "0x187628F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7623250", Offset = "0x7622250", VA = "0x187623250")]
	public static bool IANBCAFGFNL(this IEnumerable<PDDMBELEHHJ> KKAPDLIJLLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7623180", Offset = "0x7622180", VA = "0x187623180")]
	[AsyncStateMachine(typeof(MHGCLPFJDHA))]
	public static Task ENPAFANJFKN(this IEnumerable<GBHAIMFMHCK> KKAPDLIJLLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct IGPFHMHPKCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly string LAFAEPNEHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly string ELFMIMIFBHP;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public static readonly IGPFHMHPKCI NKEMJGNDPHC;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0xBDB810", Offset = "0xBDA810", VA = "0x180BDB810")]
	public IGPFHMHPKCI(string HDCLHHGFDJB, string EGEGACCNNEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x1365840", Offset = "0x1364840", VA = "0x181365840")]
	public bool AENKCNBBPNI(IGPFHMHPKCI EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7625720", Offset = "0x7624720", VA = "0x187625720", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7625800", Offset = "0x7624800", VA = "0x187625800", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7625870", Offset = "0x7624870", VA = "0x187625870")]
	public static bool PHGIAKEDBEK(IGPFHMHPKCI AKPAAKDLPCB, IGPFHMHPKCI AIKJCCNDBKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x76256A0", Offset = "0x76246A0", VA = "0x1876256A0")]
	public static bool BDCEBPMLGHE(IGPFHMHPKCI AKPAAKDLPCB, IGPFHMHPKCI AIKJCCNDBKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface JMKFEKCDMCC
{
	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	JMHHOKPEFKH IPPLPEJMEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	string MGLAGJIOFGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	string LKONONPOIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	long EKDAKHPKILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	string IKENPIPLANC
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	string KOFPOOKKMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	string FLBPJLKLELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	string PKPNMEFMPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[KGCDFDOGPOJ]
public class DOJFFEEEKII : GPAOEDAEJCH
{
	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public string PDDMINHECFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public MPHGIOPJEPI EIKHIKKPHDL
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return default(MPHGIOPJEPI);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAAD190", VA = "0x180AAE190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public CBFAPMGFMOF FFKNLKKMIOA
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xC333D0", Offset = "0xC323D0", VA = "0x180C333D0")]
		[CompilerGenerated]
		get
		{
			return default(CBFAPMGFMOF);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x1034ED0", Offset = "0x1033ED0", VA = "0x181034ED0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public GOHMOAOEAGK OHCNGPEMDBG
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA655B0", Offset = "0xA645B0", VA = "0x180A655B0")]
		[CompilerGenerated]
		get
		{
			return default(GOHMOAOEAGK);
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA655C0", Offset = "0xA645C0", VA = "0x180A655C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	[DataMember(Name = "Header")]
	public string? ACLDMHKPPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public string? GPMDGHINACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public string? INPFBOEGAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA674F0", Offset = "0xA664F0", VA = "0x180A674F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public List<string> OHNHHBEILBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA68520", Offset = "0xA67520", VA = "0x180A68520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public List<IKMJJBJKLKO> JINEFPFDAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA631E0", Offset = "0xA621E0", VA = "0x180A631E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA631D0", Offset = "0xA621D0", VA = "0x180A631D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7623030", Offset = "0x7622030", VA = "0x187623030", Slot = "5")]
	public override void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7623040", Offset = "0x7622040", VA = "0x187623040")]
	public DOJFFEEEKII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum GNCILICDFPH
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
[Cpp2IlInjected.Token(Token = "0x2000038")]
public enum MPHGIOPJEPI
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Vertical,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Horizontal
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum CBFAPMGFMOF
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Small,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Medium,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Large
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum GOHMOAOEAGK
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Before,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	After
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[KGCDFDOGPOJ]
public class IKMJJBJKLKO : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public GNCILICDFPH MOIDBMFBCKI
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(GNCILICDFPH);
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public string? MPJBFMHEFGD
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	[DataMember(Name = "LinkParameter")]
	public string? CCGGJGNMMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public string? HCCFDDNOFBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public IKMJJBJKLKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public abstract class GPAOEDAEJCH : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	[IgnoreDataMember]
	public string? JCCHHCBFBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void CPOBHIECLEN();

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7624A50", Offset = "0x7623A50", VA = "0x187624A50")]
	protected GPAOEDAEJCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[KGCDFDOGPOJ]
public class GCKDHJBEKNO : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public string? LHHDGMOHGNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public GCKDHJBEKNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[KGCDFDOGPOJ]
public class AKHLAKOFIHP : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	internal static Func<string, DOJFFEEEKII>? AEPIGKGHJGK;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	internal static Func<string, GHOPELIDMPB>? MBGMHBANENH;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public string? LHHDGMOHGNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public string? PIAIBKFEAGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool IAELKPOKEJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA68390", Offset = "0xA67390", VA = "0x180A68390")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA68440", Offset = "0xA67440", VA = "0x180A68440")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public NLJFAOJNHDJ MHOGLAOACFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xC333D0", Offset = "0xC323D0", VA = "0x180C333D0")]
		[CompilerGenerated]
		get
		{
			return default(NLJFAOJNHDJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x1034ED0", Offset = "0x1033ED0", VA = "0x181034ED0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public JKLAMDFOKAK APLLFOLCHGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA655B0", Offset = "0xA645B0", VA = "0x180A655B0")]
		[CompilerGenerated]
		get
		{
			return default(JKLAMDFOKAK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA655C0", Offset = "0xA645C0", VA = "0x180A655C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public int FLLGNJHECIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xAB2090", Offset = "0xAB1090", VA = "0x180AB2090")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x15F2D40", Offset = "0x15F1D40", VA = "0x1815F2D40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public DateTime AILMNHBJFBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA68450", Offset = "0xA67450", VA = "0x180A68450")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	[DataMember(Name = "IsRead")]
	internal bool CFHJGJEIOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xABB4F0", Offset = "0xABA4F0", VA = "0x180ABB4F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xABBF50", Offset = "0xABAF50", VA = "0x180ABBF50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[IgnoreDataMember]
	public bool NNEAPNANGCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x14E9270", Offset = "0x14E8270", VA = "0x1814E9270")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x14E8B40", Offset = "0x14E7B40", VA = "0x1814E8B40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public GPGBJBAHPHO BMPKJKENDOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA7E580", Offset = "0xA7D580", VA = "0x180A7E580")]
		[CompilerGenerated]
		get
		{
			return default(GPGBJBAHPHO);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x16B9510", Offset = "0x16B8510", VA = "0x1816B9510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public FOIIKGEPCAC FGMBGDAGEHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xD16000", Offset = "0xD15000", VA = "0x180D16000")]
		[CompilerGenerated]
		get
		{
			return default(FOIIKGEPCAC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xF6BDC0", Offset = "0xF6ADC0", VA = "0x180F6BDC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	internal string? NCDPCBELGCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA68520", Offset = "0xA67520", VA = "0x180A68520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	[IgnoreDataMember]
	public DOJFFEEEKII? OAHOMHBFKCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7620720", Offset = "0x761F720", VA = "0x187620720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	[IgnoreDataMember]
	public GHOPELIDMPB? JJPPAJMBFGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x76207A0", Offset = "0x761F7A0", VA = "0x1876207A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	[IgnoreDataMember]
	public GPAOEDAEJCH? AMJBGPGIIGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xA631E0", Offset = "0xA621E0", VA = "0x180A631E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA631D0", Offset = "0xA621D0", VA = "0x180A631D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x76203F0", Offset = "0x761F3F0", VA = "0x1876203F0", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0xA8B150", Offset = "0xA8A150", VA = "0x180A8B150")]
	public AKHLAKOFIHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[KGCDFDOGPOJ]
public class DADHFKIIDKN : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public FABAMIFHDHM JDPJHLEHOLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(FABAMIFHDHM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public string NMKOOIECFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public int GDMDDBFEGIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAAD190", VA = "0x180AAE190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7621890", Offset = "0x7620890", VA = "0x187621890")]
	public DADHFKIIDKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[KGCDFDOGPOJ]
public class GHOPELIDMPB : GPAOEDAEJCH
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public string HKANNBMMEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public string? GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public FCKPHPNMKJL PGGIDMMHNCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA655B0", Offset = "0xA645B0", VA = "0x180A655B0")]
		[CompilerGenerated]
		get
		{
			return default(FCKPHPNMKJL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA655C0", Offset = "0xA645C0", VA = "0x180A655C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	[DataMember(Name = "all_conditions_required")]
	public bool HDDHPHBDIAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x17CDF60", Offset = "0x17CCF60", VA = "0x1817CDF60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x1003DA0", Offset = "0x1002DA0", VA = "0x181003DA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public List<DADHFKIIDKN> IFBHLCDADBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7624370", Offset = "0x7623370", VA = "0x187624370", Slot = "5")]
	public override void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7624380", Offset = "0x7623380", VA = "0x187624380")]
	public GHOPELIDMPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum FOIIKGEPCAC
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	ContentBlock,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	JustInTimeTutorialTrigger
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum GPGBJBAHPHO
{
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	Announcements,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	JustInTimeTutorials
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum FCKPHPNMKJL
{
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	Unknown = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	MakerPenButtonHighlight = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	PlaceControlTutorial = 3
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum FABAMIFHDHM
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
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface MOIKMIFDCGA
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	bool JBGEHAJPHIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	FHLIAIDPCMK<AKHLAKOFIHP> DFOGMPIDIMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	FHLIAIDPCMK<string> DDLOCHPLOCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	FHLIAIDPCMK<AKHLAKOFIHP> KNJPHCEFODB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	FHLIAIDPCMK<AKHLAKOFIHP> JMJDMHKHMLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<AKHLAKOFIHP> NMLLFKDOJPC(GPGBJBAHPHO JHPFOADKPKM);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<AKHLAKOFIHP> DJLGPBPIOJG(GPGBJBAHPHO JHPFOADKPKM);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AKHLAKOFIHP AJGCDDEIJNM(GPGBJBAHPHO JHPFOADKPKM, string MDNCLKPJKMB);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AKHLAKOFIHP IFKABNDIDFE(GPGBJBAHPHO JHPFOADKPKM);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FCLMJNMIEBN(GPGBJBAHPHO JHPFOADKPKM);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int FGPHIHBGGGH(GPGBJBAHPHO JHPFOADKPKM);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task OGLLJECKMIK();

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task LJCFGKMGNNL(AKHLAKOFIHP OBCNAJEENCI);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface NNBHCKAIOLB
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	KEIGBLMDBHM PCEKFIODPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	int GHKMFNEAAIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	bool LIDPBLNKKPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	bool MDFKPFGPLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	bool FNGHHEEDHNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	bool IDLOMBFJJCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	bool IIECOODNMCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	bool HAPIBLLIKKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	bool CFIMPGLMLNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	bool LODKKHODADG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	bool CCMONJCBJIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	bool APMBGDFLKDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action MCOCPJDEOEC;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action LFJNLJKIDMP;

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	KPIPLFECKNC<OGPFCMPFJKL> CHGEEFABLNL(int ADMJEODDOFE);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	JCFICNGFDLA AMPOAMIGGMJ(DateTime DLGJJINFNNB);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "18")]
	JCFICNGFDLA PCEMDMEGIOG(string FGOCIDILMJI);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task JBDDNOJNKBC([Optional] CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public enum CMDJMDAOHNP
{
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Memory,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	Multiplayer
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class DHKBBCGPMFB
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7622940", Offset = "0x7621940", VA = "0x187622940")]
	public static string OPHDEPMCKCO(this CMDJMDAOHNP LPCBDHDNPKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface ALHKGIODMJF
{
	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<AKHLAKOFIHP>> HHDLIBMHOPP(GPGBJBAHPHO JHPFOADKPKM);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LJCFGKMGNNL(string MDNCLKPJKMB);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface NNABLPOHOPG
{
	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ENKMHKODPPB> GCFGGPBFONG();
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface DJGEGMOELGF
{
	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KPIPLFECKNC<List<LOFDJEDAGHN>> GKPNEOBMMGN();

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KPIPLFECKNC<List<LOFDJEDAGHN>> DHHFFDHPEKK();

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<LOFDJEDAGHN>> KGAOKMJNEAP([Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KPIPLFECKNC<List<LOFDJEDAGHN>> DELPBBBJDOD(List<NPHONPGHNPF> OOCOPMLOMDO);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KPIPLFECKNC<List<LOFDJEDAGHN>> ELAKLPNBBLC(List<NPHONPGHNPF> OOCOPMLOMDO);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface LBIOJOKOPKD
{
	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	List<JKKPLHHIIHB> NGNPOEKNOFF
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<BLACPMBKBHH> KLKAMKDFCHK;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<JKKPLHHIIHB> KBPNKLFLOOK;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JCFICNGFDLA JNOFIOCFEAF(JKKPLHHIIHB NJOIGDNEPCO);

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task GMFNLLPJCHL(JKKPLHHIIHB NJOIGDNEPCO);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[Obsolete("Alternate gift contexts are being phased out. Use LocalRequestGiftPackage(GiftContext context, string message) instead")]
	KPIPLFECKNC<JKKPLHHIIHB> EEGLOJEMHCL(EHFKNLKDDIE IEGLIFIOOBM, EHFKNLKDDIE? NPDCHNJHIHF, bool EFNINDDKIKP, string OBCNAJEENCI);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KPIPLFECKNC<JKKPLHHIIHB> EEGLOJEMHCL(EHFKNLKDDIE IEGLIFIOOBM, string OBCNAJEENCI);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void POHLBHNGNNI(JKKPLHHIIHB KNDABOLHAMI, bool MKFLNCMIJBN = false, bool PCIDDBOCDLE = false, bool MEOANGCBNOB = true);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KPIPLFECKNC<List<JKKPLHHIIHB>> DIEPCDCMOLA();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface GKFIHAILHBC
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	string LHNLIGLPNAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	bool NGFEKIIBBFG
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JCFICNGFDLA HAJAIOAGNGP();

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JCFICNGFDLA MHAKHEFGBNH(string IPLOBKPOFBJ, string JONPDPKJANH);

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JCFICNGFDLA OIEMOABKCLI(string CGOJKJICCHA);

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HOHOILNCFON();

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<IPOPBMDNECB> NMLEGFMJCOC(string FGOCIDILMJI, string CGOJKJICCHA, bool OMLCGIDOABL, string IBJKONKIHIO, string COFIOMPJHHB, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task OODEDOLFODA(int ADMJEODDOFE, string LGDPMEAFAPA, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task PIDJAPOAMNP(int ADMJEODDOFE, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task ABIBNAKEDIB([Optional] CMDJMDAOHNP? KIIBOKHBFFK, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<IReadOnlyList<JFNLOOKKAPG>> DHODMPKBMIG([Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task HAECOEFJDMH([Optional] CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface DMLAOHOECBN
{
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<BJBNOKPEAKM>> KFFLMNPMPEF([Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<List<JNONGEHGOKJ>> BKGICBCBBHL([Optional] CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface CCGBOIFIACP
{
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EKOMCIHAAMA([Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMGOHOCPKHH();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface GLHENIPIGOB
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event NLFLCLHHNKF? JAIAEJFFLJE;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event NLFLCLHHNKF? ANGMNNAOCJK;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event NLFLCLHHNKF? MCNPCHNELMN;

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<KPPNBDELPNB> BLIPPJKJOCH();

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<KPPNBDELPNB?>? NLPLLJHFIND(int ADMJEODDOFE);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<List<KJNCFCMCNHA>> OFAOKBHFPFG(List<int> ALACHPAOFMD);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<IReadOnlyDictionary<int, KPPNBDELPNB>> MEHHEHBJFJD();

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<List<KPPNBDELPNB?>?>? KKAJKEBOHLA(int ADMJEODDOFE);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task BDIODGAGNMH(int GBBHBDCDACM);

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<JFNAKFCGDAO> FJBLJLLEIFD(KPPNBDELPNB POKKKEFLBBE);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate void NLFLCLHHNKF(int ADMJEODDOFE, int GBBHBDCDACM, KPPNBDELPNB? POKKKEFLBBE);
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface PGLIGOEGHJD : LEBCBPHLODN, DGIFEDFLGAO
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[Flags]
	public enum LIAJBMKEENE
	{
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		FilterProfanity = 1,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		FilterURL = 2
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	string FNDMDHICFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	KPOJCHHIMDA IEENIHLPBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	NLJFAOJNHDJ MHOGLAOACFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	string MDKPCGJFKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	byte HEHECCIBHIG
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	int IKEFPFDJBOC
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	int IMKKDHDCEMA
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	bool EINLGCICINM
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	bool PHMMBCOGONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	bool KAPNDDFDBOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	bool KHPGFIPBLNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	bool ICPEHIFMNDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	bool GJPLMMHABCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	bool OJFCMGKGKMG
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KPIPLFECKNC<string> LONMPEOKALE();

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<string> EOAHDHEOBBD();

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "15")]
	KPIPLFECKNC<bool> IsPlayerCommunicationRestricted(int ADMJEODDOFE);

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string NNKBLKIHJID(string HJLBILHBIIC, bool BMPKPKEMIJM = true);

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<string> OCAOIIKDKHJ(string HJLBILHBIIC, bool BMPKPKEMIJM = true);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "18")]
	KPIPLFECKNC<string> MakeRoomNameAdhereToPlatformRequirements(long DJJNJEHBMJK, string HJLBILHBIIC);

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool SanitizeDisplayText(string GCANJFEOHCH, LIAJBMKEENE LOJCMMOFNJK = LIAJBMKEENE.FilterProfanity | LIAJBMKEENE.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<string> SanitizeDisplayTextAsync(string GCANJFEOHCH, LIAJBMKEENE LOJCMMOFNJK = LIAJBMKEENE.FilterProfanity | LIAJBMKEENE.FilterURL, bool JHDKPFGPKDM = false);

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool CheckNameForProfanity(string HJLBILHBIIC, LIAJBMKEENE LOJCMMOFNJK = LIAJBMKEENE.FilterProfanity | LIAJBMKEENE.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(Slot = "23")]
	KPIPLFECKNC<string> GetCommerceSubscriptionAccessToken();
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface INODNHBNNLJ
{
	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<ACIKKHACKIE>> OKJAIPOCMNH([Optional] CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface LOBODODGMFP
{
	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BLDFMLMAFLH(byte[] EGEGACCNNEK, byte[] EILOAAEKMEI);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface FPBNEPHLLEL
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EAGAFOCJJGE(string KLFAFCNDMKC);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface NPDKBHGENLI
{
	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	FHLIAIDPCMK<AMMNGPJBAPM> BGIGMNDGJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<bool> FGKHDPGHMPK(string AJDJOPIJBJN);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<ICKDEJCADDN> GKKHLGGPKAK(string AJDJOPIJBJN, string GJINJHNOOGF);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task MLMCOGFLOAK(string AJDJOPIJBJN, IEnumerable<string> FHCCMLOFJCC, int NBGNFJAHIKJ = 0);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<KGOJLHJNIOD<FilteredTextDTO>>> GKOAAIJEJJE(uint GNGFEKDNLIL, IEnumerable<string> FHCCMLOFJCC);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface FDDNIEBPMDD
{
	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LFFNAAECJPM([Out] bool IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HEKBCPBJBOJ([Out] bool IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HOGFICILDNN([Out] int IOALKPFEKEK);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public enum HJMAHCAAPEA
{
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	BasedOnBirthday,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	ModerationOverride,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	PendingOverride
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum LIAMBGCMNIP
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Id,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Email,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Phone
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[Flags]
public enum OOCDMFJLNGG
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
[Cpp2IlInjected.Token(Token = "0x200005C")]
[Flags]
public enum EFFHBNIFNBE
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
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum OODBICPLLCA
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
[Cpp2IlInjected.Token(Token = "0x200005E")]
public enum PFKKBBBMJCN
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
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface OGPFCMPFJKL
{
	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	int PMFGNEEOBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	string KGLJMCPPOPP
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	string CKGAPOECMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	string OPHPCFIACIG
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	string CPGBPBKDADF
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	string MPMMEMJMMEP
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	string KGMGEPJHGLN
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	bool GBDJOLNHIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	bool PLJKPIJCGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	OOCDMFJLNGG PMHCHDFPFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	EFFHBNIFNBE KBIEHEPBJDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	DateTime POBHENPHPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	bool? CJJOJOLNKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IMJODCHKPMP(bool LCBMIBJJNEI);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MHBKALEDEEH(bool GODBCDKBODC);
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface KEIGBLMDBHM : OGPFCMPFJKL
{
	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	string DDFCGGIJOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	string MLLIBCPANGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	DateTime? MLIBADJBOGI
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	HJMAHCAAPEA DHBNEHKBMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	int? HCPLMMFJOFC
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	int IKDDCNDLDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	bool ELFOKAKAALK
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	bool CPJHLPLLHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	bool? PNHIHBPNOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class AKJEAMCCEOH
{
	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public OGPFCMPFJKL COBBPNDHHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public LIAMBGCMNIP MOAJMNAMJIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
		[CompilerGenerated]
		get
		{
			return default(LIAMBGCMNIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public string BBOJEDBDOCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x6FAA230", Offset = "0x6FA9230", VA = "0x186FAA230")]
	public AKJEAMCCEOH(OGPFCMPFJKL IMFCGBBJLBP, LIAMBGCMNIP DENDONFDMIE, string COPMNEKAFEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface DICKMBOPPKH
{
	[Cpp2IlInjected.Token(Token = "0x17000118")]
	int PMFGNEEOBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	bool BJOPEKOKLNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface MCIHPDFFJEF
{
	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	int PMFGNEEOBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	bool KPGGKBMGJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface HIBHBHCKFGA
{
	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	int PMFGNEEOBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	string GOFPIOCLDKO
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public enum NHKFIOBDEOB
{
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	Outfit,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	HairDye,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	CustomOutfit
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class LOFDJEDAGHN
{
	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public NHKFIOBDEOB GFOCKIGHJLA
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(NHKFIOBDEOB);
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public string MDMHNCCIHNN
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public string AJGLPJMALDM
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public LCEGHIAIKNO BINKMCLKKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xA655B0", Offset = "0xA645B0", VA = "0x180A655B0")]
		[CompilerGenerated]
		get
		{
			return default(LCEGHIAIKNO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA655C0", Offset = "0xA645C0", VA = "0x180A655C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public string CLJHMGGBPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public int NJPDBAHKIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xA7E570", Offset = "0xA7D570", VA = "0x180A7E570")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xE85250", Offset = "0xE84250", VA = "0x180E85250")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public bool IBPHFKHBPFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xF67FD0", Offset = "0xF66FD0", VA = "0x180F67FD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xF68040", Offset = "0xF67040", VA = "0x180F68040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public NPHONPGHNPF DPCKDLIPHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x14C1DC0", Offset = "0x14C0DC0", VA = "0x1814C1DC0")]
		[CompilerGenerated]
		get
		{
			return default(NPHONPGHNPF);
		}
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7628460", Offset = "0x7627460", VA = "0x187628460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public IJBOOMIFELF IIDJPOIMNCD
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1BA3D30", Offset = "0x1BA2D30", VA = "0x181BA3D30")]
		[CompilerGenerated]
		get
		{
			return default(IJBOOMIFELF);
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x4EF3FA0", Offset = "0x4EF2FA0", VA = "0x184EF3FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public string GFNJLPJCIFM
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA6EEA0", Offset = "0xA6DEA0", VA = "0x180A6EEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA6F010", Offset = "0xA6E010", VA = "0x180A6F010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public DateTime POBHENPHPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xA6F020", Offset = "0xA6E020", VA = "0x180A6F020")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x593A760", Offset = "0x5939760", VA = "0x18593A760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7628480", Offset = "0x7627480", VA = "0x187628480")]
	internal LOFDJEDAGHN(BGJHOEKDNED ECMNPBCMACO, CLNKPHMDENM BMFGHBAEOPO, CAOGJAKDFBC BJHBFIMLHOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x76286E0", Offset = "0x76276E0", VA = "0x1876286E0")]
	public LOFDJEDAGHN(NHKFIOBDEOB GCGJCGCJKGO = NHKFIOBDEOB.Outfit, [Optional] NPHONPGHNPF PCGMDGMBHEJ, [Optional] string MHAJOEPCBAD, [Optional] string CFCJBFAKNLE, LCEGHIAIKNO JILJLIPAFBE = LCEGHIAIKNO.Common, [Optional] string FCEPJMFIHKN, int LBCLDJLEFBH = 0, bool NEGLAKDFGEA = false, [Optional] string ONNIIHOIGGD, [Optional] DateTime? IJEADHNFPOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[KGCDFDOGPOJ]
public class BGJHOEKDNED : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public NHKFIOBDEOB GFOCKIGHJLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(NHKFIOBDEOB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	[DataMember(Name = "AvatarItemDesc")]
	public string FIAGJGDMOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public string MDMHNCCIHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public string AJGLPJMALDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public LCEGHIAIKNO BINKMCLKKCI
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA674E0", Offset = "0xA664E0", VA = "0x180A674E0")]
		[CompilerGenerated]
		get
		{
			return default(LCEGHIAIKNO);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xA672E0", Offset = "0xA662E0", VA = "0x180A672E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public string CLJHMGGBPFA
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public int NJPDBAHKIKN
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xD16000", Offset = "0xD15000", VA = "0x180D16000")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xF6BDC0", Offset = "0xF6ADC0", VA = "0x180F6BDC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool IBPHFKHBPFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x18C67D0", Offset = "0x18C57D0", VA = "0x1818C67D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x190F880", Offset = "0x190E880", VA = "0x18190F880")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public string MGPIDCJIJMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xA68520", Offset = "0xA67520", VA = "0x180A68520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public DateTime POBHENPHPIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA631E0", Offset = "0xA621E0", VA = "0x180A631E0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xF67CD0", Offset = "0xF66CD0", VA = "0x180F67CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public BGJHOEKDNED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[KGCDFDOGPOJ]
public sealed class EGFPLBPPCCK : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public List<string> FDINPJGJJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7623490", Offset = "0x7622490", VA = "0x187623490")]
	public EGFPLBPPCCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0xA6BBE0", Offset = "0xA6ABE0", VA = "0x180A6BBE0")]
	public EGFPLBPPCCK(List<string> OOCOPMLOMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[KGCDFDOGPOJ]
public class ENKMHKODPPB : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public GBKLBADMBNE PMKJAIAEACE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public EAKOCKFILKM BMEAHMNPGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public ENKMHKODPPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0xA653E0", Offset = "0xA643E0", VA = "0x180A653E0")]
	public ENKMHKODPPB(GBKLBADMBNE FDPPLCHHCGI, EAKOCKFILKM INHIHICNHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public enum DDPNLIBDLEO
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Braze,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Rengage
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public enum EGKGFJIBHJD : byte
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
[Cpp2IlInjected.Token(Token = "0x200006C")]
[KGCDFDOGPOJ]
public class GBKLBADMBNE : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public DDPNLIBDLEO AGDGKJONINL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(DDPNLIBDLEO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public EGKGFJIBHJD? LPKMNPBFAME
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x31362A0", Offset = "0x31352A0", VA = "0x1831362A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x74B1A40", Offset = "0x74B0A40", VA = "0x1874B1A40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool NDJCFOANGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x1FFA220", Offset = "0x1FF9220", VA = "0x181FFA220")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x1FFA240", Offset = "0x1FF9240", VA = "0x181FFA240")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x76242B0", Offset = "0x76232B0", VA = "0x1876242B0")]
	public GBKLBADMBNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7624220", Offset = "0x7623220", VA = "0x187624220")]
	public GBKLBADMBNE(DDPNLIBDLEO NEMPJNNFHAK, EGKGFJIBHJD CJMBIJCINCN, bool KODAPLIGMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[KGCDFDOGPOJ]
public class EAKOCKFILKM : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public string FBKCEHCFOMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public string EFNGLIPDEPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public EAKOCKFILKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0xA653E0", Offset = "0xA643E0", VA = "0x180A653E0")]
	public EAKOCKFILKM(string JNAKAEHECNF, string DGNKCPJKOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public enum KPOJCHHIMDA
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
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct BLACPMBKBHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public JKKPLHHIIHB ACHFPPAAIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public bool MGMICGICIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public bool DNFHGMEFPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public bool JIKKOFDFOEL;
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[KGCDFDOGPOJ]
public class JKKPLHHIIHB : GBHAIMFMHCK, PDDMBELEHHJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct PAAGGJMNDJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public JKKPLHHIIHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x762A2D0", Offset = "0x76292D0", VA = "0x18762A2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x762A460", Offset = "0x7629460", VA = "0x18762A460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	internal static Action<JKKPLHHIIHB> EGMCLDCDNNB;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	internal static Func<JKKPLHHIIHB, Task> CKFBCNIAIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[IgnoreDataMember]
	public bool FNHCJPJGCBM;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public long? CMGKJAEFCGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE60", Offset = "0xE5DE60", VA = "0x180E5EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE70", Offset = "0xE5DE70", VA = "0x180E5EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public int NDDFOCHAEGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAAD190", VA = "0x180AAE190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public int? FOJIFNGJJIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x13447D0", Offset = "0x13437D0", VA = "0x1813447D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x1036A60", Offset = "0x1035A60", VA = "0x181036A60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public string MAAJPELBEBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public NHKFIOBDEOB? GFOCKIGHJLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA672F0", Offset = "0xA662F0", VA = "0x180A672F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	[DataMember(Name = "AvatarItemDesc")]
	public string NHAAEMKDIPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xA674F0", Offset = "0xA664F0", VA = "0x180A674F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Guid? ELCENCJKGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7626C30", Offset = "0x7625C30", VA = "0x187626C30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7626C20", Offset = "0x7625C20", VA = "0x187626C20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public string KMAMCLCCJLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xA63190", Offset = "0xA62190", VA = "0x180A63190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA631F0", Offset = "0xA621F0", VA = "0x180A631F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public string DFPJLDHPPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA63200", Offset = "0xA62200", VA = "0x180A63200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA631C0", Offset = "0xA621C0", VA = "0x180A631C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public PJBEJGJLLLM JHOLLGDMPCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA87C90", Offset = "0xA86C90", VA = "0x180A87C90")]
		[CompilerGenerated]
		get
		{
			return default(PJBEJGJLLLM);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x153CEB0", Offset = "0x153BEB0", VA = "0x18153CEB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public int JMPBMFNNJOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA87CF0", Offset = "0xA86CF0", VA = "0x180A87CF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x153CFE0", Offset = "0x153BFE0", VA = "0x18153CFE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public int KDILNEPACBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xAD32E0", Offset = "0xAD22E0", VA = "0x180AD32E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xFF9D10", Offset = "0xFF8D10", VA = "0x180FF9D10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public EHFKNLKDDIE LPELKDFEOMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xAD3220", Offset = "0xAD2220", VA = "0x180AD3220")]
		[CompilerGenerated]
		get
		{
			return default(EHFKNLKDDIE);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x158AB00", Offset = "0x1589B00", VA = "0x18158AB00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public LCEGHIAIKNO HIHCCGNLHGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xD1B380", Offset = "0xD1A380", VA = "0x180D1B380")]
		[CompilerGenerated]
		get
		{
			return default(LCEGHIAIKNO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x155E300", Offset = "0x155D300", VA = "0x18155E300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	[DataMember(Name = "Message")]
	public string DGPMMEBFGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA6F020", Offset = "0xA6E020", VA = "0x180A6F020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xA6EE80", Offset = "0xA6DE80", VA = "0x180A6EE80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public string CPHCAJFMILM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xAC8EE0", Offset = "0xAC7EE0", VA = "0x180AC8EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xAC54F0", Offset = "0xAC44F0", VA = "0x180AC54F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool GIKABOKIIAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xF67FB0", Offset = "0xF66FB0", VA = "0x180F67FB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xF67960", Offset = "0xF66960", VA = "0x180F67960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public NLJFAOJNHDJ MHOGLAOACFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xEF07A0", Offset = "0xEEF7A0", VA = "0x180EF07A0")]
		[CompilerGenerated]
		get
		{
			return default(NLJFAOJNHDJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xEEEF60", Offset = "0xEEDF60", VA = "0x180EEEF60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public JKLAMDFOKAK NAHOKKGKBDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xA6F000", Offset = "0xA6E000", VA = "0x180A6F000")]
		[CompilerGenerated]
		get
		{
			return default(JKLAMDFOKAK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xA6EEE0", Offset = "0xA6DEE0", VA = "0x180A6EEE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public GNCGGEBPLKF? FAPNAIGEJJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x1471610", Offset = "0x1470610", VA = "0x181471610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7626B80", Offset = "0x7625B80", VA = "0x187626B80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public bool ABHHHLDALKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7626BB0", Offset = "0x7625BB0", VA = "0x187626BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public bool EOKLMEEJEMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7626B90", Offset = "0x7625B90", VA = "0x187626B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool DBAOALDEPJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7626B60", Offset = "0x7625B60", VA = "0x187626B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	[IgnoreDataMember]
	public bool LOOCFAEHLDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xA6CBA0", Offset = "0xA6BBA0", VA = "0x180A6CBA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xA6CBC0", Offset = "0xA6BBC0", VA = "0x180A6CBC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	[IgnoreDataMember]
	public bool KJIKLILMPOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x2DDFA50", Offset = "0x2DDEA50", VA = "0x182DDFA50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x2DE01E0", Offset = "0x2DDF1E0", VA = "0x182DE01E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	[IgnoreDataMember]
	public string OABBKHJIOFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xB12000", Offset = "0xB11000", VA = "0x180B12000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xB12440", Offset = "0xB11440", VA = "0x180B12440")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	[IgnoreDataMember]
	public string PONCFADCELE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xE6C9A0", Offset = "0xE6B9A0", VA = "0x180E6C9A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xE6C9B0", Offset = "0xE6B9B0", VA = "0x180E6C9B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	[IgnoreDataMember]
	public bool BCAMMGBMKLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x1042FB0", Offset = "0x1041FB0", VA = "0x181042FB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xD07490", Offset = "0xD06490", VA = "0x180D07490")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7626B00", Offset = "0x7625B00", VA = "0x187626B00", Slot = "5")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x7626A30", Offset = "0x7625A30", VA = "0x187626A30", Slot = "6")]
	[AsyncStateMachine(typeof(PAAGGJMNDJA))]
	public virtual Task AHKNCNAGGLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x158AB00", Offset = "0x1589B00", VA = "0x18158AB00")]
	public void EEPJNHDDDLF(EHFKNLKDDIE IEGLIFIOOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public JKKPLHHIIHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface NFEBDKCPHNB
{
	[Cpp2IlInjected.Token(Token = "0x17000157")]
	long JGFOHNOHCJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	string FBICOEOAGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	int GHMIPHOAIPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	string FMJEMOMMPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	string FADJMLNMDJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	string CHIILACPAMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	byte LAHAGDBHBAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	int BOFGCMACIJH
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	int JPDANBLCHJI
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	KLKIFENPGNG HLPFIPKJLFA
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	bool DHDHDOCNEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	DateTime GIPIHLKJPLD
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	DateTime POBHENPHPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	DateTime? FHMPHNJKDAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	long? MJBNOEGHNLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	int HMECGENBCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	int EBIDCOPKCBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	int NOHHEEHLEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	KGCKBAIOBNL KICDCJBNKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	KGCKBAIOBNL NJOIIPGIFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	bool INMFMKJLDFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	bool BPCENDJFPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	bool BCPDELNEAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	bool JNIOGIOPLAL
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	int? CCNIGPGEOLH
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	bool EKHCMLOBIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	string KFHBBPOLPHL
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KHBDDCEFMDD();

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DOKHAFBOOHH();
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[KGCDFDOGPOJ]
public class OADNLHFENBN : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public List<EOPJHDOGHKN> IGKBACLFPMN
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x7629A70", Offset = "0x7628A70", VA = "0x187629A70")]
	public List<string> FAGKLKJCONJ(params EEHJEEHMEFC[] DAKNBGOPHGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x76299F0", Offset = "0x76289F0", VA = "0x1876299F0")]
	public List<string> DMDFHIHMBKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x7629C30", Offset = "0x7628C30", VA = "0x187629C30")]
	public List<string> HNNKGJJODHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7629900", Offset = "0x7628900", VA = "0x187629900", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public OADNLHFENBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[KGCDFDOGPOJ]
public class AKIEALGDHGF : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public int GHMIPHOAIPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public AKIEALGDHGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[KGCDFDOGPOJ]
public class KGLGMOJDLMG : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public long JGFOHNOHCJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public string FBICOEOAGFI
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public int HGAGMDAKJAO
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAAD190", VA = "0x180AAE190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public bool OHOAAFAHHFA
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xE3B2D0", Offset = "0xE3A2D0", VA = "0x180E3B2D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xE3AB00", Offset = "0xE39B00", VA = "0x180E3AB00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public int NPDCNGODKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA655B0", Offset = "0xA645B0", VA = "0x180A655B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA655C0", Offset = "0xA645C0", VA = "0x180A655C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public int MOIMCCHGPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xAB2090", Offset = "0xAB1090", VA = "0x180AB2090")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x15F2D40", Offset = "0x15F1D40", VA = "0x1815F2D40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public int HOBPAOKBHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA674E0", Offset = "0xA664E0", VA = "0x180A674E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xA672E0", Offset = "0xA662E0", VA = "0x180A672E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public int ALAJHFHBEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xAA1F70", Offset = "0xAA0F70", VA = "0x180AA1F70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xAA1570", Offset = "0xAA0570", VA = "0x180AA1570")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public string APNNFJEAOID
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public string EFEHJCHMIPE
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xA674F0", Offset = "0xA664F0", VA = "0x180A674F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public DateTime POBHENPHPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x1353980", Offset = "0x1352980", VA = "0x181353980")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public KLKIFENPGNG? PIPAPEEPDDN
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA631E0", Offset = "0xA621E0", VA = "0x180A631E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xF67CD0", Offset = "0xF66CD0", VA = "0x180F67CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public IReadOnlyList<Guid> LLCFINKPDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xA63170", Offset = "0xA62170", VA = "0x180A63170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xA631B0", Offset = "0xA621B0", VA = "0x180A631B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public IGPFHMHPKCI NADBAGABJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7627F90", Offset = "0x7626F90", VA = "0x187627F90")]
		get
		{
			return default(IGPFHMHPKCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7627D30", Offset = "0x7626D30", VA = "0x187627D30", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x7627C80", Offset = "0x7626C80", VA = "0x187627C80")]
	public bool AENKCNBBPNI(KGLGMOJDLMG HLOHAPABCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x7627DB0", Offset = "0x7626DB0", VA = "0x187627DB0")]
	private bool KCAKOKHKHGJ(KGLGMOJDLMG HLOHAPABCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x7627C90", Offset = "0x7626C90", VA = "0x187627C90")]
	private static bool DPPPNBLJKLN(IReadOnlyList<Guid> BOOLMNKOIDH, IReadOnlyList<Guid> LEDCIPHEACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x2A32170", Offset = "0x2A31170", VA = "0x182A32170", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public KGLGMOJDLMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[KGCDFDOGPOJ]
public class EHMGOGNAMOL : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000183")]
	public int BJIMIPGDEKB
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public EHMGOGNAMOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[KGCDFDOGPOJ]
public class FOIOABKAMOA : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000184")]
	public bool CHGPHGEDLPO
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xB3C200", Offset = "0xB3B200", VA = "0x180B3C200")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xB3C210", Offset = "0xB3B210", VA = "0x180B3C210")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public FOIOABKAMOA()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[KGCDFDOGPOJ]
	public class NewInventionRequestDTO : PDDMBELEHHJ
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
		public PHBPGMMKBJJ creatorAccountRole;

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

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xFEA4F0", Offset = "0xFE94F0", VA = "0x180FEA4F0", Slot = "4")]
		public void CPOBHIECLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x7629870", Offset = "0x7628870", VA = "0x187629870")]
		public NewInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[KGCDFDOGPOJ]
	public class AddVersionInventionRequestDTO : PDDMBELEHHJ
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

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xFEA4F0", Offset = "0xFE94F0", VA = "0x180FEA4F0", Slot = "4")]
		public void CPOBHIECLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x7620900", Offset = "0x761F900", VA = "0x187620900")]
		public AddVersionInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[KGCDFDOGPOJ]
	public class ModifyTagsRequest : PDDMBELEHHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public List<string> AutoTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public List<string> CustomTags;

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
		public void CPOBHIECLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public ModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[KGCDFDOGPOJ]
	public class InventionModifyTagsRequest : ModifyTagsRequest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public long InventionId;

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public InventionModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[KGCDFDOGPOJ]
	public class ReportRequest : PDDMBELEHHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public string Details;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public PGGELGBKEIM ReportCategory;

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
		public void CPOBHIECLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public ReportRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[KGCDFDOGPOJ]
	public class CheerRequest : PDDMBELEHHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public bool Cheer;

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
		public void CPOBHIECLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public CheerRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[KGCDFDOGPOJ]
	public class UpdatePriceRequest : PDDMBELEHHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int Price;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
		public void CPOBHIECLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public UpdatePriceRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[KGCDFDOGPOJ]
	public class UpdateInventionMetadataRequest : PDDMBELEHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		public string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public ModifyTagsRequest TagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xFEA4F0", Offset = "0xFE94F0", VA = "0x180FEA4F0", Slot = "4")]
		public void CPOBHIECLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public UpdateInventionMetadataRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[KGCDFDOGPOJ]
	public class UpdateInventionGeneralPermissionRequest : PDDMBELEHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public KGCKBAIOBNL Permission
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
			[CompilerGenerated]
			get
			{
				return default(KGCKBAIOBNL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0xA6A6F0", Offset = "0xA696F0", VA = "0x180A6A6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
		public void CPOBHIECLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public UpdateInventionGeneralPermissionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[KGCDFDOGPOJ]
	public class PublishInventionRequest : PDDMBELEHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public KGCKBAIOBNL Permission
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
			[CompilerGenerated]
			get
			{
				return default(KGCKBAIOBNL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0xA6A6F0", Offset = "0xA696F0", VA = "0x180A6A6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public KLKIFENPGNG Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0xA88A10", Offset = "0xA87A10", VA = "0x180A88A10")]
			[CompilerGenerated]
			get
			{
				return default(KLKIFENPGNG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0xE8AAE0", Offset = "0xE89AE0", VA = "0x180E8AAE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0xDCBC10", Offset = "0xDCAC10", VA = "0x180DCBC10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
		public void CPOBHIECLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public PublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[KGCDFDOGPOJ]
	public class UnpublishInventionRequest : PDDMBELEHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
		public void CPOBHIECLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public UnpublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[KGCDFDOGPOJ]
	public class DeleteInventionRequest : PDDMBELEHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
		public void CPOBHIECLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public DeleteInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[KGCDFDOGPOJ]
	public class SetInventionVersionAccessibilityRequest : PDDMBELEHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0xA6A6F0", Offset = "0xA696F0", VA = "0x180A6A6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public KLKIFENPGNG NewAccessibility
		{
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0xA88A10", Offset = "0xA87A10", VA = "0x180A88A10")]
			[CompilerGenerated]
			get
			{
				return default(KLKIFENPGNG);
			}
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0xE8AAE0", Offset = "0xE89AE0", VA = "0x180E8AAE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
		public void CPOBHIECLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public SetInventionVersionAccessibilityRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[KGCDFDOGPOJ]
	public class SpecialTags : PDDMBELEHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000196")]
		public List<string> AutoTags
		{
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		public List<string> AGOnlyTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
		public void CPOBHIECLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public SpecialTags()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public enum JCHEICCGKOB
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
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum PGGELGBKEIM
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
[Cpp2IlInjected.Token(Token = "0x2000088")]
public enum GEEPIIDNJHG
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	False,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	True,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	Invited
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public interface JFNLOOKKAPG
{
	[Cpp2IlInjected.Token(Token = "0x17000198")]
	NLJFAOJNHDJ MHOGLAOACFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	string MDKPCGJFKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	int PMFGNEEOBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	DateTime DPCFBBHBIJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	bool NJNLJJAMGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	string EBOLPNAKBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	OGPFCMPFJKL COBBPNDHHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CPOBHIECLEN();

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OACPGIOMHOD(OGPFCMPFJKL IMFCGBBJLBP);
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public interface DNDGFNIJEJC
{
	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	string FNEADOLJELE
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	int BJKDLCPHPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	bool HFPMNJCGMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CPOBHIECLEN();
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct IPOPBMDNECB
{
	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public BLCHHHGBBMN PPDHEPJEKMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xD8A410", Offset = "0xD89410", VA = "0x180D8A410")]
		[CompilerGenerated]
		readonly get
		{
			return default(BLCHHHGBBMN);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x14E7060", Offset = "0x14E6060", VA = "0x1814E7060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public DNDGFNIJEJC GHELELDHGOM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB70", Offset = "0xAE9B70", VA = "0x180AEAB70")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xEB1EC0", Offset = "0xEB0EC0", VA = "0x180EB1EC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public string IAEKAPKMLBM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x6091230", Offset = "0x6090230", VA = "0x186091230")]
	public IPOPBMDNECB(BLCHHHGBBMN CCNILHLCOLN, [Optional] DNDGFNIJEJC OFPHHFMJMDP, [Optional] string COFIOMPJHHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public enum BLCHHHGBBMN
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
[Cpp2IlInjected.Token(Token = "0x200008D")]
[KGCDFDOGPOJ]
public class BJBNOKPEAKM : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public string FFFFJADIEAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public string DPKBMGEPPLH
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public string DMHGBDFAPEO
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public string ICPOEKPLACN
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public List<DMDPMNFPHIA> PJBPOPAPLJC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public BJBNOKPEAKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x4E07D50", Offset = "0x4E06D50", VA = "0x184E07D50")]
	public BJBNOKPEAKM([Optional] string ENPMFFHMGHC, [Optional] string INKGMGIEFIG, [Optional] string ADCIBIEHABK, [Optional] string LCFONHLNEAM, [Optional] List<DMDPMNFPHIA> CBLHNPILCAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[KGCDFDOGPOJ]
public class DMDPMNFPHIA : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public string FLBPJLKLELM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public string ICPOEKPLACN
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public DMDPMNFPHIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[KGCDFDOGPOJ]
public class JNONGEHGOKJ : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public string DPKBMGEPPLH
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public string PPDHEPJEKMP
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public string FFFFJADIEAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	public List<string> MLJMHIIFPCK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public JNONGEHGOKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[KGCDFDOGPOJ]
public interface PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPOBHIECLEN();
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[KGCDFDOGPOJ]
public interface GBHAIMFMHCK : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task AHKNCNAGGLP();
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[PJGJDAFFAPJ]
public interface MDEIMOHHOIO : PDDMBELEHHJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[KGCDFDOGPOJ]
public class OEGPLENCKHH : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public Guid ELCENCJKGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE60", Offset = "0xE5DE60", VA = "0x180E5EE60")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE70", Offset = "0xE5DE70", VA = "0x180E5EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public int NCCGFBHCLAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAAD190", VA = "0x180AAE190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public string KPOCGHGHFDP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public string BONMGGIFIAH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public OEGPLENCKHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x762A0A0", Offset = "0x76290A0", VA = "0x18762A0A0")]
	public OEGPLENCKHH([Optional] Guid GKOPHJCJIFA, int MOINPJHGPMM = 0, [Optional] string OJCCNCNAAGJ, [Optional] string GACPLAOHDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[KGCDFDOGPOJ]
public class KPPNBDELPNB : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public const int LFKGFBMFLOF = 0;

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public long FEDDDAILDHH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public JMCEICICBNP OOEPOPHOIPE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public string FLAOIIODELG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public List<OEGPLENCKHH> BPILIJHAJIE
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public int PGNNIODDNJH
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xA674E0", Offset = "0xA664E0", VA = "0x180A674E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xA672E0", Offset = "0xA662E0", VA = "0x180A672E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	public KLKIFENPGNG HLPFIPKJLFA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xD16000", Offset = "0xD15000", VA = "0x180D16000")]
		[CompilerGenerated]
		get
		{
			return default(KLKIFENPGNG);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xF6BDC0", Offset = "0xF6ADC0", VA = "0x180F6BDC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public string BPJJFBMKJNI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xA68520", Offset = "0xA67520", VA = "0x180A68520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public bool DGHALFBLFCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x20EB970", Offset = "0x20EA970", VA = "0x1820EB970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7628190", Offset = "0x7627190", VA = "0x187628190")]
	public KPPNBDELPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x7628070", Offset = "0x7627070", VA = "0x187628070")]
	public KPPNBDELPNB(long DPMJAJHEHLE = 0L, [Optional] JMCEICICBNP IEAPHFHIAPM, [Optional] string FKMKLLGAJNB, [Optional] List<OEGPLENCKHH> CEHMKOOMBIF, int GBBHBDCDACM = 0, [Optional] string HJLBILHBIIC, KLKIFENPGNG MMHONOGNHPO = KLKIFENPGNG.Private, [Optional] string NJKGKIBKFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class KJNCFCMCNHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public readonly int PMFGNEEOBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public readonly KPPNBDELPNB NCLDPKLHIOF;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x1005CA0", Offset = "0x1004CA0", VA = "0x181005CA0")]
	public KJNCFCMCNHA(int ADMJEODDOFE, KPPNBDELPNB POKKKEFLBBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[KGCDFDOGPOJ]
public class JMCEICICBNP : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public string MEDCPLAHJLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	public string IBEICHEKALM
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	public string NEAALMDMMDB
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	public string IDEPLNEPIPO
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	public string IOOLIEIEMIE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	public string BPILIJHAJIE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7626C50", Offset = "0x7625C50", VA = "0x187626C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public JMCEICICBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x4E07D50", Offset = "0x4E06D50", VA = "0x184E07D50")]
	public JMCEICICBNP([Optional] string MAPBDNOMBAN, [Optional] string PCLKCIDOHMF, [Optional] string GNNANICNMLI, [Optional] string PNGHECBCHKC, [Optional] string CGNCEODDNOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[KGCDFDOGPOJ]
public class PMKLGLGAELO : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	public Dictionary<int, KPPNBDELPNB> AFANKCDHDAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public PMKLGLGAELO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[KGCDFDOGPOJ]
public class CONLNOOBMMD : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public List<int> DLOIOJHIENF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	public byte? HEHECCIBHIG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x313D170", Offset = "0x313C170", VA = "0x18313D170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x313D180", Offset = "0x313C180", VA = "0x18313D180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	public int? IKEFPFDJBOC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x13447C0", Offset = "0x13437C0", VA = "0x1813447C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x13447F0", Offset = "0x13437F0", VA = "0x1813447F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public CONLNOOBMMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class BBLINOFICJB
{
	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x7620910", Offset = "0x761F910", VA = "0x187620910")]
	public static KIENMMJAMGO DHMFBPHAODP(this OEGPLENCKHH OLHDOIOOPGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[Flags]
public enum JKLAMDFOKAK
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
[Cpp2IlInjected.Token(Token = "0x200009B")]
public enum NLJFAOJNHDJ
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
[Cpp2IlInjected.Token(Token = "0x200009C")]
[KGCDFDOGPOJ]
public class DPBJAGGKHDJ : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	[DataMember(Name = "PlayerId")]
	public int PMFGNEEOBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	public int NMBNNEHBBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xAB81E0", Offset = "0xAB71E0", VA = "0x180AB81E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0xB3D500", Offset = "0xB3C500", VA = "0x180B3D500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	public int DEMNDBOHOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xA6A6F0", Offset = "0xA696F0", VA = "0x180A6A6F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public DPBJAGGKHDJ()
	{
	}
}
namespace RecNet
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[KGCDFDOGPOJ]
	public class ProgressionEventRecordDTO : PDDMBELEHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public int PMFGNEEOBOM
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public int KDILNEPACBL
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0xAB81E0", Offset = "0xAB71E0", VA = "0x180AB81E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0xB3D500", Offset = "0xB3C500", VA = "0x180B3D500")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public int CJBMHGCHLKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0xA6A6F0", Offset = "0xA696F0", VA = "0x180A6A6F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public int OEHIKMHDGKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xA88A10", Offset = "0xA87A10", VA = "0x180A88A10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0xE8AAE0", Offset = "0xE89AE0", VA = "0x180E8AAE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public int LJBODNLBADA
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAAD190", VA = "0x180AAE190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public DateTime? ALAFCHAMOFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x13AC120", Offset = "0x13AB120", VA = "0x1813AC120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x14BC880", Offset = "0x14BB880", VA = "0x1814BC880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public int ICMODILOEAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0xA7E570", Offset = "0xA7D570", VA = "0x180A7E570")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0xE85250", Offset = "0xE84250", VA = "0x180E85250")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public ProgressionEventRecordDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x762A650", Offset = "0x7629650", VA = "0x18762A650")]
		public ProgressionEventRecordDTO(int ADMJEODDOFE = 0, int CPEEPEMAMKJ = 0, int EPHLDKPNKKD = 0, int DGJLPAEAAEN = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
		public void CPOBHIECLEN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[KGCDFDOGPOJ]
	public class ProgressionEventDTO : PDDMBELEHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public long KFDDNKNDPDK
		{
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public List<ProgressionEventRewardDTO> EKILEBFMEOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public List<KeepsakeRoomListDTO> AGGAMMLHPBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public DateTime BCGDADPLPHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0xA68450", Offset = "0xA67450", VA = "0x180A68450")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public DateTime FKKLHKEAOLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0xA672F0", Offset = "0xA662F0", VA = "0x180A672F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public DateTime PEEHANGOKBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0xF68050", Offset = "0xF67050", VA = "0x180F68050")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public bool MKHNCBDBJHA
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0xD243C0", Offset = "0xD233C0", VA = "0x180D243C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0xD4B2C0", Offset = "0xD4A2C0", VA = "0x180D4B2C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public int DKALKKGMFOP
		{
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x143B970", Offset = "0x143A970", VA = "0x18143B970")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0x2287F30", Offset = "0x2286F30", VA = "0x182287F30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public float CAANLIHKOCI
		{
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x122F480", Offset = "0x122E480", VA = "0x18122F480")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x1599190", Offset = "0x1598190", VA = "0x181599190")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public Guid? EPEGBHPOEHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x762A580", Offset = "0x7629580", VA = "0x18762A580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0x762A570", Offset = "0x7629570", VA = "0x18762A570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public string OKBEDDLAFEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0xA63200", Offset = "0xA62200", VA = "0x180A63200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xA631C0", Offset = "0xA621C0", VA = "0x180A631C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public string ADPMCJABBPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xA631A0", Offset = "0xA621A0", VA = "0x180A631A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xA63180", Offset = "0xA62180", VA = "0x180A63180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public string AFJLGEMGBJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0xA6EF90", Offset = "0xA6DF90", VA = "0x180A6EF90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xA6EEF0", Offset = "0xA6DEF0", VA = "0x180A6EEF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public string BIHANAKCEAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0xA6EEA0", Offset = "0xA6DEA0", VA = "0x180A6EEA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0xA6F010", Offset = "0xA6E010", VA = "0x180A6F010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public ProgressionEventDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x762A5A0", Offset = "0x76295A0", VA = "0x18762A5A0")]
		public ProgressionEventDTO(long MIPJHCDOMJG = 0L, [Optional] string HJLBILHBIIC, [Optional] List<ProgressionEventRewardDTO> ADLBJFMDOIH, [Optional] List<KeepsakeRoomListDTO> NJGCMCBCJNG, [Optional] DateTime NBMPCLDEACH, [Optional] DateTime EPGMGAHKPKO, [Optional] DateTime EHOBMHFCGIO, bool IIKGLMBJLHJ = false, int NNGJLGGELMH = 0, float HKLCJBGLJNE = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
		public void CPOBHIECLEN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[KGCDFDOGPOJ]
	public class KeepsakeRoomListDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public long AHMNPLBEILN
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public long KFDDNKNDPDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0xDAD320", Offset = "0xDAC320", VA = "0x180DAD320")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public int? CCHCMPGKHNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0xDCBC10", Offset = "0xDCAC10", VA = "0x180DCBC10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public int? MFANFFCIFMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0xA683D0", Offset = "0xA673D0", VA = "0x180A683D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public long? BECALIGFMAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0xF0CDA0", Offset = "0xF0BDA0", VA = "0x180F0CDA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0xF0D8F0", Offset = "0xF0C8F0", VA = "0x180F0D8F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public long PHOAEJHFOMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0xF68050", Offset = "0xF67050", VA = "0x180F68050")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public TimeSpan GCJCAMCOLIC
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x76282D0", Offset = "0x76272D0", VA = "0x1876282D0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public long BCKPPEDAEGF
		{
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0x1353980", Offset = "0x1352980", VA = "0x181353980")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public TimeSpan DLKFPIJGNCD
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x7628280", Offset = "0x7627280", VA = "0x187628280")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public int JGGNCEPMIJI
		{
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0xE55690", Offset = "0xE54690", VA = "0x180E55690")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xFA3790", Offset = "0xFA2790", VA = "0x180FA3790")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public DIMLKCOCNNK APPDPJGHOKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x12901E0", Offset = "0x128F1E0", VA = "0x1812901E0")]
			[CompilerGenerated]
			get
			{
				return default(DIMLKCOCNNK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x246F590", Offset = "0x246E590", VA = "0x18246F590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public List<KeepsakeRoomDTO> CCGEABBBCHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0xA63170", Offset = "0xA62170", VA = "0x180A63170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0xA631B0", Offset = "0xA621B0", VA = "0x180A631B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public KeepsakeRoomListDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x7628320", Offset = "0x7627320", VA = "0x187628320")]
		public KeepsakeRoomListDTO(long CEHOCNMHCFI = 0L, long MIPJHCDOMJG = 0L, [Optional] int? MHNAJBHBEMA, [Optional] int? JINBBFHGMLM, [Optional] long? CEAFPJOOGID, long EAHNEHIALFO = 0L, long GKGIEEBHPGF = 0L, int GBJJDGOJCMP = 0, DIMLKCOCNNK BIPDBFOMEHO = DIMLKCOCNNK.Standard, [Optional] List<KeepsakeRoomDTO> OAJDEAAFCHB)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[KGCDFDOGPOJ]
	public class KeepsakeRoomDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		public long GOBNHBEAAAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		public long ANKPNEKDDOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xDAD320", Offset = "0xDAC320", VA = "0x180DAD320")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		public long AHMNPLBEILN
		{
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0xDCBC10", Offset = "0xDCAC10", VA = "0x180DCBC10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public DIMLKCOCNNK HHDOJPCILPE
		{
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xA655B0", Offset = "0xA645B0", VA = "0x180A655B0")]
			[CompilerGenerated]
			get
			{
				return default(DIMLKCOCNNK);
			}
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xA655C0", Offset = "0xA645C0", VA = "0x180A655C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		public int DOPDPENGBNH
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xAB2090", Offset = "0xAB1090", VA = "0x180AB2090")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0x15F2D40", Offset = "0x15F1D40", VA = "0x1815F2D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public KeepsakeRoomDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x7628220", Offset = "0x7627220", VA = "0x187628220")]
		public KeepsakeRoomDTO(long OFIPEMIBIHJ = 0L, long DJJNJEHBMJK = 0L, long CEHOCNMHCFI = 0L, DIMLKCOCNNK BJLNCBFOGNL = DIMLKCOCNNK.Standard, int CNKAFBFIBMF = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[KGCDFDOGPOJ]
	public class ProgressionEventRewardDTO : PDDMBELEHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		public long MAPEBFBDCDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		public int DBLFBMECJGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0xA6A6F0", Offset = "0xA696F0", VA = "0x180A6A6F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public string CHIILACPAMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public int KDILNEPACBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0xA655B0", Offset = "0xA645B0", VA = "0x180A655B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0xA655C0", Offset = "0xA645C0", VA = "0x180A655C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		public int CJEGMCBNMMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0xAB2090", Offset = "0xAB1090", VA = "0x180AB2090")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0x15F2D40", Offset = "0x15F1D40", VA = "0x1815F2D40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		public bool JPAAJMMPIKH
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0xA8E4F0", Offset = "0xA8D4F0", VA = "0x180A8E4F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xA8E310", Offset = "0xA8D310", VA = "0x180A8E310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		public bool JDPHNLHIGPO
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xF00130", Offset = "0xEFF130", VA = "0x180F00130")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x1544370", Offset = "0x1543370", VA = "0x181544370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
		public void CPOBHIECLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public ProgressionEventRewardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[KGCDFDOGPOJ]
	public class ProgressionEventPurchasableXpBoostDTO : PDDMBELEHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		public Guid IPGDBCOJKJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0xE5EE60", Offset = "0xE5DE60", VA = "0x180E5EE60")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0xE5EE70", Offset = "0xE5DE70", VA = "0x180E5EE70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		public int PHPMJCNMALC
		{
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAAD190", VA = "0x180AAE190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		public int MLKOAFBPGLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0xC333D0", Offset = "0xC323D0", VA = "0x180C333D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x1034ED0", Offset = "0x1033ED0", VA = "0x181034ED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		public int MFHAHBFOFBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0xA655B0", Offset = "0xA645B0", VA = "0x180A655B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xA655C0", Offset = "0xA645C0", VA = "0x180A655C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		public long BBMIFAICDPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0xA68450", Offset = "0xA67450", VA = "0x180A68450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		public long KNEFHGGPFFD
		{
			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0xA672F0", Offset = "0xA662F0", VA = "0x180A672F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
		public void CPOBHIECLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public ProgressionEventPurchasableXpBoostDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public enum DIMLKCOCNNK
{
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	Premium
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public enum GEAEHEAKOFP
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
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[KGCDFDOGPOJ]
public class ACIKKHACKIE : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170001FE")]
	public string LAFAEPNEHJI
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	public string? ELFMIMIFBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public ACIKKHACKIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface MPKGNLKJDEG
{
	[Cpp2IlInjected.Token(Token = "0x17000200")]
	bool MIFAEMCECOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000201")]
	string? JMHFDPGIPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000202")]
	string? PMLDIPCOOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public interface PMFNJIOOINF<T> : MPKGNLKJDEG
{
	[Cpp2IlInjected.Token(Token = "0x17000203")]
	T BDJLGAHJNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public static class FBKLMIOHLJL
{
	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x3C2DDC0", Offset = "0x3C2CDC0", VA = "0x183C2DDC0")]
	public static PMFNJIOOINF<T> DBHNDLPLFNO<T, U>(this PMFNJIOOINF<U> BGOCMPMGKKI, Func<U, T> EKNMGFDFMEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct FABLLDLBLBB<T> : PMFNJIOOINF<T>, MPKGNLKJDEG
{
	[Cpp2IlInjected.Token(Token = "0x17000204")]
	public bool MIFAEMCECOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x1045C40", Offset = "0x1044C40", VA = "0x181045C40", Slot = "5")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x2C8B000", Offset = "0x2C8A000", VA = "0x182C8B000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000205")]
	public string? JMHFDPGIPHM
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB70", Offset = "0xAE9B70", VA = "0x180AEAB70", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xEB1EC0", Offset = "0xEB0EC0", VA = "0x180EB1EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000206")]
	public string? PMLDIPCOOKD
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0", Slot = "7")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000207")]
	public T BDJLGAHJNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x4D749A0", Offset = "0x4D739A0", VA = "0x184D749A0")]
	public static FABLLDLBLBB<T> MEIMBBHKNPG(T IOALKPFEKEK)
	{
		return default(FABLLDLBLBB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x4D748E0", Offset = "0x4D738E0", VA = "0x184D748E0")]
	public static FABLLDLBLBB<T> JFNGGMPANGM(string MGECNFLHDHF, string ECEMBIHOMAM = "")
	{
		return default(FABLLDLBLBB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[KGCDFDOGPOJ]
public class JFNAKFCGDAO : MPKGNLKJDEG, PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000208")]
	public bool MIFAEMCECOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0xB3C200", Offset = "0xB3B200", VA = "0x180B3C200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0xB3C210", Offset = "0xB3B210", VA = "0x180B3C210")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000209")]
	public string? JMHFDPGIPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020A")]
	[DataMember(Name = "error_id")]
	public string? PMLDIPCOOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "8")]
	public virtual void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x7626430", Offset = "0x7625430", VA = "0x187626430")]
	public static JFNAKFCGDAO MEIMBBHKNPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x76263A0", Offset = "0x76253A0", VA = "0x1876263A0")]
	public static JFNAKFCGDAO JFNGGMPANGM(string MGECNFLHDHF, string ECEMBIHOMAM = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public JFNAKFCGDAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[AOLJPBCNDMG]
public abstract class FFOENOGPGNH<T> : JFNAKFCGDAO, PMFNJIOOINF<T>, MPKGNLKJDEG
{
	[Cpp2IlInjected.Token(Token = "0x1700020B")]
	public T BDJLGAHJNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0xC333C0", Offset = "0xC323C0", VA = "0x180C333C0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0xBB3410", Offset = "0xBB2410", VA = "0x180BB3410")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
	protected FFOENOGPGNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[AOLJPBCNDMG]
public class OOJPCAPFGCP<T> : FFOENOGPGNH<T>
{
	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x595BD90", Offset = "0x595AD90", VA = "0x18595BD90")]
	private static void LLGONBKHPCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x48B4C40", Offset = "0x48B3C40", VA = "0x1848B4C40")]
	public OOJPCAPFGCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[AOLJPBCNDMG]
public class KGOJLHJNIOD<T> : FFOENOGPGNH<T>, GBHAIMFMHCK, PDDMBELEHHJ where T : PDDMBELEHHJ, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct HGLGLCFGOPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public KGOJLHJNIOD<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x4F40530", Offset = "0x4F3F530", VA = "0x184F40530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x4F407A0", Offset = "0x4F3F7A0", VA = "0x184F407A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x53B42D0", Offset = "0x53B32D0", VA = "0x1853B42D0", Slot = "8")]
	public override void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x53B4200", Offset = "0x53B3200", VA = "0x1853B4200", Slot = "10")]
	[AsyncStateMachine(typeof(KGOJLHJNIOD<>.HGLGLCFGOPF))]
	public Task AHKNCNAGGLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x53B44A0", Offset = "0x53B34A0", VA = "0x1853B44A0")]
	public static KGOJLHJNIOD<T> MEIMBBHKNPG(T IOALKPFEKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x53B4360", Offset = "0x53B3360", VA = "0x1853B4360")]
	public new static KGOJLHJNIOD<T> JFNGGMPANGM(string MGECNFLHDHF, string ECEMBIHOMAM = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x4498C00", Offset = "0x4497C00", VA = "0x184498C00")]
	public KGOJLHJNIOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[AOLJPBCNDMG]
public class LBIMJIJCIOH<T> : FFOENOGPGNH<List<T>>
{
	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x48B4C40", Offset = "0x48B3C40", VA = "0x1848B4C40")]
	public LBIMJIJCIOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[AOLJPBCNDMG]
public class GJAFHDAFBNE<T> : FFOENOGPGNH<List<T>>, GBHAIMFMHCK, PDDMBELEHHJ where T : PDDMBELEHHJ, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct NCCMFJFKILB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public GJAFHDAFBNE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x5777C80", Offset = "0x5776C80", VA = "0x185777C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x5777E80", Offset = "0x5776E80", VA = "0x185777E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x4EBD800", Offset = "0x4EBC800", VA = "0x184EBD800")]
	public static GJAFHDAFBNE<T> MEIMBBHKNPG(List<T> IOALKPFEKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x4EBD6C0", Offset = "0x4EBC6C0", VA = "0x184EBD6C0")]
	public new static GJAFHDAFBNE<T> JFNGGMPANGM(string MGECNFLHDHF, string ECEMBIHOMAM = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x4EBD470", Offset = "0x4EBC470", VA = "0x184EBD470", Slot = "8")]
	public override void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x4EBD3A0", Offset = "0x4EBC3A0", VA = "0x184EBD3A0", Slot = "10")]
	[AsyncStateMachine(typeof(GJAFHDAFBNE<>.NCCMFJFKILB))]
	public Task AHKNCNAGGLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x4EBD920", Offset = "0x4EBC920", VA = "0x184EBD920")]
	public GJAFHDAFBNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public enum NNPMGHNBFMD
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
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public static class FDOJOBCDMPO
{
	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x7623F90", Offset = "0x7622F90", VA = "0x187623F90")]
	public static bool CNGNHEEDDPD(this NNPMGHNBFMD JMELKBNBGDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x7623F90", Offset = "0x7622F90", VA = "0x187623F90")]
	public static bool CNAPMBHHAHG(this NNPMGHNBFMD JMELKBNBGDN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public enum PJBEJGJLLLM
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
	ProgressionEvent = 400,
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	RoomieCredits = 500
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public enum GNCGGEBPLKF
{
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	NonPurchasedNotUsableInP2P = -2,
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	NonPurchasedDefault = -1,
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	SteamPurchased = 0,
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	OculusPurchased = 1,
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	PlayStationPurchased = 2,
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	MicrosoftPurchased = 3,
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	IOSPurchased = 5,
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	GooglePlayPurchased = 6,
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	PicoPurchased = 8,
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	RecNetPurchased = 4,
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	SwitchPurchased = 9,
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	[Obsolete("Subscription benefits for PS4 players were awarded with this balance type. It is not transferrable to other platforms. Usable in P2P economy. We are using PlayStationPurchased instead now. -- bilal - 11/11/2020")]
	PlayStationNonPurchasedP2P = 100,
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	[Obsolete("Subscription benefits for NON PS4 players were awarded with this balance type. We are using <PlatformType>Purchased instead now. -- bilal - 11/11/2020")]
	NonPlayStationNonPurchasedP2P = 101,
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	NonPurchasedEarnedByP2P = 1000,
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	NonPurchasedEarnedByP2Pv2 = 1001,
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	RoomieEnergyPack = 1101
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public enum EHFKNLKDDIE
{
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	First_Activity = 1,
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	Game_Drop = 2,
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	All_Daily_Challenges_Complete = 3,
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	All_Weekly_Challenge_Complete = 4,
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	Daily_Challenge_Complete = 5,
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	Weekly_Challenge_Complete = 6,
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	Unassigned_Equipment = 10,
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	Unassigned_Avatar = 11,
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	Unassigned_Consumable = 12,
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	Reacquisition = 20,
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	Membership = 21,
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	NUX_TokensAndDressUp = 30,
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	NUX_Experiment1 = 31,
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	NUX_Experiment2 = 32,
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	NUX_Experiment3 = 33,
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	NUX_Experiment4 = 34,
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	NUX_Experiment5 = 35,
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	GameRewards = 50,
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	GameRewards_Tokens = 51,
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	GameRewards_Tokens_Experiment_Override = 52,
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	GameRewards_A = 53,
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	GameRewards_B = 54,
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	LevelUp = 100,
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	Purchased_Gift_A = 500,
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	Purchased_Gift_B = 501,
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	Purchased_Gift_C = 502,
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	Purchased_Gift_D = 503,
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	Holiday = 1000,
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	Contest = 1001,
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	Promotion = 1002,
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	LimitedTime = 1003,
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	LimitedTimeEvent = 1004,
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	Deprecated = 1100,
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	RecRoyale = 1200,
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	Friendotron_Gift = 1300,
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	DEPRECATED_Paintball_ClearCut = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	DEPRECATED_Paintball_Homestead = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	DEPRECATED_Paintball_Quarry = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	DEPRECATED_Paintball_River = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	DEPRECATED_Paintball_Dam = 2004,
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	DEPRECATED_Paintball_DriveIn = 2005,
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	Paintball_ClearCut = 2010,
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	Paintball_Homestead = 2011,
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	Paintball_Quarry = 2012,
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	Paintball_River = 2013,
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	Paintball_Dam = 2014,
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	Paintball_DriveIn = 2015,
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	DEPRECATED_Discgolf_Propulsion = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	DEPRECATED_Discgolf_Lake = 3001,
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	Discgolf_Propulsion = 3010,
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	Discgolf_Lake = 3011,
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	Discgolf_Mode_CoopCatch = 3500,
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	Quest_Goblin_A = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	Quest_Goblin_B = 4001,
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	Quest_Goblin_C = 4002,
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	Quest_Goblin_S = 4003,
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	Quest_Goblin_Consumable = 4004,
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	Quest_Cauldron_A = 4010,
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	Quest_Cauldron_B = 4011,
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	Quest_Cauldron_C = 4012,
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	Quest_Cauldron_S = 4013,
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	Quest_Cauldron_Consumable = 4014,
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	Quest_Pirate1_A = 4100,
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	Quest_Pirate1_B = 4101,
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	Quest_Pirate1_C = 4102,
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	Quest_Pirate1_S = 4103,
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	Quest_Pirate1_X = 4104,
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	Quest_Pirate1_Consumable = 4105,
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	Quest_Dracula1_A = 4200,
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	Quest_Dracula1_B = 4201,
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	Quest_Dracula1_C = 4202,
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	Quest_Dracula1_S = 4203,
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	Quest_Dracula1_X = 4204,
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	Quest_Dracula1_Consumable = 4205,
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	Quest_Dracula1_SS = 4206,
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	Quest_SciFi_A = 4500,
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	Quest_SciFi_B = 4501,
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	Quest_SciFi_C = 4502,
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	Quest_SciFi_S = 4503,
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	Quest_Scifi_Consumable = 4504,
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	DEPRECATED_Charades = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	Charades = 5001,
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	DEPRECATED_Soccer = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	Soccer = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	DEPRECATED_Paddleball = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	Paddleball = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	DEPRECATED_Dodgeball = 8000,
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	Dodgeball = 8001,
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	DEPRECATED_Lasertag = 9000,
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	Lasertag = 9001,
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	DEPRECATED_Bowling = 10000,
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	Bowling = 10001,
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	StuntRunner_TheMainEvent_A = 11000,
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	StuntRunner_TheMainEvent_B = 11001,
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	StuntRunner_TheMainEvent_C = 11002,
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	StuntRunner_TheMainEvent_D = 11003,
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	StuntRunner_TheMainEvent_S = 11004,
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	StuntRunner_TheMainEvent_X = 11005,
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	StuntRunner_TheMainEvent_Consumable = 11006,
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	StuntRunner_TheMainEvent_SS = 11007,
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	RecRally = 12000,
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	Showdown_A = 12100,
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	Showdown_B = 12101,
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	Showdown_C = 12102,
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	MyLittleMonsters = 12200,
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	RunTheBlock = 12300,
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	RROStorefront_ToBeNamed_2 = 12400,
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	ProgressionEvent = 13000,
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	Store_LaserTag = 100000,
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	Store_RecCenter = 100010,
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	Consumable = 110000,
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	Token = 110100,
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	Punchcard_Challenge_Complete = 110200,
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	All_Punchcard_Challenges_Complete = 110201,
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	New_Player_Checklist_Item_Complete = 110300,
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	Commerce_Purchase = 200000,
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	Gift_Card_Redemption = 210000
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public enum LCEGHIAIKNO
{
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	Common = 0,
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	Uncommon = 10,
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	Rare = 20,
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	Epic = 30,
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	Legendary = 50
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public enum IIFPJCBKPKN
{
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	OK,
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	TooManyRequests,
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	NotEnoughCredit,
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	AlreadyOwned,
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	NoItemAvailable,
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	CouponNotApplicable,
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	RequestedPriceDoesNotMatch,
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	RequestedAmountNotAllowed,
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	PlayerNotEligible,
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	RequestCannotBeRefunded,
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	PlayerNotApproved
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[KGCDFDOGPOJ]
	public class BalanceResponseDTO : PDDMBELEHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		public long Balance
		{
			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		public PJBEJGJLLLM CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
			[CompilerGenerated]
			get
			{
				return default(PJBEJGJLLLM);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0xA6A6F0", Offset = "0xA696F0", VA = "0x180A6A6F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		[DataMember(Name = "Platform")]
		public GNCGGEBPLKF BalanceType
		{
			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0xA88A10", Offset = "0xA87A10", VA = "0x180A88A10")]
			[CompilerGenerated]
			get
			{
				return default(GNCGGEBPLKF);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0xE8AAE0", Offset = "0xE89AE0", VA = "0x180E8AAE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		public virtual void CPOBHIECLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public BalanceResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[KGCDFDOGPOJ]
	public class FilteredTextDTO : PDDMBELEHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		public string FNEADOLJELE
		{
			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		public int AKMFBJIOFEH
		{
			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0xA6A6F0", Offset = "0xA696F0", VA = "0x180A6A6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
		public void CPOBHIECLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public FilteredTextDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[KGCDFDOGPOJ]
public class NBNHNNBFIJF : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000211")]
	public string BAAPBMENBCG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000212")]
	public string MKMIGIBBMEG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public NBNHNNBFIJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[KGCDFDOGPOJ]
public class ICKDEJCADDN : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000213")]
	public List<NBNHNNBFIJF> KMLKGKIAABH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public ICKDEJCADDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[KGCDFDOGPOJ]
public class FNMOLFABKDI : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000214")]
	public string DFOOEEBKLCN
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0xA6BBE0", Offset = "0xA6ABE0", VA = "0x180A6BBE0")]
	public FNMOLFABKDI(string FONNCMLEGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[KGCDFDOGPOJ]
public class GCAPFKDGFOO : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000215")]
	public List<NBNHNNBFIJF> KMLKGKIAABH
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public GCAPFKDGFOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[KGCDFDOGPOJ]
public class HBAMDIPAMHK : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000216")]
	public List<FNMOLFABKDI> APOGFDPCOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000217")]
	public string MPKFDGCMCOM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000218")]
	public bool PDLBLBNHOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xA68390", Offset = "0xA67390", VA = "0x180A68390")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xA68440", Offset = "0xA67440", VA = "0x180A68440")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000219")]
	public int DKKCBLEDOBM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xC333D0", Offset = "0xC323D0", VA = "0x180C333D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x1034ED0", Offset = "0x1033ED0", VA = "0x181034ED0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public HBAMDIPAMHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x7624AB0", Offset = "0x7623AB0", VA = "0x187624AB0")]
	public HBAMDIPAMHK(string AJDJOPIJBJN, List<FNMOLFABKDI> FHCCMLOFJCC, bool KCHNPAEGKGA, int NBGNFJAHIKJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[KGCDFDOGPOJ]
public class BPEBODLGNNF : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700021A")]
	public List<GCAPFKDGFOO> HDIPMAFGODF
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021B")]
	public bool PDLBLBNHOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xAB8160", Offset = "0xAB7160", VA = "0x180AB8160")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xA69F60", Offset = "0xA68F60", VA = "0x180A69F60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public BPEBODLGNNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[KGCDFDOGPOJ]
public class AMMNGPJBAPM : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public enum NDBCMMLAFJG
	{
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		EnqueuedPending,
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		DequeuedStarting,
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		CompleteSuccess
	}

	[Cpp2IlInjected.Token(Token = "0x4000379")]
	public const string AGOLDFHDFBH = "StringAutoLocalizationJob";

	[Cpp2IlInjected.Token(Token = "0x1700021C")]
	public string MPKFDGCMCOM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021D")]
	public NDBCMMLAFJG PPDHEPJEKMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
		[CompilerGenerated]
		get
		{
			return default(NDBCMMLAFJG);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0xA6A6F0", Offset = "0xA696F0", VA = "0x180A6A6F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x7620820", Offset = "0x761F820", VA = "0x187620820")]
	public AMMNGPJBAPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x7620830", Offset = "0x761F830", VA = "0x187620830")]
	public AMMNGPJBAPM(string AJDJOPIJBJN, NDBCMMLAFJG CCNILHLCOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[KGCDFDOGPOJ]
public class EPPKMDPFHPH : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700021E")]
	public bool IOCJLAECBKL
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xB3C200", Offset = "0xB3B200", VA = "0x180B3C200")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xB3C210", Offset = "0xB3B210", VA = "0x180B3C210")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public EPPKMDPFHPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public static class HECOHKEBNCH
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public enum KNJAGINBKLC
	{
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		CoC_Discriminatory,
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		CoC_Sexual,
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		CoC_Trolling,
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		Misleading,
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		Other,
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		InappropriateClothing
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[KGCDFDOGPOJ]
public class EKIIHMOEAPE : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700021F")]
	public long ANKPNEKDDOB
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000220")]
	public Guid DGABIKABEJO
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0xD36D60", Offset = "0xD35D60", VA = "0x180D36D60")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0xF0BE40", Offset = "0xF0AE40", VA = "0x180F0BE40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000221")]
	public long FGFNGHCNJFK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0xA683D0", Offset = "0xA673D0", VA = "0x180A683D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000222")]
	public BKIMDBJFFBP JBPMGNBOOKM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public EKIIHMOEAPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x7623870", Offset = "0x7622870", VA = "0x187623870")]
	public EKIIHMOEAPE(long DJJNJEHBMJK, Guid FFMKCANGCKP, long KGCCFJCBKGO, BKIMDBJFFBP CIIDDIALFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x7623850", Offset = "0x7622850", VA = "0x187623850", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[KGCDFDOGPOJ]
public class CNEGDLOLNAA : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000223")]
	public CFKLLHHINAN IJBEHPGCOHL
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(CFKLLHHINAN);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000224")]
	public OCOMMAHLAAD NADOGFDPKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public CNEGDLOLNAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x1005CA0", Offset = "0x1004CA0", VA = "0x181005CA0")]
	public CNEGDLOLNAA(CFKLLHHINAN BGOCMPMGKKI, OCOMMAHLAAD HIJLNCPNMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[KGCDFDOGPOJ]
public class BKIMDBJFFBP : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000225")]
	public Guid? IFPAEKOJENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x31138A0", Offset = "0x31128A0", VA = "0x1831138A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x7620B50", Offset = "0x761FB50", VA = "0x187620B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000226")]
	public Guid IEICKLCBOLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xE55660", Offset = "0xE54660", VA = "0x180E55660")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x1057940", Offset = "0x1056940", VA = "0x181057940")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public BKIMDBJFFBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x7620B60", Offset = "0x761FB60", VA = "0x187620B60")]
	public BKIMDBJFFBP(Guid? LKMAGCNHJFD, Guid GFIGKBDIHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[KGCDFDOGPOJ]
public class OCOMMAHLAAD : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000227")]
	public long ANKPNEKDDOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000228")]
	public Guid DGABIKABEJO
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0xD36D60", Offset = "0xD35D60", VA = "0x180D36D60")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0xF0BE40", Offset = "0xF0AE40", VA = "0x180F0BE40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000229")]
	public long JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xA683D0", Offset = "0xA673D0", VA = "0x180A683D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022A")]
	public Guid LGHPFDKJIBP
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xF0CDA0", Offset = "0xF0BDA0", VA = "0x180F0CDA0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xF0D8F0", Offset = "0xF0C8F0", VA = "0x180F0D8F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022B")]
	public DateTime POBHENPHPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xF68050", Offset = "0xF67050", VA = "0x180F68050")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022C")]
	public DateTime GIPIHLKJPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x1353980", Offset = "0x1352980", VA = "0x181353980")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public OCOMMAHLAAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[KGCDFDOGPOJ]
public class NFDBJPPFECG : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700022D")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022E")]
	public string FMJEMOMMPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022F")]
	public string CHIILACPAMM
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000230")]
	public List<long> KKLPPGJPIHG
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000231")]
	public List<NHIBFMLBENF> BBKNGLGMLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000232")]
	public string LKAKKFHEPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000233")]
	public byte? CBGGCHEEBON
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x76293D0", Offset = "0x76283D0", VA = "0x1876293D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x7629400", Offset = "0x7628400", VA = "0x187629400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000234")]
	public int? LMMFILFPMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x76247B0", Offset = "0x76237B0", VA = "0x1876247B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x7624510", Offset = "0x7623510", VA = "0x187624510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000235")]
	public Guid? PFDBJPLKAKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x76293E0", Offset = "0x76283E0", VA = "0x1876293E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x7629410", Offset = "0x7628410", VA = "0x187629410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000236")]
	public bool FIOAADDNGJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0xA683F0", Offset = "0xA673F0", VA = "0x180A683F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0xA683C0", Offset = "0xA673C0", VA = "0x180A683C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public NFDBJPPFECG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[KGCDFDOGPOJ]
public class ICHKNBGHKHE : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000237")]
	public Guid PFDBJPLKAKI
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE60", Offset = "0xE5DE60", VA = "0x180E5EE60")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE70", Offset = "0xE5DE70", VA = "0x180E5EE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000238")]
	public long ANKPNEKDDOB
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xDCBC10", Offset = "0xDCAC10", VA = "0x180DCBC10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000239")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023A")]
	public string FMJEMOMMPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023B")]
	public string CHIILACPAMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023C")]
	public DateTime POBHENPHPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0xF68050", Offset = "0xF67050", VA = "0x180F68050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023D")]
	public DateTime GIPIHLKJPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x1353980", Offset = "0x1352980", VA = "0x181353980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023E")]
	public string LKAKKFHEPEN
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0xA631E0", Offset = "0xA621E0", VA = "0x180A631E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0xA631D0", Offset = "0xA621D0", VA = "0x180A631D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023F")]
	public List<long> KKLPPGJPIHG
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0xA63170", Offset = "0xA62170", VA = "0x180A63170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0xA631B0", Offset = "0xA621B0", VA = "0x180A631B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000240")]
	public List<JDFGKPEHOFB> BBKNGLGMLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0xA63190", Offset = "0xA62190", VA = "0x180A63190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0xA631F0", Offset = "0xA621F0", VA = "0x180A631F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000241")]
	public byte CBGGCHEEBON
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0xAD3250", Offset = "0xAD2250", VA = "0x180AD3250")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0xAD32D0", Offset = "0xAD22D0", VA = "0x180AD32D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000242")]
	public int LMMFILFPMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0xA97270", Offset = "0xA96270", VA = "0x180A97270")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x153D6F0", Offset = "0x153C6F0", VA = "0x18153D6F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public ICHKNBGHKHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[KGCDFDOGPOJ]
public class DIPBCIENHBI : ICHKNBGHKHE
{
	[Cpp2IlInjected.Token(Token = "0x17000243")]
	public Guid OPEOEPOBABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x1BA3D30", Offset = "0x1BA2D30", VA = "0x181BA3D30")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x4EF3FA0", Offset = "0x4EF2FA0", VA = "0x184EF3FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public DIPBCIENHBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public enum CFKLLHHINAN
{
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	RoomInventoryItemDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	PlayerDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	RequestQuantityTooLarge,
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	PlayerHasReachedTheMinimumOwnedAmount,
	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	ConcurrencyCodeMismatch,
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	InvalidConcurrencyCode
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public interface POALNOBEJDK
{
	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FFOENOGPGNH<ICHKNBGHKHE>> PNMKEAOEGLH(Guid? FFGLKCFBAJA, long DJJNJEHBMJK, string HJLBILHBIIC, string GAPCMICLLJD, string IMHEEBEEIJH, string DEFFKPPIGEM, byte CBGBGGEBCJG, int AHIICABHHJO, [Optional] List<long> JOOOHKEHDKL, [Optional] List<JDFGKPEHOFB> KNKOMEIPJCO, bool BNOMIEFKLPG = false, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<FFOENOGPGNH<ICHKNBGHKHE>> IPECFDAFPPG(Guid FFMKCANGCKP, long DJJNJEHBMJK, [Optional] string HJLBILHBIIC, [Optional] string GAPCMICLLJD, [Optional] string IMHEEBEEIJH, [Optional] List<long> JOOOHKEHDKL, [Optional] Dictionary<string, string> KNKOMEIPJCO, [Optional] string DEFFKPPIGEM, [Optional] byte? CBGBGGEBCJG, [Optional] int? AHIICABHHJO, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<JFNAKFCGDAO> GJMMPNILPNN(Guid FFMKCANGCKP, long DJJNJEHBMJK, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<ICHKNBGHKHE>> AINAOMALEOH(long DJJNJEHBMJK, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<OCOMMAHLAAD>> JNMKOGCOKEF(long DJJNJEHBMJK, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<List<CNEGDLOLNAA>> DMEPPDMLCJL(long DJJNJEHBMJK, List<EKIIHMOEAPE> EJNMOKIGKGF, [Optional] CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[KGCDFDOGPOJ]
public class NHIBFMLBENF : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000244")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000245")]
	public string LKAKKFHEPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public NHIBFMLBENF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[KGCDFDOGPOJ]
public class JDFGKPEHOFB : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000246")]
	public long BPAPEDPJNEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000247")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000248")]
	public string LKAKKFHEPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public JDFGKPEHOFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[KGCDFDOGPOJ]
public class ABJCPBLFAEO : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000249")]
	public long BPAPEDPJNEM
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024A")]
	public string LKAKKFHEPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x4E0C260", Offset = "0x4E0B260", VA = "0x184E0C260")]
	public ABJCPBLFAEO(long PPBCCKPGGJD, string KAEILAKIAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public interface LHDMMGAGJKF
{
	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FFOENOGPGNH<List<JDFGKPEHOFB>>> KFKCBENKBOD(long DJJNJEHBMJK, List<ABJCPBLFAEO> EJNMOKIGKGF, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<JFNAKFCGDAO> LDDOOGECDJB(long PPBCCKPGGJD, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<JDFGKPEHOFB>> CHNJANBNMDC(long DJJNJEHBMJK, [Optional] CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[KGCDFDOGPOJ]
public class GFAPCJNKLGC : IIDLGCBOJGC, IEquatable<GFAPCJNKLGC>
{
	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x7624330", Offset = "0x7623330", VA = "0x187624330", Slot = "7")]
	public bool Equals(GFAPCJNKLGC EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x76242C0", Offset = "0x76232C0", VA = "0x1876242C0", Slot = "6")]
	public override IIDLGCBOJGC AABAGJPEDHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public GFAPCJNKLGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public static class BDIPMCJDAIH
{
	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x7620980", Offset = "0x761F980", VA = "0x187620980")]
	public static GFAPCJNKLGC HKANNBMMEGI(this ICAHHIJFAHD ADPMEPGEIDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x76209F0", Offset = "0x761F9F0", VA = "0x1876209F0")]
	public static GFAPCJNKLGC MNPICENAOBH(string CDOICGFAMDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[KGCDFDOGPOJ]
public class ICAHHIJFAHD : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public const int DONAIGDOFJE = 3;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public const int PGCAHPHFKPH = 40;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public const int LJLCPBCKOLE = 180;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public const int JLHNFBLLPDF = 1000;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public const int IHADMIPCGAA = 99999;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public const int NECLPOJIDPD = 8;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public const int GAKIDEJCJBD = 1;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public const int IKAFDEIDHKD = 1000000000;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public const int JEMIBICFCCK = 9999;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	[IgnoreDataMember]
	private IReadOnlyDictionary<Guid, int>? OAIIBMPMOCI;

	[Cpp2IlInjected.Token(Token = "0x1700024B")]
	public Guid PFDBJPLKAKI
	{
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE60", Offset = "0xE5DE60", VA = "0x180E5EE60")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE70", Offset = "0xE5DE70", VA = "0x180E5EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024C")]
	public long ANKPNEKDDOB
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0xDCBC10", Offset = "0xDCAC10", VA = "0x180DCBC10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024D")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024E")]
	public string? FMJEMOMMPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024F")]
	public string? CHIILACPAMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000250")]
	public int CCNIGPGEOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0xD16000", Offset = "0xD15000", VA = "0x180D16000")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xF6BDC0", Offset = "0xF6ADC0", VA = "0x180F6BDC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000251")]
	public Guid? BIBJNMNNMOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x7625260", Offset = "0x7624260", VA = "0x187625260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x7625160", Offset = "0x7624160", VA = "0x187625160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000252")]
	public int IPPLPEJMEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xAC2B00", Offset = "0xAC1B00", VA = "0x180AC2B00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xEA3620", Offset = "0xEA2620", VA = "0x180EA3620")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000253")]
	public int? EDMCCONOLDH
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x703AE30", Offset = "0x7039E30", VA = "0x18703AE30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x703AE50", Offset = "0x7039E50", VA = "0x18703AE50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000254")]
	public int? IDGOOEJHEBC
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x76252E0", Offset = "0x76242E0", VA = "0x1876252E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x76252D0", Offset = "0x76242D0", VA = "0x1876252D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000255")]
	public IReadOnlyList<LGKODPIDAFE> HAKPADLMAAF
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0xA631A0", Offset = "0xA621A0", VA = "0x180A631A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0xA63180", Offset = "0xA62180", VA = "0x180A63180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000256")]
	public DateTime POBHENPHPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0xA6EF90", Offset = "0xA6DF90", VA = "0x180A6EF90")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0xF86950", Offset = "0xF85950", VA = "0x180F86950")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000257")]
	public DateTime GIPIHLKJPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0xA6EEA0", Offset = "0xA6DEA0", VA = "0x180A6EEA0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0xF86C40", Offset = "0xF85C40", VA = "0x180F86C40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000258")]
	[IgnoreDataMember]
	public ONKHINELMKK EGAKFCGILFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x7625170", Offset = "0x7624170", VA = "0x187625170")]
		get
		{
			return default(ONKHINELMKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000259")]
	[IgnoreDataMember]
	public IReadOnlyDictionary<Guid, int> GOKEFGAKIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x7625280", Offset = "0x7624280", VA = "0x187625280")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0xA6EE80", Offset = "0xA6DE80", VA = "0x180A6EE80")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x7625250", Offset = "0x7624250", VA = "0x187625250", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public ICAHHIJFAHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x76255C0", Offset = "0x76245C0", VA = "0x1876255C0")]
	public ICAHHIJFAHD(Guid FFGLKCFBAJA, long DJJNJEHBMJK, string HJLBILHBIIC, string GAPCMICLLJD, string IMHEEBEEIJH, int FJMCJCMNJIL, int? ICBFFPFEEIG, int? LHDABDFLAJL, List<LGKODPIDAFE> JCLDDDJIHHB, [Optional] DateTime IJEADHNFPOH, [Optional] DateTime MNDHCBMIMJN, [Optional] Guid? KBILHJIABHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x76251E0", Offset = "0x76241E0", VA = "0x1876251E0")]
	private ONKHINELMKK CLBFGFJNKDB()
	{
		return default(ONKHINELMKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x76252F0", Offset = "0x76242F0", VA = "0x1876252F0")]
	private Dictionary<Guid, int> LJFAJDPFLDA(IReadOnlyList<LGKODPIDAFE> JCLDDDJIHHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[KGCDFDOGPOJ]
public class OOIGKJLJPMO : PDDMBELEHHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public Guid PFDBJPLKAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public long ANKPNEKDDOB;

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public OOIGKJLJPMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[KGCDFDOGPOJ]
public class KGEIMAHGGLN : ICAHHIJFAHD
{
	[Cpp2IlInjected.Token(Token = "0x1700025A")]
	public Guid JDCBOEAIOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0xF86340", Offset = "0xF85340", VA = "0x180F86340")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xF86370", Offset = "0xF85370", VA = "0x180F86370")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025B")]
	public Guid? IHNIIKEAEMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x7627C60", Offset = "0x7626C60", VA = "0x187627C60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x7627C40", Offset = "0x7626C40", VA = "0x187627C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public KGEIMAHGGLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[KGCDFDOGPOJ]
public class NLHGAKMGADE : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700025C")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025D")]
	public string? FMJEMOMMPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025E")]
	public string? CHIILACPAMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025F")]
	public int CCNIGPGEOLH
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0xA655B0", Offset = "0xA645B0", VA = "0x180A655B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0xA655C0", Offset = "0xA645C0", VA = "0x180A655C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000260")]
	public int? EDMCCONOLDH
	{
		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x13447B0", Offset = "0x13437B0", VA = "0x1813447B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x13447E0", Offset = "0x13437E0", VA = "0x1813447E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000261")]
	public int? IDGOOEJHEBC
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0xDCBBE0", Offset = "0xDCABE0", VA = "0x180DCBBE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0xDCBC20", Offset = "0xDCAC20", VA = "0x180DCBC20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000262")]
	public List<LGKODPIDAFE> HAKPADLMAAF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0xA674F0", Offset = "0xA664F0", VA = "0x180A674F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000263")]
	public Guid? IHNIIKEAEMH
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x7626C30", Offset = "0x7625C30", VA = "0x187626C30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x7626C20", Offset = "0x7625C20", VA = "0x187626C20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000264")]
	public Guid? PFDBJPLKAKI
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x7629720", Offset = "0x7628720", VA = "0x187629720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x7629740", Offset = "0x7628740", VA = "0x187629740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000265")]
	public bool FIOAADDNGJC
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0xE60250", Offset = "0xE5F250", VA = "0x180E60250")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0xFBDCA0", Offset = "0xFBCCA0", VA = "0x180FBDCA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x7629710", Offset = "0x7628710", VA = "0x187629710", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public NLHGAKMGADE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[KGCDFDOGPOJ]
public class LGKODPIDAFE : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000266")]
	public HNMNCDHLPID FIFPILEIAAA
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xB3C200", Offset = "0xB3B200", VA = "0x180B3C200")]
		[CompilerGenerated]
		get
		{
			return default(HNMNCDHLPID);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xB3C210", Offset = "0xB3B210", VA = "0x180B3C210")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000267")]
	public Guid IMPJJLDPLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x1B1F290", Offset = "0x1B1E290", VA = "0x181B1F290")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x5C9B380", Offset = "0x5C9A380", VA = "0x185C9B380")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000268")]
	public int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xC333D0", Offset = "0xC323D0", VA = "0x180C333D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x1034ED0", Offset = "0x1033ED0", VA = "0x181034ED0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public LGKODPIDAFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x7628410", Offset = "0x7627410", VA = "0x187628410")]
	public LGKODPIDAFE(Guid MOMECPCCAOA, HNMNCDHLPID BJLNCBFOGNL, int MFFPIAPMHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[KGCDFDOGPOJ]
public class OLMCOEMFCBJ : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000269")]
	public Guid BPPLAJOPCCC
	{
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE60", Offset = "0xE5DE60", VA = "0x180E5EE60")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE70", Offset = "0xE5DE70", VA = "0x180E5EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026A")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026B")]
	public int HIOCPKLFBIC
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xA655B0", Offset = "0xA645B0", VA = "0x180A655B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0xA655C0", Offset = "0xA645C0", VA = "0x180A655C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026C")]
	public DateTime JJKGMLCACMF
	{
		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0xA68450", Offset = "0xA67450", VA = "0x180A68450")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026D")]
	public int IPPLPEJMEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xA7E570", Offset = "0xA7D570", VA = "0x180A7E570")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0xE85250", Offset = "0xE84250", VA = "0x180E85250")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x762A260", Offset = "0x7629260", VA = "0x18762A260")]
	public OLMCOEMFCBJ(Guid DFPKNAPNGHC, string HJLBILHBIIC, int NLGDGKFKBBA, DateTime PPFHLECEDEM, int LMOHNMMFGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public OLMCOEMFCBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[KGCDFDOGPOJ]
public class OOKDOMPGLJO : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700026E")]
	public Guid BPPLAJOPCCC
	{
		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE60", Offset = "0xE5DE60", VA = "0x180E5EE60")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE70", Offset = "0xE5DE70", VA = "0x180E5EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026F")]
	public int DFBMJCLKCAL
	{
		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAAD190", VA = "0x180AAE190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public OOKDOMPGLJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x58B9BF0", Offset = "0x58B8BF0", VA = "0x1858B9BF0")]
	public OOKDOMPGLJO(Guid DFPKNAPNGHC, int BPNINLOALKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[KGCDFDOGPOJ]
public class CPCBMONOHMN : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000270")]
	public int DFBMJCLKCAL
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000271")]
	public Guid HCGEJJBGLLG
	{
		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x1B1F290", Offset = "0x1B1E290", VA = "0x181B1F290")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x5C9B380", Offset = "0x5C9A380", VA = "0x185C9B380")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000272")]
	public int CHGBPPMJLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xC333D0", Offset = "0xC323D0", VA = "0x180C333D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x1034ED0", Offset = "0x1033ED0", VA = "0x181034ED0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000273")]
	public Guid? PGMAPBIICHD
	{
		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0xF81CF0", Offset = "0xF80CF0", VA = "0x180F81CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x2445080", Offset = "0x2444080", VA = "0x182445080")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000274")]
	public int FPBJHNAAINM
	{
		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xA7E580", Offset = "0xA7D580", VA = "0x180A7E580")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x16B9510", Offset = "0x16B8510", VA = "0x1816B9510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000275")]
	public Dictionary<Guid, Guid?> ICKDMNCJJAC
	{
		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xA674F0", Offset = "0xA664F0", VA = "0x180A674F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public CPCBMONOHMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x7621810", Offset = "0x7620810", VA = "0x187621810")]
	public CPCBMONOHMN(int BPNINLOALKH, Guid BNPOMCDAPEB, int HNGMBPDJNDH, Guid? AHMLLFOLNKN, int KFGCNPFOBHK, Dictionary<Guid, Guid?> PBEJLCHMLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[KGCDFDOGPOJ]
public class APJINCEIKDL : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000276")]
	public LBBAIFDHLDD GGGPPPHBIBO
	{
		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0xB3C200", Offset = "0xB3B200", VA = "0x180B3C200")]
		[CompilerGenerated]
		get
		{
			return default(LBBAIFDHLDD);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0xB3C210", Offset = "0xB3B210", VA = "0x180B3C210")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000277")]
	public IIFPJCBKPKN? NNELMPFDDED
	{
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x1344790", Offset = "0x1343790", VA = "0x181344790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x134F680", Offset = "0x134E680", VA = "0x18134F680")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000278")]
	public BalanceResponseDTO DEHMIJEGGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000279")]
	public List<OCOMMAHLAAD> GDDFKKIOOGN
	{
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public APJINCEIKDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x7620890", Offset = "0x761F890", VA = "0x187620890")]
	public APJINCEIKDL(LBBAIFDHLDD HFADGFHNDLP, IIFPJCBKPKN? FBDGIKLIKLG, BalanceResponseDTO PPIJOONHHEA, List<OCOMMAHLAAD> JGMGEFBIENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x7620880", Offset = "0x761F880", VA = "0x187620880", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public enum HNMNCDHLPID : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	Unset,
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	RoomInventoryItem
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public enum LBBAIFDHLDD : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	Success = 0,
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	ConcurrencyCodeMismatch = 1,
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	RoomOfferDoesNotExist = 2,
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	InvalidRequest = 3,
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	AccountIdIsInvalid = 4,
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	PlayerIsP2PBuyingRestricted = 5,
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	ExpectedOfferTotalPriceMismatch = 6,
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	ExpectedOfferVersionMismatch = 7,
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	InsufficientBalance = 8,
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	OfferUnderModeration = 9,
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	InvalidExpectedTotalPrice = 10,
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	InvalidExpectedOfferVersion = 11,
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	CannotPurchaseMoreThanPerPlayerLimit = 12,
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	InvalidExpectedPriceUnit = 13,
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	InsufficientInventoryItems = 14,
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	NoConcurrencyCodesForInventoryItem = 100,
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	UnexpectedOfferItemType = 101,
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	FeatureDisabled = 254,
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	UnknownError = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public enum ONKHINELMKK : byte
{
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	OneTimePurchase,
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	BulkPurchase
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public interface NHJEKIDELDP
{
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	static FHLIAIDPCMK<ICAHHIJFAHD> HPMEBPEBOCP;

	[Cpp2IlInjected.Token(Token = "0x4000413")]
	static FHLIAIDPCMK<ICAHHIJFAHD> OMAKIIFFAJA;

	[Cpp2IlInjected.Token(Token = "0x4000414")]
	static FHLIAIDPCMK<Guid> CEBNFCABBKI;

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FFOENOGPGNH<ICAHHIJFAHD?>?>? HFMADBBBABG(Guid? FFGLKCFBAJA, long DJJNJEHBMJK, string HJLBILHBIIC, string? GAPCMICLLJD, string? IMHEEBEEIJH, int FJMCJCMNJIL, ONKHINELMKK HMAKFCNDHON, [Optional] Dictionary<Guid, int>? MBBOGCJLBEA, [Optional] Guid? BLCOBKGOHGH, bool BNOMIEFKLPG = false, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<FFOENOGPGNH<ICAHHIJFAHD?>?>? KOFCOKONICG(Guid DFPKNAPNGHC, long DJJNJEHBMJK, string HJLBILHBIIC, string? GAPCMICLLJD, string? IMHEEBEEIJH, int FJMCJCMNJIL, ONKHINELMKK HMAKFCNDHON, [Optional] Dictionary<Guid, int>? MBBOGCJLBEA, [Optional] Guid? BLCOBKGOHGH, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<JFNAKFCGDAO> MCJHIDIGMOG(Guid DFPKNAPNGHC, long DJJNJEHBMJK, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<ICAHHIJFAHD>> KLOBDLGCNIL(long DJJNJEHBMJK, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<FFOENOGPGNH<List<OOKDOMPGLJO>>> DCHPLLDMDBD(long DJJNJEHBMJK, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<FFOENOGPGNH<List<OLMCOEMFCBJ>>> JONLHLPPIOE(long DJJNJEHBMJK, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<APJINCEIKDL> ICIJHIAJDOB(Guid DFPKNAPNGHC, long DJJNJEHBMJK, int BPNINLOALKH, int HNGMBPDJNDH, Guid? FFOKELKOFGN, int KFGCNPFOBHK, Dictionary<Guid, Guid?> JCIJGDEMJHA, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x7629420", Offset = "0x7628420", VA = "0x187629420")]
	static NHJEKIDELDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[KGCDFDOGPOJ]
public class KNGJOHJMJHO : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700027A")]
	public long ANKPNEKDDOB
	{
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027B")]
	public bool GEKLFAJKJHK
	{
		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0xAB8160", Offset = "0xAB7160", VA = "0x180AB8160")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0xA69F60", Offset = "0xA68F60", VA = "0x180A69F60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public KNGJOHJMJHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public interface KEFAGJGJDKF
{
	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KNGJOHJMJHO> IIKBFMJCHEI(long DJJNJEHBMJK, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<JFNAKFCGDAO> LPMJPPNDFCI(long DJJNJEHBMJK, bool PHFCIHOPDFL, [Optional] CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[AOLJPBCNDMG]
public class PFDEJPHNBCK<DataType> where DataType : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700027C")]
	public long AEMFHAACEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027D")]
	public PJBEJGJLLLM JHOLLGDMPCH
	{
		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
		[CompilerGenerated]
		get
		{
			return default(PJBEJGJLLLM);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0xA6A6F0", Offset = "0xA696F0", VA = "0x180A6A6F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027E")]
	public GNCGGEBPLKF FAPNAIGEJJE
	{
		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0xA88A10", Offset = "0xA87A10", VA = "0x180A88A10")]
		[CompilerGenerated]
		get
		{
			return default(GNCGGEBPLKF);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0xE8AAE0", Offset = "0xE89AE0", VA = "0x180E8AAE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027F")]
	public DataType FGNOGEEOKID
	{
		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return (DataType)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public PFDEJPHNBCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[AOLJPBCNDMG]
public class PMGKJJGBNNJ<DataType> where DataType : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000280")]
	public long AEMFHAACEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000281")]
	public PJBEJGJLLLM JHOLLGDMPCH
	{
		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
		[CompilerGenerated]
		get
		{
			return default(PJBEJGJLLLM);
		}
		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0xA6A6F0", Offset = "0xA696F0", VA = "0x180A6A6F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000282")]
	public GNCGGEBPLKF FAPNAIGEJJE
	{
		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0xA88A10", Offset = "0xA87A10", VA = "0x180A88A10")]
		[CompilerGenerated]
		get
		{
			return default(GNCGGEBPLKF);
		}
		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0xE8AAE0", Offset = "0xE89AE0", VA = "0x180E8AAE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000283")]
	public List<DataType> FGNOGEEOKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public PMGKJJGBNNJ()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[AOLJPBCNDMG]
	public class BalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : PDDMBELEHHJ, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[AOLJPBCNDMG]
		public class OGAOPBELHMN : GBHAIMFMHCK, PDDMBELEHHJ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			[CompilerGenerated]
			private struct IDBLNKCGLAH : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000422")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000423")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000424")]
				public OGAOPBELHMN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000425")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600060E")]
				[Cpp2IlInjected.Address(RVA = "0x500D150", Offset = "0x500C150", VA = "0x18500D150", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600060F")]
				[Cpp2IlInjected.Address(RVA = "0x500D400", Offset = "0x500C400", VA = "0x18500D400", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000285")]
			public IIFPJCBKPKN ANNAKBFIPNH
			{
				[Cpp2IlInjected.Token(Token = "0x6000607")]
				[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
				[CompilerGenerated]
				get
				{
					return default(IIFPJCBKPKN);
				}
				[Cpp2IlInjected.Token(Token = "0x6000608")]
				[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000286")]
			public DataTypeDTO FGNOGEEOKID
			{
				[Cpp2IlInjected.Token(Token = "0x6000609")]
				[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
				[CompilerGenerated]
				get
				{
					return (DataTypeDTO)null;
				}
				[Cpp2IlInjected.Token(Token = "0x600060A")]
				[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x58A9DD0", Offset = "0x58A8DD0", VA = "0x1858A9DD0", Slot = "5")]
			public void CPOBHIECLEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0x58A9D00", Offset = "0x58A8D00", VA = "0x1858A9D00", Slot = "4")]
			[AsyncStateMachine(typeof(BalanceUpdateResponseDTO<>.OGAOPBELHMN.IDBLNKCGLAH))]
			public Task AHKNCNAGGLP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public OGAOPBELHMN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000284")]
		public List<OGAOPBELHMN> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x5ABC880", Offset = "0x5ABB880", VA = "0x185ABC880", Slot = "5")]
		public override void CPOBHIECLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public BalanceUpdateResponseDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[AOLJPBCNDMG]
	public class PurchaseBalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : PDDMBELEHHJ, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[AOLJPBCNDMG]
		public class BMOHFFIGIFG : GBHAIMFMHCK, PDDMBELEHHJ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000EB")]
			[CompilerGenerated]
			private struct HGMBJIKMDCP : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000429")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400042A")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400042B")]
				public BMOHFFIGIFG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400042C")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600061B")]
				[Cpp2IlInjected.Address(RVA = "0x4F41740", Offset = "0x4F40740", VA = "0x184F41740", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600061C")]
				[Cpp2IlInjected.Address(RVA = "0x4F41990", Offset = "0x4F40990", VA = "0x184F41990", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000288")]
			public IIFPJCBKPKN ANNAKBFIPNH
			{
				[Cpp2IlInjected.Token(Token = "0x6000614")]
				[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
				[CompilerGenerated]
				get
				{
					return default(IIFPJCBKPKN);
				}
				[Cpp2IlInjected.Token(Token = "0x6000615")]
				[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000289")]
			public List<DataTypeDTO> FGNOGEEOKID
			{
				[Cpp2IlInjected.Token(Token = "0x6000616")]
				[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000617")]
				[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x6520270", Offset = "0x651F270", VA = "0x186520270", Slot = "5")]
			public void CPOBHIECLEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x65201A0", Offset = "0x651F1A0", VA = "0x1865201A0", Slot = "4")]
			[AsyncStateMachine(typeof(PurchaseBalanceUpdateResponseDTO<>.BMOHFFIGIFG.HGMBJIKMDCP))]
			public Task AHKNCNAGGLP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public BMOHFFIGIFG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000287")]
		public List<BMOHFFIGIFG> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x5ABC880", Offset = "0x5ABB880", VA = "0x185ABC880", Slot = "5")]
		public override void CPOBHIECLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public PurchaseBalanceUpdateResponseDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[EMIMLMIMMHE]
public class HEHPHBANEED : PurchaseBalanceUpdateResponseDTO<JKKPLHHIIHB>
{
	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x7624B20", Offset = "0x7623B20", VA = "0x187624B20")]
	public HEHPHBANEED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[EMIMLMIMMHE]
public class MCKMGICBAPA : PurchaseBalanceUpdateResponseDTO<JKKPLHHIIHB>.BMOHFFIGIFG
{
	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x7628C30", Offset = "0x7627C30", VA = "0x187628C30")]
	public MCKMGICBAPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
[KGCDFDOGPOJ]
public class EHLBPHGFCOI : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700028A")]
	public IPFLNKMNPMP HLAAHMJEKGB
	{
		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028B")]
	public long KEILPENKGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0xDAD320", Offset = "0xDAC320", VA = "0x180DAD320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028C")]
	public GiftItemDTO? AOMDOBADGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028D")]
	public long? CJAFKIHNPFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x13AC120", Offset = "0x13AB120", VA = "0x1813AC120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x14BC880", Offset = "0x14BB880", VA = "0x1814BC880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028E")]
	public int CNELMKBIJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0xA7E570", Offset = "0xA7D570", VA = "0x180A7E570")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0xE85250", Offset = "0xE84250", VA = "0x180E85250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x7623520", Offset = "0x7622520", VA = "0x187623520")]
	public EHLBPHGFCOI(IPFLNKMNPMP OJAAFLIFMEA, long NFLPOBMAEIC, GiftItemDTO? NJOIGDNEPCO, int HLGGGGJKEKE = 1, [Optional] long? NOFHFFFNLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[KGCDFDOGPOJ]
public class IHGONHNDFKA : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700028F")]
	public List<EHLBPHGFCOI> OJLKLGGDLCH
	{
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000290")]
	public PNOBDCBDLNP? GEEDMAIFNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xDAD320", Offset = "0xDAC320", VA = "0x180DAD320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000291")]
	public PJBEJGJLLLM JHOLLGDMPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return default(PJBEJGJLLLM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAAD190", VA = "0x180AAE190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000292")]
	public bool NIKKHMALPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0xE3B2D0", Offset = "0xE3A2D0", VA = "0x180E3B2D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0xE3AB00", Offset = "0xE39B00", VA = "0x180E3AB00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000293")]
	public bool GLPECGNBMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x159E900", Offset = "0x159D900", VA = "0x18159E900")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x28C4C20", Offset = "0x28C3C20", VA = "0x1828C4C20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000294")]
	public Guid? DMNEAPMAJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0xF81CF0", Offset = "0xF80CF0", VA = "0x180F81CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x2445080", Offset = "0x2444080", VA = "0x182445080")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x7625980", Offset = "0x7624980", VA = "0x187625980")]
	public IHGONHNDFKA(List<EHLBPHGFCOI> NMMGPHHJNFG, PNOBDCBDLNP? DFOCFJFGDFE, PJBEJGJLLLM LKGMMBJLAOE, bool NNEGMBBNJJI, bool JOEFCEKDCDA = false, [Optional] Guid? PGMAKHCMJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[KGCDFDOGPOJ]
public class MHKNNBHBKJI : GBHAIMFMHCK, PDDMBELEHHJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct AIEKFCHOOEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public MHKNNBHBKJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x761F8B0", Offset = "0x761E8B0", VA = "0x18761F8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x761FB90", Offset = "0x761EB90", VA = "0x18761FB90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000438")]
	internal static Action<JKKPLHHIIHB>? OILCDNBBOMC;

	[Cpp2IlInjected.Token(Token = "0x4000439")]
	internal static Func<JKKPLHHIIHB, Task>? AFLMLCOKFJN;

	[Cpp2IlInjected.Token(Token = "0x17000295")]
	public JKKPLHHIIHB ACHFPPAAIJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000296")]
	public int? JIKLNIABLEO
	{
		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0xDAD320", Offset = "0xDAC320", VA = "0x180DAD320")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000297")]
	public GICBMFJFHLI? IHMBMBPGMAM
	{
		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x7629050", Offset = "0x7628050", VA = "0x187629050", Slot = "5")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x7628F80", Offset = "0x7627F80", VA = "0x187628F80", Slot = "6")]
	[AsyncStateMachine(typeof(AIEKFCHOOEN))]
	public virtual Task AHKNCNAGGLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public MHKNNBHBKJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[EMIMLMIMMHE]
public class DDJBPIOEGPG : BalanceUpdateResponseDTO<MHKNNBHBKJI>
{
	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x76218E0", Offset = "0x76208E0", VA = "0x1876218E0")]
	public DDJBPIOEGPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[EMIMLMIMMHE]
public class PKKMHMIIKLD : BalanceUpdateResponseDTO<MHKNNBHBKJI>.OGAOPBELHMN
{
	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x762A530", Offset = "0x7629530", VA = "0x18762A530")]
	public PKKMHMIIKLD()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[KGCDFDOGPOJ]
	public class GiftItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000298")]
		public int ToPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000299")]
		public string? Message
		{
			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029A")]
		public bool Anonymous
		{
			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0xA68390", Offset = "0xA67390", VA = "0x180A68390")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0xA68440", Offset = "0xA67440", VA = "0x180A68440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029B")]
		public EHFKNLKDDIE GiftContext
		{
			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0xC333D0", Offset = "0xC323D0", VA = "0x180C333D0")]
			[CompilerGenerated]
			get
			{
				return default(EHFKNLKDDIE);
			}
			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0x1034ED0", Offset = "0x1033ED0", VA = "0x181034ED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public GiftItemDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[KGCDFDOGPOJ]
public class ODENGGBLDCP : PDDMBELEHHJ, BJFANCFIFED
{
	[Cpp2IlInjected.Token(Token = "0x1700029C")]
	public GOOKEEENOCO? LNKNHPGHOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029D")]
	[IgnoreDataMember]
	public Guid ELCENCJKGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x762A020", Offset = "0x7629020", VA = "0x18762A020", Slot = "5")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029E")]
	public IPFLNKMNPMP? CIFPKFEOOFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029F")]
	public List<BNOLJGINMNE>? EONFGNCHMFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A0")]
	public DateTime? LBAMBOKNKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x13AC120", Offset = "0x13AB120", VA = "0x1813AC120", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x14BC880", Offset = "0x14BB880", VA = "0x1814BC880")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A1")]
	public DateTime? FMBHECMKHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x15989A0", Offset = "0x15979A0", VA = "0x1815989A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x159B2F0", Offset = "0x159A2F0", VA = "0x18159B2F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A2")]
	public DateTime? FCNFJENOJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0xE60270", Offset = "0xE5F270", VA = "0x180E60270", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x5C98270", Offset = "0x5C97270", VA = "0x185C98270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A3")]
	public bool JMNHLFNMJEB
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0xD0EA60", Offset = "0xD0DA60", VA = "0x180D0EA60", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0xD0E020", Offset = "0xD0D020", VA = "0x180D0E020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A4")]
	public bool OJCHPLNLADC
	{
		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x107BCB0", Offset = "0x107ACB0", VA = "0x18107BCB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x123AC10", Offset = "0x1239C10", VA = "0x18123AC10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A5")]
	public bool JMFDMFFPKIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xFF2FD0", Offset = "0xFF1FD0", VA = "0x180FF2FD0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x123AC00", Offset = "0x1239C00", VA = "0x18123AC00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A6")]
	public bool KPLGPOICBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xFECFB0", Offset = "0xFEBFB0", VA = "0x180FECFB0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xFF2E00", Offset = "0xFF1E00", VA = "0x180FF2E00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x7629D80", Offset = "0x7628D80", VA = "0x187629D80")]
	public static ODENGGBLDCP AIGALKJFDKE(Guid GKOPHJCJIFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public ODENGGBLDCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[KGCDFDOGPOJ]
public class AMOEDOHIJDD
{
	[Cpp2IlInjected.Token(Token = "0x170002A7")]
	public int IPPLPEJMEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A8")]
	public string CLDNEEKOICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A9")]
	public string ABNNHFCJMFD
	{
		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AA")]
	public Dictionary<int, NJJHEHLGHEN> MLFPPLKANOP
	{
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AB")]
	public Dictionary<string, int> FJLDOHFHPPM
	{
		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AC")]
	public Dictionary<GBACOACNJHC, List<int>> NELFOIELKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AD")]
	public Dictionary<string, string> FHGNFAGCOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0xA674F0", Offset = "0xA664F0", VA = "0x180A674F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public AMOEDOHIJDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public enum GBACOACNJHC
{
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	DetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	SignUpScreen,
	[Cpp2IlInjected.Token(Token = "0x4000459")]
	ManageMembershipScreen,
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	ItemDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x400045B")]
	ActivityRewardsScreen,
	[Cpp2IlInjected.Token(Token = "0x400045C")]
	RoomPublishUpsell
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
[KGCDFDOGPOJ]
public class NJJHEHLGHEN : AIAAFHKLHLI
{
	[Cpp2IlInjected.Token(Token = "0x170002AE")]
	public JKLAMDFOKAK LGHELFHGEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(JKLAMDFOKAK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AF")]
	public bool FMCPECLMPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x1290C40", Offset = "0x128FC40", VA = "0x181290C40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x1588380", Offset = "0x1587380", VA = "0x181588380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B0")]
	public bool INBBLOHBOOP
	{
		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x1FFA260", Offset = "0x1FF9260", VA = "0x181FFA260")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x1FFA230", Offset = "0x1FF9230", VA = "0x181FFA230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B1")]
	public string DHLBBNOFGGB
	{
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B2")]
	public string IIEAADNOJMB
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B3")]
	public string MLMOHCGACJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B4")]
	public string BKGNLBMFLJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B5")]
	public Dictionary<NLJFAOJNHDJ, string> ECLNFOIGCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x1588390", Offset = "0x1587390", VA = "0x181588390")]
	public NJJHEHLGHEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[KGCDFDOGPOJ]
public class ILKICDHNJMN : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170002B6")]
	public IReadOnlyList<GOOKEEENOCO>? AANFIGCMBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public ILKICDHNJMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0xA6BBE0", Offset = "0xA6ABE0", VA = "0x180A6BBE0")]
	public ILKICDHNJMN(IReadOnlyList<GOOKEEENOCO>? OBKKPLKNIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public enum FCEOMOKNMBM
{
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	Unspecified = -1,
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	XP,
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	OutfitItem,
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	Equipment,
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	Currency,
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	Consumable,
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	Query,
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	HairDye
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public interface BJFANCFIFED
{
	[Cpp2IlInjected.Token(Token = "0x170002B7")]
	Guid ELCENCJKGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B8")]
	IPFLNKMNPMP? CIFPKFEOOFG
	{
		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B9")]
	List<BNOLJGINMNE>? EONFGNCHMFE
	{
		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BA")]
	DateTime? LBAMBOKNKHG
	{
		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BB")]
	DateTime? FMBHECMKHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BC")]
	DateTime? FCNFJENOJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BD")]
	bool JMNHLFNMJEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BE")]
	bool JMFDMFFPKIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BF")]
	bool KPLGPOICBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public interface JGFFHODFPDI
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action INCCFJNDKAI;

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task DHFHMJBLLHA(CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task JKEFHMLKHBL(CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BCHEKDLGPCP([Out] COBNMOOLJML ANJJOFOGAJP);
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public interface COBNMOOLJML
{
	[Cpp2IlInjected.Token(Token = "0x170002C0")]
	string CLDNEEKOICL
	{
		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C1")]
	string ABNNHFCJMFD
	{
		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C2")]
	IReadOnlyDictionary<GBACOACNJHC, IReadOnlyList<AIAAFHKLHLI>> CEHMIEAJJDN
	{
		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C3")]
	IReadOnlyDictionary<string, string> FHGNFAGCOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public interface AIAAFHKLHLI
{
	[Cpp2IlInjected.Token(Token = "0x170002C4")]
	string IIEAADNOJMB
	{
		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C5")]
	string DHLBBNOFGGB
	{
		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C6")]
	string MLMOHCGACJH
	{
		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C7")]
	string BKGNLBMFLJM
	{
		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public interface HCJBFOICEDA
{
	[Cpp2IlInjected.Token(Token = "0x170002C8")]
	NNIJHHALHAM FIFPILEIAAA
	{
		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C9")]
	string CMGKJAEFCGA
	{
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CA")]
	string MDMHNCCIHNN
	{
		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CB")]
	string MDNFIIEDKLN
	{
		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CC")]
	bool KPLGPOICBAH
	{
		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CD")]
	bool JMFDMFFPKIE
	{
		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CE")]
	LCEGHIAIKNO BINKMCLKKCI
	{
		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CF")]
	string MAAJPELBEBO
	{
		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D0")]
	NHKFIOBDEOB? GFOCKIGHJLA
	{
		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D1")]
	FCEOMOKNMBM EIOIDAPMIGN
	{
		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D2")]
	bool CAGJLKHEGMF
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
[KGCDFDOGPOJ]
public class IPFLNKMNPMP : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170002D3")]
	public NNIJHHALHAM HHDOJPCILPE
	{
		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(NNIJHHALHAM);
		}
		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D4")]
	public int? HGDFEFKDKCG
	{
		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x1344790", Offset = "0x1343790", VA = "0x181344790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x134F680", Offset = "0x134E680", VA = "0x18134F680")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D5")]
	public Guid? ODEPNLMJGGM
	{
		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0xA6EF50", Offset = "0xA6DF50", VA = "0x180A6EF50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0xA6EED0", Offset = "0xA6DED0", VA = "0x180A6EED0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x7626010", Offset = "0x7625010", VA = "0x187626010")]
	public static IPFLNKMNPMP HDHKFMKBCPJ(int NCFHPMBOLBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x76260B0", Offset = "0x76250B0", VA = "0x1876260B0")]
	public static IPFLNKMNPMP KNFIKJEBEMD(Guid GKOPHJCJIFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x7625E10", Offset = "0x7624E10", VA = "0x187625E10")]
	public static IPFLNKMNPMP GFGPMGKFHJM(DFKJCABFMCH BCDIEPFEGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public IPFLNKMNPMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public enum NNIJHHALHAM
{
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	PurchasableItem,
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	CustomAvatarItem
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
[KGCDFDOGPOJ]
public class BNOLJGINMNE : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170002D6")]
	public PJBEJGJLLLM JHOLLGDMPCH
	{
		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(PJBEJGJLLLM);
		}
		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D7")]
	public int CCNIGPGEOLH
	{
		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0xAB81E0", Offset = "0xAB71E0", VA = "0x180AB81E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0xB3D500", Offset = "0xB3C500", VA = "0x180B3D500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D8")]
	public IKOJIDAIAIN HFHBKEGDPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0xFEA4F0", Offset = "0xFE94F0", VA = "0x180FEA4F0", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x7620CA0", Offset = "0x761FCA0", VA = "0x187620CA0")]
	public int GIHGNIBMBEK(DateTime GCJFFBBGOGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public BNOLJGINMNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
[KGCDFDOGPOJ]
public class IKOJIDAIAIN : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170002D9")]
	public int KGIACMBCBII
	{
		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DA")]
	public DateTime? GENILENKJPD
	{
		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0xD36D60", Offset = "0xD35D60", VA = "0x180D36D60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0xF0BE40", Offset = "0xF0AE40", VA = "0x180F0BE40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DB")]
	public DateTime? IPIJGEGIKDG
	{
		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x13AC120", Offset = "0x13AB120", VA = "0x1813AC120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x14BC880", Offset = "0x14BB880", VA = "0x1814BC880")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x7625CF0", Offset = "0x7624CF0", VA = "0x187625CF0")]
	public bool HHAJLKOKGBM(DateTime GCJFFBBGOGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x7625DE0", Offset = "0x7624DE0", VA = "0x187625DE0")]
	public int JLGOMBKKBLL(DateTime GCJFFBBGOGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x7625C00", Offset = "0x7624C00", VA = "0x187625C00")]
	public TimeSpan? DLHOGMMEBMI(DateTime GCJFFBBGOGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public IKOJIDAIAIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public enum PNOBDCBDLNP
{
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	LaserTag = 1,
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	RecCenter = 2,
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	Watch = 3,
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	Quest_LostSkulls = 100,
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	Quest_Dracula = 101,
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	Quest_GoldenTrophy = 102,
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	Quest_CrimsonCauldron = 103,
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	RecRoyale = 200,
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	Cafe = 300,
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	Paintball = 400,
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	Paintball_River = 401,
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	Paintball_Homestead = 402,
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	Paintball_Quarry = 403,
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	Paintball_ClearCut = 404,
	[Cpp2IlInjected.Token(Token = "0x400048B")]
	Paintball_Spillway = 405,
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	Paintball_SunsetDriveIn = 406,
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	Bowling = 500,
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	StuntRunner = 600,
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	DormMirror = 700,
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	InventionStore = 800,
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	RoomKeys = 900,
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	Player_Profile = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	Room_Save = 1100,
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	RoomCurrencies = 1200,
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	Wishlist = 1300,
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	Friendotron = 1400,
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	RoomConsumables = 1500,
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	RecRally = 1600,
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	PopUpShop_1 = 1700,
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	PopUpShop_2 = 1701,
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	PopUpShop_3 = 1702,
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	PopUpShop_4 = 1703,
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	PopUpShop_5 = 1704,
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	PopUpShop_6 = 1705,
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	PopUpShop_7 = 1706,
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	PopUpShop_8 = 1707,
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	PopUpShop_9 = 1708,
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	PopUpShop_10 = 1709,
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	PopUpShop_11 = 1710,
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	PopUpShop_12 = 1711,
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	PopUpShop_13 = 1712,
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	PopUpShop_14 = 1713,
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	PopUpShop_15 = 1714,
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	PopUpShop_16 = 1715,
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	PopUpShop_17 = 1716,
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	PopUpShop_18 = 1717,
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	PopUpShop_19 = 1718,
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	PopUpShop_20 = 1719,
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	CustomAvatarItems = 1800,
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	ProgressionEventPurchasableXpBoosts = 1900,
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	PopUpShop_ProgressionEvent_1 = 2000,
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	PopUpShop_ProgressionEvent_2 = 2001,
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	PopUpShop_ProgressionEvent_3 = 2002,
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	PopUpShop_ProgressionEvent_4 = 2003,
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	PopUpShop_ProgressionEvent_5 = 2004,
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	RoomOffers = 2100,
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	MyLittleMonsters = 2200,
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	Destiny = 2201,
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	RunTheBlock = 2202,
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	RROStorefront_ToBeNamed_2 = 2203,
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	DevStorefront_DoNotAddToWatch_1 = 2300,
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	DevStorefront_DoNotAddToWatch_2 = 2301,
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	DevStorefront_DoNotAddToWatch_3 = 2302,
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	DevStorefront_DoNotAddToWatch_4 = 2303,
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	DevStorefront_DoNotAddToWatch_5 = 2304
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public enum GHFAJCLJGNI
{
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	GiftDrop,
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	SeasonTier,
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	SeasonEliteUpgrade
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public enum LLGJOMNJBNN
{
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	DirectBalanceWithMultiplier = 1,
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	FromGiftBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	NUXChallenge = 10,
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	AllNUXChallenges = 11,
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	DailyChallenge = 100,
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	AllDailyChallenges = 101,
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	FinishActivity = 200,
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	RecRoyaleMatchFinished = 250,
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	ChecklistCredit = 303,
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	WonGame = 1000,
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	LostGame = 1001,
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	WonGameRateLimited = 1002,
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	WonGamePartial = 1003,
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	LevelUp = 1100,
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	Registered = 1200,
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	CreatorReward = 1300,
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	CommercePurchase = 1400,
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	CommercePurchaseRevoked = 1401,
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	Manual_Refund = 2000,
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	Manual_Thanks = 2010,
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	Manual_Apology = 2020,
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	TestOnly = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public enum JCGENDOCHLM
{
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	Interval,
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	PerDay
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public enum MOEDOEPNOHE
{
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	PERCENTAGE = 1,
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	EXACT_AMOUNT
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
[KGCDFDOGPOJ]
public class AJMFBHADEHG : IEquatable<AJMFBHADEHG>
{
	[Cpp2IlInjected.Token(Token = "0x170002DC")]
	public int? NOKEAPMPNJB
	{
		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DD")]
	public int? FJMJFOIBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xDAD320", Offset = "0xDAC320", VA = "0x180DAD320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DE")]
	public int? FFFECIDPADN
	{
		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0xDCBC10", Offset = "0xDCAC10", VA = "0x180DCBC10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DF")]
	public List<int>? IAPIPHBEMMF
	{
		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x7620280", Offset = "0x761F280", VA = "0x187620280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x7620220", Offset = "0x761F220", VA = "0x187620220")]
	public static AJMFBHADEHG LHGLFIDGHAM(int? EIEFBNJNMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x761FBF0", Offset = "0x761EBF0", VA = "0x18761FBF0", Slot = "4")]
	public bool Equals(AJMFBHADEHG? EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x7620180", Offset = "0x761F180", VA = "0x187620180")]
	private static bool HBAOEGCGCCI(List<int>? JDINPJIAKOC, List<int>? LDPKBPICKKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x761FD70", Offset = "0x761ED70", VA = "0x18761FD70", Slot = "0")]
	public override bool Equals(object? PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x761FFA0", Offset = "0x761EFA0", VA = "0x18761FFA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public AJMFBHADEHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public struct DFKJCABFMCH : IEquatable<DFKJCABFMCH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	public readonly NNIJHHALHAM FIFPILEIAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private readonly int HGDFEFKDKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private readonly Guid ODEPNLMJGGM;

	[Cpp2IlInjected.Token(Token = "0x170002E0")]
	public Guid ELCENCJKGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x7622620", Offset = "0x7621620", VA = "0x187622620")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E1")]
	public int JIKLNIABLEO
	{
		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x76221D0", Offset = "0x76211D0", VA = "0x1876221D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E2")]
	public string BKMODPDPAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x7621D60", Offset = "0x7620D60", VA = "0x187621D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x7621920", Offset = "0x7620920", VA = "0x187621920")]
	public static bool AGIMFBCEFJB(string DECCMGJEIIJ, [Out] DFKJCABFMCH BCDIEPFEGGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x7621DB0", Offset = "0x7620DB0", VA = "0x187621DB0")]
	public static bool CLPJEPLGGMP(string DBDFCLHJING, [Out] DFKJCABFMCH BCDIEPFEGGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x7622350", Offset = "0x7621350", VA = "0x187622350")]
	public static DFKJCABFMCH FMBMEMANPCJ(int PBJHGGBBAAF)
	{
		return default(DFKJCABFMCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x7622080", Offset = "0x7621080", VA = "0x187622080")]
	public static DFKJCABFMCH EACHPKJGNBC(Guid PBJHGGBBAAF)
	{
		return default(DFKJCABFMCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x7622480", Offset = "0x7621480", VA = "0x187622480")]
	private static bool GLPKCDEEOPA(string DECCMGJEIIJ, [Out] NNIJHHALHAM BJLEJLJJDIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x7622740", Offset = "0x7621740", VA = "0x187622740")]
	private DFKJCABFMCH(NNIJHHALHAM BJLEJLJJDIL, int? DINCCDLMFAO, Guid? GKOPHJCJIFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x76221E0", Offset = "0x76211E0", VA = "0x1876221E0", Slot = "4")]
	public bool Equals(DFKJCABFMCH EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x7622250", Offset = "0x7621250", VA = "0x187622250", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x7622590", Offset = "0x7621590", VA = "0x187622590", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x7622690", Offset = "0x7621690", VA = "0x187622690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
[KGCDFDOGPOJ]
public abstract class IIDLGCBOJGC : IEquatable<IIDLGCBOJGC>, PDDMBELEHHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	public Guid FFMOKGCBEEL;

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x7625B90", Offset = "0x7624B90", VA = "0x187625B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x7625B10", Offset = "0x7624B10", VA = "0x187625B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x7624330", Offset = "0x7623330", VA = "0x187624330", Slot = "4")]
	public bool Equals(IIDLGCBOJGC EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x7625A00", Offset = "0x7624A00", VA = "0x187625A00", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract IIDLGCBOJGC AABAGJPEDHJ();

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	protected IIDLGCBOJGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public enum NJHJPFMKGEE
{
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	RoomKey,
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	RoomConsumable,
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	RoomCurrencyPurchaseOffer,
	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	StoreUGCAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40004EE")]
	UNDEFINED
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
[KGCDFDOGPOJ]
public class GOOKEEENOCO : IIDLGCBOJGC, IEquatable<GOOKEEENOCO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	public NJHJPFMKGEE BJLEJLJJDIL;

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x7624970", Offset = "0x7623970", VA = "0x187624970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x76248F0", Offset = "0x76238F0", VA = "0x1876248F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public GOOKEEENOCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x7624A10", Offset = "0x7623A10", VA = "0x187624A10")]
	public GOOKEEENOCO(NJHJPFMKGEE BJLEJLJJDIL, Guid FFMOKGCBEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x7624830", Offset = "0x7623830", VA = "0x187624830")]
	public static GOOKEEENOCO EACHPKJGNBC(Guid LBCLDJLEFBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x76248A0", Offset = "0x76238A0", VA = "0x1876248A0", Slot = "7")]
	public bool Equals(GOOKEEENOCO EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x76247C0", Offset = "0x76237C0", VA = "0x1876247C0", Slot = "6")]
	public override IIDLGCBOJGC AABAGJPEDHJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public static class MLMNOAEGPIK
{
	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x7629200", Offset = "0x7628200", VA = "0x187629200")]
	public static GOOKEEENOCO HKANNBMMEGI(this FNEMLMEJDAI ADPMEPGEIDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x7629270", Offset = "0x7628270", VA = "0x187629270")]
	public static GOOKEEENOCO MNPICENAOBH(string OCJCKNJNHNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x7629360", Offset = "0x7628360", VA = "0x187629360")]
	public static GOOKEEENOCO NBBGNOKJNCH(Guid DEMHFPGDNGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
[KGCDFDOGPOJ]
public class FNEMLMEJDAI : MDEIMOHHOIO, PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170002E3")]
	public NJHJPFMKGEE FIFPILEIAAA
	{
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(NJHJPFMKGEE);
		}
		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E4")]
	public Guid LNKNHPGHOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x1B1F290", Offset = "0x1B1E290", VA = "0x181B1F290")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x5C9B380", Offset = "0x5C9A380", VA = "0x185C9B380")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E5")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E6")]
	public string FMJEMOMMPEK
	{
		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E7")]
	public string CHIILACPAMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E8")]
	public long? ANKPNEKDDOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x10064E0", Offset = "0x10054E0", VA = "0x1810064E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x1006510", Offset = "0x1005510", VA = "0x181006510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E9")]
	public long CCNIGPGEOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0xA631E0", Offset = "0xA621E0", VA = "0x180A631E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0xF67CD0", Offset = "0xF66CD0", VA = "0x180F67CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EA")]
	public Guid? OJOBIHOGJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x7624090", Offset = "0x7623090", VA = "0x187624090")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x7624080", Offset = "0x7623080", VA = "0x187624080")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EB")]
	public DateTime POBHENPHPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0xA631A0", Offset = "0xA621A0", VA = "0x180A631A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0xF86350", Offset = "0xF85350", VA = "0x180F86350")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EC")]
	public DateTime GIPIHLKJPLD
	{
		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0xA6EF90", Offset = "0xA6DF90", VA = "0x180A6EF90")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xF86950", Offset = "0xF85950", VA = "0x180F86950")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public FNEMLMEJDAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x7624160", Offset = "0x7623160", VA = "0x187624160")]
	public FNEMLMEJDAI(NJHJPFMKGEE BJLEJLJJDIL, Guid FFMOKGCBEEL, [Optional] string HJLBILHBIIC, [Optional] string GAPCMICLLJD, [Optional] string IMHEEBEEIJH, [Optional] long? DJJNJEHBMJK, long FJMCJCMNJIL = 0L, [Optional] Guid? OMBCPBBOMDI, [Optional] DateTime IJEADHNFPOH, [Optional] DateTime MNDHCBMIMJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x76240B0", Offset = "0x76230B0", VA = "0x1876240B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public enum EEHJEEHMEFC
{
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	General,
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	Auto,
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	AGOnly,
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	Banned
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public enum CJJEIGDCFGB
{
	[Cpp2IlInjected.Token(Token = "0x4000500")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	TooManyTags,
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	TagUseRestricted,
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	InvalidTag,
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	InappropriateTag,
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	TagTooLong,
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	TagNotFound,
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	TagAlreadyExists,
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	NoChange,
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	TagRepeated,
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	LacksPermission,
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	InventionDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	ReservedWordViolation
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
[KGCDFDOGPOJ]
public class EKDKFKMDIIO : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170002ED")]
	public CJJEIGDCFGB IJBEHPGCOHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(CJJEIGDCFGB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EE")]
	public List<string> IGKBACLFPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x76235A0", Offset = "0x76225A0", VA = "0x1876235A0")]
	public string JOGBEKHJAFI(int AALACIEDMJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public EKDKFKMDIIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
[KGCDFDOGPOJ]
public class EOPJHDOGHKN : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170002EF")]
	public string GBJAIFIDHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F0")]
	public EEHJEEHMEFC HHDOJPCILPE
	{
		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
		[CompilerGenerated]
		get
		{
			return default(EEHJEEHMEFC);
		}
		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xA6A6F0", Offset = "0xA696F0", VA = "0x180A6A6F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public EOPJHDOGHKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public static class JGCIGCNCOEE
{
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public const string GKDFAILEFKL = "costume";

	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public const string NLELLKMOBPG = "gadget";

	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public const string IOHCBJCJNPB = "holotar";

	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public const string GACBBBNBMFB = "large";

	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public const string GDMCMIAPFGC = "medium";

	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public const string DFBOMDCMAGP = "small";

	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public const string EMMKJMGKDLN = "sound";

	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public const string DEMHEBMALNA = "dormanchor";

	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public const string HGBFOBNHOFC = "reccenteranchor";

	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public const string HAMOHILJEHI = "r2";

	[Cpp2IlInjected.Token(Token = "0x170002F1")]
	public static List<string> GFEPKIEEIPH
	{
		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x76264A0", Offset = "0x76254A0", VA = "0x1876264A0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public static class MHJNPMIBJDC
{
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	public const string NNOKCNGOFLF = "beta";

	[Cpp2IlInjected.Token(Token = "0x400051D")]
	public const string IDBEEIBFNJM = "limitsv2";
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
[KGCDFDOGPOJ]
public class AGOELHIAIIK : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170002F2")]
	public List<string> MLHHIGKHALB
	{
		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F3")]
	public List<string> OAEDFLGGHEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F4")]
	public List<string> FMGODGHEPFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public AGOELHIAIIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public class KFGIJJFJLGA : IEquatable<KFGIJJFJLGA>
{
	[Cpp2IlInjected.Token(Token = "0x170002F5")]
	protected virtual Type HENDJOPJCBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x7627460", Offset = "0x7626460", VA = "0x187627460", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F6")]
	public NNPMGHNBFMD? FLPGCNAJDAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F7")]
	public HttpMethod? FEJMPMNGHOD
	{
		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F8")]
	public string? KIMPCGLHHAO
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x7627B90", Offset = "0x7626B90", VA = "0x187627B90")]
	public KFGIJJFJLGA(NNPMGHNBFMD? FLPGCNAJDAG, HttpMethod? FEJMPMNGHOD, string? KIMPCGLHHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x7627A80", Offset = "0x7626A80", VA = "0x187627A80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x7627890", Offset = "0x7626890", VA = "0x187627890", Slot = "6")]
	protected virtual bool JOGJFECJHFK(StringBuilder FJCCOAKCNIN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x1204BD0", Offset = "0x1203BD0", VA = "0x181204BD0")]
	public static bool BDCEBPMLGHE(KFGIJJFJLGA? MACAGNGMFOK, KFGIJJFJLGA? IHEPOLKBHPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x12050A0", Offset = "0x12040A0", VA = "0x1812050A0")]
	public static bool PHGIAKEDBEK(KFGIJJFJLGA? MACAGNGMFOK, KFGIJJFJLGA? IHEPOLKBHPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x76276E0", Offset = "0x76266E0", VA = "0x1876276E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x7627650", Offset = "0x7626650", VA = "0x187627650", Slot = "0")]
	public override bool Equals(object? PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x76274C0", Offset = "0x76264C0", VA = "0x1876274C0", Slot = "7")]
	public virtual bool Equals(KFGIJJFJLGA? EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x76279F0", Offset = "0x76269F0", VA = "0x1876279F0", Slot = "8")]
	public virtual KFGIJJFJLGA LCLCDINMEDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x7627BE0", Offset = "0x7626BE0", VA = "0x187627BE0")]
	protected KFGIJJFJLGA(KFGIJJFJLGA NKCMILOENIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x7627850", Offset = "0x7626850", VA = "0x187627850")]
	public void HBLCGHBNJLA([Out] NNPMGHNBFMD? FLPGCNAJDAG, [Out] HttpMethod? FEJMPMNGHOD, [Out] string? KIMPCGLHHAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public class DKPKAOJMDEI : IEquatable<DKPKAOJMDEI>
{
	[Cpp2IlInjected.Token(Token = "0x170002F9")]
	protected virtual Type HENDJOPJCBH
	{
		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x7622A20", Offset = "0x7621A20", VA = "0x187622A20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FA")]
	public int OAOCEBIGEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FB")]
	public JMHFDMGDBDO GIILOKECCDO
	{
		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0xAB81E0", Offset = "0xAB71E0", VA = "0x180AB81E0")]
		[CompilerGenerated]
		get
		{
			return default(JMHFDMGDBDO);
		}
		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0xB3D500", Offset = "0xB3C500", VA = "0x180B3D500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x7623020", Offset = "0x7622020", VA = "0x187623020")]
	public DKPKAOJMDEI(int OAOCEBIGEAJ, JMHFDMGDBDO GIILOKECCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x7622F10", Offset = "0x7621F10", VA = "0x187622F10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x7622D70", Offset = "0x7621D70", VA = "0x187622D70", Slot = "6")]
	protected virtual bool JOGJFECJHFK(StringBuilder FJCCOAKCNIN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x1204BD0", Offset = "0x1203BD0", VA = "0x181204BD0")]
	public static bool BDCEBPMLGHE(DKPKAOJMDEI? MACAGNGMFOK, DKPKAOJMDEI? IHEPOLKBHPP)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x12050A0", Offset = "0x12040A0", VA = "0x1812050A0")]
	public static bool PHGIAKEDBEK(DKPKAOJMDEI? MACAGNGMFOK, DKPKAOJMDEI? IHEPOLKBHPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x7622C50", Offset = "0x7621C50", VA = "0x187622C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x7622A80", Offset = "0x7621A80", VA = "0x187622A80", Slot = "0")]
	public override bool Equals(object? PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x7622B10", Offset = "0x7621B10", VA = "0x187622B10", Slot = "7")]
	public virtual bool Equals(DKPKAOJMDEI? EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(RVA = "0x7622EA0", Offset = "0x7621EA0", VA = "0x187622EA0", Slot = "8")]
	public virtual DKPKAOJMDEI LCLCDINMEDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0xCA97B0", Offset = "0xCA87B0", VA = "0x180CA97B0")]
	protected DKPKAOJMDEI(DKPKAOJMDEI NKCMILOENIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x7622D60", Offset = "0x7621D60", VA = "0x187622D60")]
	public void HBLCGHBNJLA([Out] int OAOCEBIGEAJ, [Out] JMHFDMGDBDO GIILOKECCDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public enum JMHFDMGDBDO
{
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	ConnectionTimeout,
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	InternalServerError
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public interface HDIMGAHICMO
{
	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<KFGIJJFJLGA, DKPKAOJMDEI> PKIMGMHJHIJ();

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JMJJBHFIKII(KFGIJJFJLGA DAKIIEIEKNI, DKPKAOJMDEI DMHPHEGJKMB);

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JPLHHCGPPDJ(KFGIJJFJLGA DAKIIEIEKNI);

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NOIIDLNFGJH();

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task BIAPHIDBDCG(NNPMGHNBFMD JMELKBNBGDN, HttpMethod JFPLGEEKCOD, string DJEHBDNLJBJ, CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public interface KHFFHHBNAJE
{
	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<Guid>> EALPGMHHEEN(string CPKANLPPMKB);
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
[AOLJPBCNDMG]
public class FGLBCGIODIE<TResult> where TResult : PDDMBELEHHJ, new()
{
	[Cpp2IlInjected.Token(Token = "0x170002FC")]
	public IReadOnlyList<TResult> OAGEEPJOBFA
	{
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FD")]
	public long LCLEDOLHJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0xDAD320", Offset = "0xDAC320", VA = "0x180DAD320")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public FGLBCGIODIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public enum MPJAIMDGIEF
{
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	Development = 1,
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	QA = 8,
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	Production = 0x100
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public interface LEBCBPHLODN : DGIFEDFLGAO
{
	[Cpp2IlInjected.Token(Token = "0x170002FE")]
	bool FMDKIHIDMPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AuthorizePurchaseAsync(long BNPOMCDAPEB, CEGCBACGOCK NBKNGNMDAJA);

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<MKEMNPIIMEB> PurchaseAsync(CEGCBACGOCK NBKNGNMDAJA, AJMFBHADEHG GIJINFOKGKB);

	[Cpp2IlInjected.Token(Token = "0x6000757")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task ValidatePurchasingSupported(CPNBDALODJN PFLPJAMEKAB, CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public interface DGIFEDFLGAO
{
	[Cpp2IlInjected.Token(Token = "0x170002FF")]
	bool PJPGCMCKJNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000759")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<string> FetchCommerceAccessToken([Optional] CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public interface HOKFAGKFNMO
{
	[Cpp2IlInjected.Token(Token = "0x17000300")]
	int PPPMLMAANEE
	{
		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600075A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<CEGCBACGOCK>> AHGBLEPLPKL(bool DGGBADKLHKA = false, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600075B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BHDIIJGGMBO([Out] CEGCBACGOCK? IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x600075C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<CEGCBACGOCK> PIKKFALEPMI(bool DGGBADKLHKA = false, [Optional] CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CHEGFICMGAE(string LPKJHGCILMN = "");
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public interface KMEPPOBCHOP
{
	[Cpp2IlInjected.Token(Token = "0x600075F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task IPEGCPFNJDO(CPNBDALODJN PFLPJAMEKAB, CancellationToken KGALDHLEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000760")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AJAFGIMKBIE(CPNBDALODJN PFLPJAMEKAB, CancellationToken KGALDHLEDNC, [Optional] FLOMMBGNKHD? AGCCGDJPCJK);
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public interface FLOMMBGNKHD
{
	[Cpp2IlInjected.Token(Token = "0x6000761")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HAGFIOKGMCJ(string NCBKJJBPLBE);
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public interface FFLLDKLGDOO
{
	[Cpp2IlInjected.Token(Token = "0x6000762")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OHKPGLNJNKC(CPNBDALODJN EPDCFIOIDOF, CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public interface BDILMOFOIBE
{
	[Cpp2IlInjected.Token(Token = "0x17000301")]
	bool ENACBJIOBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public interface HIKDBBKBIEC
{
	[Cpp2IlInjected.Token(Token = "0x6000764")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CPNBDALODJN LBPGEBEELJE(CEGCBACGOCK NBKNGNMDAJA, AJMFBHADEHG GIJINFOKGKB, string LKDIGLEEFDM, [Optional] KMEPPOBCHOP? BEOCMPGNMID);
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public interface PKLJNEDBGEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000765")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ELFACBJMIFH(FFLLDKLGDOO NCAIPIHIMAM);

	[Cpp2IlInjected.Token(Token = "0x6000766")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FPAJAMHNJOP(FFLLDKLGDOO NCAIPIHIMAM);

	[Cpp2IlInjected.Token(Token = "0x6000767")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task KJAHFAMOOFG(CPNBDALODJN PFLPJAMEKAB, CancellationToken KGALDHLEDNC);
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public interface CPNBDALODJN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000302")]
	BMMBHBNBELI JIOGKNMGBFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000303")]
	CEGCBACGOCK CDDDAGOONPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000304")]
	AJMFBHADEHG GNPJGAMDKEH
	{
		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000305")]
	string NMHMAIAGLLF
	{
		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000306")]
	string INPKEOHMAJK
	{
		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600076D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<PGOMMNOPKJA> AOGKIKCFEME(CancellationToken JDJIJJCCKPD, [Optional] FLOMMBGNKHD? AGCCGDJPCJK);

	[Cpp2IlInjected.Token(Token = "0x600076E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CFFFIGPNGFB(string FKEHNOKIBKC);

	[Cpp2IlInjected.Token(Token = "0x600076F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CFFFIGPNGFB<T>(Func<T, string> FKEHNOKIBKC, [In] T LCMKLLMMPCH);
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public abstract class BJIAEDINFEN
{
	[Cpp2IlInjected.Token(Token = "0x6000770")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	protected BJIAEDINFEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public enum IBFIAPIFONB
{
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	InAppPurchaseNotAllowedOnAccount,
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	PlatformPurchaseException,
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	PlatformPurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	CommerceInitiatePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	FailedToGetPlatformAccessToken,
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	PlatformAuthorizePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	CommerceCompletePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	PlatformSubscriptionNotSupported,
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	PlatformPurchasesNotSupported,
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	OculusDesktopPlayersMustBeInVR,
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	FailedToRetrieveParentalControls,
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	UserCanceled,
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	DebugError
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public enum GJCLKJEGMCF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	AccountError,
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	PlatformError,
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	CommerceError,
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	UserAction
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
[KGCDFDOGPOJ]
public class CEGCBACGOCK : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000307")]
	public int IODIEHDGGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000308")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000309")]
	public string FMJEMOMMPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030A")]
	public string CHIILACPAMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030B")]
	public int CCNIGPGEOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0xA674E0", Offset = "0xA664E0", VA = "0x180A674E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0xA672E0", Offset = "0xA662E0", VA = "0x180A672E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030C")]
	public string MDEDPBNGOHA
	{
		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030D")]
	public string PNNEDGDEOCO
	{
		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xA674F0", Offset = "0xA664F0", VA = "0x180A674F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030E")]
	[DataMember(Name = "PsnProductLabel")]
	public string LEEKCNCHDFC
	{
		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0xA68520", Offset = "0xA67520", VA = "0x180A68520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030F")]
	public string GPHMCFPJOOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0xA631E0", Offset = "0xA621E0", VA = "0x180A631E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0xA631D0", Offset = "0xA621D0", VA = "0x180A631D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000310")]
	public string NPEJPDHLLCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xA63170", Offset = "0xA62170", VA = "0x180A63170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0xA631B0", Offset = "0xA621B0", VA = "0x180A631B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000311")]
	public string OKEDLIHPPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0xA63190", Offset = "0xA62190", VA = "0x180A63190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0xA631F0", Offset = "0xA621F0", VA = "0x180A631F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000312")]
	public string NCIBEFEBBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0xA63200", Offset = "0xA62200", VA = "0x180A63200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0xA631C0", Offset = "0xA621C0", VA = "0x180A631C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000313")]
	public string NOAHOKDGCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0xA631A0", Offset = "0xA621A0", VA = "0x180A631A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0xA63180", Offset = "0xA62180", VA = "0x180A63180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000314")]
	public bool AAHCHIFAFCE
	{
		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0xD4C970", Offset = "0xD4B970", VA = "0x180D4C970")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0xD4C1D0", Offset = "0xD4B1D0", VA = "0x180D4C1D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000315")]
	public bool KJPHJLLJCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x17FDCD0", Offset = "0x17FCCD0", VA = "0x1817FDCD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x17FDEB0", Offset = "0x17FCEB0", VA = "0x1817FDEB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000316")]
	public OGBKBGMIEBL FGNOGEEOKID
	{
		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0xA6EEA0", Offset = "0xA6DEA0", VA = "0x180A6EEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0xA6F010", Offset = "0xA6E010", VA = "0x180A6F010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000317")]
	[IgnoreDataMember]
	public string DBJACPNFDBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0xA6F020", Offset = "0xA6E020", VA = "0x180A6F020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0xA6EE80", Offset = "0xA6DE80", VA = "0x180A6EE80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000318")]
	[IgnoreDataMember]
	public string FADJMLNMDJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0xAC8EE0", Offset = "0xAC7EE0", VA = "0x180AC8EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0xAC54F0", Offset = "0xAC44F0", VA = "0x180AC54F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000319")]
	[IgnoreDataMember]
	public string BCGONFEHFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0xA6EE70", Offset = "0xA6DE70", VA = "0x180A6EE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0xA6EFE0", Offset = "0xA6DFE0", VA = "0x180A6EFE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031A")]
	[IgnoreDataMember]
	public BJIAEDINFEN MOAFMONLNDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0xAC9300", Offset = "0xAC8300", VA = "0x180AC9300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0xB11FD0", Offset = "0xB10FD0", VA = "0x180B11FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031B")]
	[IgnoreDataMember]
	public bool HEAJLPMJFHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x7620FB0", Offset = "0x761FFB0", VA = "0x187620FB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031C")]
	[IgnoreDataMember]
	public string JBDOJJNPAMG
	{
		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0xA62800", Offset = "0xA61800", VA = "0x180A62800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0xA628C0", Offset = "0xA618C0", VA = "0x180A628C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600079C")]
	[Cpp2IlInjected.Address(RVA = "0x7620EC0", Offset = "0x761FEC0", VA = "0x187620EC0", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x7620FD0", Offset = "0x761FFD0", VA = "0x187620FD0")]
	public static CEGCBACGOCK NOGNMMBGKGN(int PBJHGGBBAAF, string HJLBILHBIIC, string IMHEEBEEIJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x7621070", Offset = "0x7620070", VA = "0x187621070", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public CEGCBACGOCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
[KGCDFDOGPOJ]
public class OGBKBGMIEBL : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700031D")]
	public List<int> NOFELHJAKJP
	{
		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031E")]
	public string PKCPPLKFBIF
	{
		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031F")]
	public BLPIECFCNCG AMCAAJKMKBD
	{
		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007A6")]
	[Cpp2IlInjected.Address(RVA = "0xFEA4F0", Offset = "0xFE94F0", VA = "0x180FEA4F0", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public OGBKBGMIEBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public readonly struct PGOMMNOPKJA
{
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	public enum KBLGPDGEAIG : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		CancelledByUser,
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		Success
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	public readonly KBLGPDGEAIG MNMHGMIGNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400055E")]
	public readonly GJCLKJEGMCF FBPMJEADBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400055F")]
	public readonly IBFIAPIFONB HNCJKCAPPMK;

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x762A520", Offset = "0x7629520", VA = "0x18762A520")]
	private PGOMMNOPKJA(KBLGPDGEAIG GICMHPOANOB, GJCLKJEGMCF DCLICAGFPAL = GJCLKJEGMCF.Unknown, IBFIAPIFONB IFIPEIPBJFG = IBFIAPIFONB.Unknown)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x762A500", Offset = "0x7629500", VA = "0x18762A500")]
	public static PGOMMNOPKJA MIFAEMCECOM()
	{
		return default(PGOMMNOPKJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0x762A4E0", Offset = "0x76294E0", VA = "0x18762A4E0")]
	public static PGOMMNOPKJA KEEGDKOGOFO()
	{
		return default(PGOMMNOPKJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0x762A4C0", Offset = "0x76294C0", VA = "0x18762A4C0")]
	public static PGOMMNOPKJA JMHFDPGIPHM(GJCLKJEGMCF DCLICAGFPAL, IBFIAPIFONB IFIPEIPBJFG)
	{
		return default(PGOMMNOPKJA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public enum IBGFEOICKGI
{
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	Gold,
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	Platinum
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public enum MKEOIKLHAME
{
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	Month,
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	Year,
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	ThreeMonth,
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	SixMonth
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
[KGCDFDOGPOJ]
public class BLPIECFCNCG : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000320")]
	public IBGFEOICKGI NMBNNEHBBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(IBGFEOICKGI);
		}
		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000321")]
	public MKEOIKLHAME GPJLCLNAGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0xAB81E0", Offset = "0xAB71E0", VA = "0x180AB81E0")]
		[CompilerGenerated]
		get
		{
			return default(MKEOIKLHAME);
		}
		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0xB3D500", Offset = "0xB3C500", VA = "0x180B3D500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000322")]
	public bool LDOFABINGOF
	{
		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0xAB8160", Offset = "0xAB7160", VA = "0x180AB8160")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0xA69F60", Offset = "0xA68F60", VA = "0x180A69F60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public BLPIECFCNCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
public enum BMMBHBNBELI
{
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	Error = -2,
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	Cancelled,
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	AttemptStarted,
	[Cpp2IlInjected.Token(Token = "0x4000574")]
	PurchaseComplete
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
[KGCDFDOGPOJ]
public class OENAFGIDDAM : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000323")]
	public long JDAGAEFIFLB
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000324")]
	public long DGLCLJBAPCP
	{
		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0xDAD320", Offset = "0xDAC320", VA = "0x180DAD320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000325")]
	public bool JJFMFGPFONI
	{
		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0xA68390", Offset = "0xA67390", VA = "0x180A68390")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0xA68440", Offset = "0xA67440", VA = "0x180A68440")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007BA")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BB")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public OENAFGIDDAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
[KGCDFDOGPOJ]
public class BCBMEHBLDMF : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000326")]
	public string JBOKPJIMHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000327")]
	public CKEIKLKOBKE? DIMONFJPPFN
	{
		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000328")]
	public IReadOnlyList<CKEIKLKOBKE>? NOEMCFDKJCF
	{
		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000329")]
	public IReadOnlyList<string>? HBBDCGONNBA
	{
		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032A")]
	public FLJIPBEPCNH FCJNCLGCKGH
	{
		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032B")]
	public string? NKCMICPDOJF
	{
		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032C")]
	public string? EPIALLIHLNP
	{
		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0xA674F0", Offset = "0xA664F0", VA = "0x180A674F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032D")]
	public string? MANJBECCIEI
	{
		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0xA68520", Offset = "0xA67520", VA = "0x180A68520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CD")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public BCBMEHBLDMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
[KGCDFDOGPOJ]
public class LHLLNNGEHIO : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700032E")]
	public string AKNIMEMCMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032F")]
	public CKEIKLKOBKE? DIMONFJPPFN
	{
		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000330")]
	public FLJIPBEPCNH FCJNCLGCKGH
	{
		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000331")]
	public string? EPIALLIHLNP
	{
		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000332")]
	public IReadOnlyList<string>? HBBDCGONNBA
	{
		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public LHLLNNGEHIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
[KGCDFDOGPOJ]
public class FLJIPBEPCNH : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000333")]
	public string ALAHNNNNNDL
	{
		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000334")]
	public bool EPKEOBAEKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0xAB8160", Offset = "0xAB7160", VA = "0x180AB8160")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0xA69F60", Offset = "0xA68F60", VA = "0x180A69F60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000335")]
	public bool GFDBDEFPGHL
	{
		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x11BD0B0", Offset = "0x11BC0B0", VA = "0x1811BD0B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x131D130", Offset = "0x131C130", VA = "0x18131D130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000336")]
	public bool JIMCEPHJAHA
	{
		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0x11BD0A0", Offset = "0x11BC0A0", VA = "0x1811BD0A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0x163E510", Offset = "0x163D510", VA = "0x18163E510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000337")]
	public bool LAKHHOCLDGF
	{
		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0x11BD090", Offset = "0x11BC090", VA = "0x1811BD090")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x53D59C0", Offset = "0x53D49C0", VA = "0x1853D59C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000338")]
	public bool IIFOHAJMDPH
	{
		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0xB1AC50", Offset = "0xB19C50", VA = "0x180B1AC50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0xE3B020", Offset = "0xE3A020", VA = "0x180E3B020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000339")]
	public bool BOPJLGKNGKO
	{
		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0xB1AA60", Offset = "0xB19A60", VA = "0x180B1AA60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0xE3B1D0", Offset = "0xE3A1D0", VA = "0x180E3B1D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033A")]
	public bool NADLAFAIACB
	{
		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x1AA3380", Offset = "0x1AA2380", VA = "0x181AA3380")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x7623FC0", Offset = "0x7622FC0", VA = "0x187623FC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033B")]
	public bool POAOHLHKGDM
	{
		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x1A92390", Offset = "0x1A91390", VA = "0x181A92390")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x7623FB0", Offset = "0x7622FB0", VA = "0x187623FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033C")]
	public bool AAIBLHGBKEH
	{
		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0xA68390", Offset = "0xA67390", VA = "0x180A68390")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0xA68440", Offset = "0xA67440", VA = "0x180A68440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033D")]
	public bool CEGCAONDCOE
	{
		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x15155C0", Offset = "0x15145C0", VA = "0x1815155C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x1514FA0", Offset = "0x1513FA0", VA = "0x181514FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033E")]
	public bool ILDFHCOKMAA
	{
		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x15F3160", Offset = "0x15F2160", VA = "0x1815F3160")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x15F2D50", Offset = "0x15F1D50", VA = "0x1815F2D50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x7623FD0", Offset = "0x7622FD0", VA = "0x187623FD0")]
	public FLJIPBEPCNH(string MLOAFBJPDBA, bool GBNNEJDCJDH, bool GKFLFABOFDD, bool GNHBADDALAD, bool AGKPBKHDBNC, bool LCIGOPMKAMF, bool GJPPPFFEELP, bool PGPMGBJDNPN, bool KNLDEHIPELB, bool GAJGJFFFHMD, bool HPGLBNHBLEJ, bool KMFMGCHJNBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
[KGCDFDOGPOJ]
public class NLPKOFKABKA : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700033F")]
	public string GLEJJBBKCAE
	{
		[Cpp2IlInjected.Token(Token = "0x60007F4")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F5")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000340")]
	public string MANJBECCIEI
	{
		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000341")]
	public string NKCMICPDOJF
	{
		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000342")]
	public string? ELIEPKMFMDB
	{
		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000343")]
	public string? LAPOCMLIPIM
	{
		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000344")]
	public float EHPOIAEAILI
	{
		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0xAB2F30", Offset = "0xAB1F30", VA = "0x180AB2F30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x1E8F370", Offset = "0x1E8E370", VA = "0x181E8F370")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000800")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000801")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public NLPKOFKABKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
[KGCDFDOGPOJ]
public class NJJCKMNKLHJ : BFOBFLKGLKA, PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000345")]
	public string GJGAFBHFKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000346")]
	public string PPIBMEJLINM
	{
		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "6")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public NJJCKMNKLHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
[KGCDFDOGPOJ]
public class IDHJJGHJNBA : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000347")]
	public Guid DHFDAAEGMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE60", Offset = "0xE5DE60", VA = "0x180E5EE60")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE70", Offset = "0xE5DE70", VA = "0x180E5EE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000348")]
	public long ANKPNEKDDOB
	{
		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0xDCBC10", Offset = "0xDCAC10", VA = "0x180DCBC10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000349")]
	public long COGABHEFNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0xA683D0", Offset = "0xA673D0", VA = "0x180A683D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034A")]
	public decimal DDBOOBOKJAL
	{
		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0xF0CDA0", Offset = "0xF0BDA0", VA = "0x180F0CDA0")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0xF0D8F0", Offset = "0xF0C8F0", VA = "0x180F0D8F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000810")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000811")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public IDHJJGHJNBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
[KGCDFDOGPOJ]
public class AOPILGDPBMO : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700034B")]
	public string GJGAFBHFKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034C")]
	public string IODDOGHHOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000816")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public AOPILGDPBMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000817")]
	[Cpp2IlInjected.Address(RVA = "0xA653E0", Offset = "0xA643E0", VA = "0x180A653E0")]
	public AOPILGDPBMO(string DIKAKHCHMCD, string ALJGFANPBEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000818")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
[KGCDFDOGPOJ]
public class LFGFBIOICMK : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700034D")]
	public string MANJBECCIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034E")]
	public string JBOKPJIMHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034F")]
	public bool BBLBOPHFLCF
	{
		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0xA68390", Offset = "0xA67390", VA = "0x180A68390")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0xA68440", Offset = "0xA67440", VA = "0x180A68440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public LFGFBIOICMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
[KGCDFDOGPOJ]
public class CMGGAJLPODH : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000350")]
	public string LAFAEPNEHJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000351")]
	public decimal PLMLCBLLPOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0xD36D60", Offset = "0xD35D60", VA = "0x180D36D60")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0xF0BE40", Offset = "0xF0AE40", VA = "0x180F0BE40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000826")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public CMGGAJLPODH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
[KGCDFDOGPOJ]
public class FJBAJGBAKCC : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000352")]
	public string MANJBECCIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000353")]
	public string JBOKPJIMHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000354")]
	public string FMBPDPLPMBM
	{
		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600082D")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082E")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public FJBAJGBAKCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
[KGCDFDOGPOJ]
public class AMCHEHLLFPF : KFKCCDLPIHJ
{
	[Cpp2IlInjected.Token(Token = "0x600082F")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public AMCHEHLLFPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
[KGCDFDOGPOJ]
public class BPHDNPCBFKO : POJKIIAILCH
{
	[Cpp2IlInjected.Token(Token = "0x6000830")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public BPHDNPCBFKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
[KGCDFDOGPOJ]
public class HNFHPMBGCPC : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000355")]
	public string MDMHNCCIHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000356")]
	public string JBOKPJIMHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000357")]
	public bool JEBBLKLHCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0xA68390", Offset = "0xA67390", VA = "0x180A68390")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0xA68440", Offset = "0xA67440", VA = "0x180A68440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000837")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000838")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public HNFHPMBGCPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
[KGCDFDOGPOJ]
public class NOIKIFIIGHH : HNFHPMBGCPC
{
	[Cpp2IlInjected.Token(Token = "0x17000358")]
	public string CHIILACPAMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public NOIKIFIIGHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
[KGCDFDOGPOJ]
public class CKJGODBGMBM : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000359")]
	public long PINBDEAHKHI
	{
		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035A")]
	public string MDMHNCCIHNN
	{
		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035B")]
	public OOBJJNBJGIO NALMPHKJMFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000840")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return default(OOBJJNBJGIO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAAD190", VA = "0x180AAE190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035C")]
	public Guid? HFOOKKOGBFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0x7621170", Offset = "0x7620170", VA = "0x187621170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0x7621160", Offset = "0x7620160", VA = "0x187621160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035D")]
	public string? MLCNBIKFBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000846")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000847")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public CKJGODBGMBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
public enum OOBJJNBJGIO
{
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	Requested = 0,
	[Cpp2IlInjected.Token(Token = "0x40005B2")]
	ProviderMeshRequested = 1,
	[Cpp2IlInjected.Token(Token = "0x40005B3")]
	ProviderMeshGenerated = 2,
	[Cpp2IlInjected.Token(Token = "0x40005B4")]
	ProviderMeshGenFailed = 3,
	[Cpp2IlInjected.Token(Token = "0x40005B5")]
	CloudBuildRequested = 11,
	[Cpp2IlInjected.Token(Token = "0x40005B6")]
	CloudBuildCompleted = 12,
	[Cpp2IlInjected.Token(Token = "0x40005B7")]
	CloudBuildFailed = 13,
	[Cpp2IlInjected.Token(Token = "0x40005B8")]
	MeshGenCompleted = 21,
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	ImageReferenceRequested = 31,
	[Cpp2IlInjected.Token(Token = "0x40005BA")]
	ImageReferenceGenerated = 32,
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	ImageReferenceGenerationFailed = 33
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
[KGCDFDOGPOJ]
public class BEPAKPHEHKG : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700035E")]
	public string? MANJBECCIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035F")]
	public string JBOKPJIMHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600084C")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084D")]
	[Cpp2IlInjected.Address(RVA = "0x7620B00", Offset = "0x761FB00", VA = "0x187620B00")]
	public BEPAKPHEHKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
[KGCDFDOGPOJ]
public class POJKIIAILCH : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000360")]
	public string MANJBECCIEI
	{
		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000361")]
	public string JBOKPJIMHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000852")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000853")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public POJKIIAILCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
[KGCDFDOGPOJ]
public class KFKCCDLPIHJ : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000362")]
	public List<string> GAOCBFMDNOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000363")]
	public decimal PHPMJCNMALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0xD36D60", Offset = "0xD35D60", VA = "0x180D36D60")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x6000857")]
		[Cpp2IlInjected.Address(RVA = "0xF0BE40", Offset = "0xF0AE40", VA = "0x180F0BE40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public KFKCCDLPIHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
[KGCDFDOGPOJ]
public class OAPEMEILDKJ : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000364")]
	public int CMGKJAEFCGA
	{
		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000365")]
	public string HHDOJPCILPE
	{
		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000366")]
	public string? GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000367")]
	public IReadOnlyList<int> FIECLPDAAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000368")]
	public string? JKFBEFNCKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000864")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000865")]
	[Cpp2IlInjected.Address(RVA = "0x7629C80", Offset = "0x7628C80", VA = "0x187629C80")]
	public OAPEMEILDKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
[KGCDFDOGPOJ]
public class BMAEBPGMEPF : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000369")]
	public int CMGKJAEFCGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000866")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036A")]
	public Guid? ODEPNLMJGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x2445090", Offset = "0x2444090", VA = "0x182445090")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0x2444D70", Offset = "0x2443D70", VA = "0x182444D70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036B")]
	public string HHDOJPCILPE
	{
		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036C")]
	public List<OAPEMEILDKJ> DGLJDCBGKEO
	{
		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036D")]
	public List<OAPEMEILDKJ> GLBLKJLMPJM
	{
		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036E")]
	public string? GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0xA674F0", Offset = "0xA664F0", VA = "0x180A674F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036F")]
	public string? JKFBEFNCKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000873")]
		[Cpp2IlInjected.Address(RVA = "0xA68520", Offset = "0xA67520", VA = "0x180A68520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000370")]
	public string? DBPAKFOCKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0xA631E0", Offset = "0xA621E0", VA = "0x180A631E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0xA631D0", Offset = "0xA621D0", VA = "0x180A631D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000876")]
	[Cpp2IlInjected.Address(RVA = "0x7620BB0", Offset = "0x761FBB0", VA = "0x187620BB0", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000877")]
	[Cpp2IlInjected.Address(RVA = "0x7620BE0", Offset = "0x761FBE0", VA = "0x187620BE0")]
	public BMAEBPGMEPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
[KGCDFDOGPOJ]
public class CKHNAHHDNCP : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000371")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000372")]
	public BMAEBPGMEPF DGLJDCBGKEO
	{
		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000373")]
	public BMAEBPGMEPF GLBLKJLMPJM
	{
		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000374")]
	public string? DBPAKFOCKGI
	{
		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000880")]
	[Cpp2IlInjected.Address(RVA = "0x7621100", Offset = "0x7620100", VA = "0x187621100", Slot = "5")]
	public virtual void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000881")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public CKHNAHHDNCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
[KGCDFDOGPOJ]
public class OJJIIHOGGNI : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000375")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000376")]
	public IReadOnlyList<BMAEBPGMEPF> HPFKGDDIMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000377")]
	public IReadOnlyList<CKHNAHHDNCP> HDDFMBIAMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000378")]
	public IReadOnlyList<OJJIIHOGGNI> MHMAJBGKNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000379")]
	public string? DBPAKFOCKGI
	{
		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600088C")]
	[Cpp2IlInjected.Address(RVA = "0x762A110", Offset = "0x7629110", VA = "0x18762A110", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600088D")]
	[Cpp2IlInjected.Address(RVA = "0x762A140", Offset = "0x7629140", VA = "0x18762A140")]
	public OJJIIHOGGNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
[KGCDFDOGPOJ]
public class CHJFIOKLHDP : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x40005D8")]
	public const string JBIGPCIDKDJ = "REPL_";

	[Cpp2IlInjected.Token(Token = "0x1700037A")]
	public string CMGKJAEFCGA
	{
		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037B")]
	public int NOEKEHBCCNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0xA6A6F0", Offset = "0xA696F0", VA = "0x180A6A6F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000892")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000893")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public CHJFIOKLHDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
[KGCDFDOGPOJ]
public class CKEIKLKOBKE : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700037C")]
	public int? OKAFGBBEFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037D")]
	public string? HACBKCHBAOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037E")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037F")]
	public string HHDOJPCILPE
	{
		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000380")]
	public List<CKEIKLKOBKE>? JAKCMLAGBHA
	{
		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000381")]
	public CHJFIOKLHDP? OFKHFDKFJPC
	{
		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008A0")]
	[Cpp2IlInjected.Address(RVA = "0x76210E0", Offset = "0x76200E0", VA = "0x1876210E0", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A1")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public CKEIKLKOBKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[KGCDFDOGPOJ]
public class FOJEKGBELPH : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000382")]
	public string JNBBHBIDKPK
	{
		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000383")]
	public string LKDDHJMEOEN
	{
		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008A6")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A7")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public FOJEKGBELPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
[KGCDFDOGPOJ]
public class KADHOADEOED : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000384")]
	public string CMGKJAEFCGA
	{
		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000385")]
	public OJJIIHOGGNI KBNHHNPHMBG
	{
		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000386")]
	public CKEIKLKOBKE? DIMONFJPPFN
	{
		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000387")]
	public List<CKEIKLKOBKE>? NOEMCFDKJCF
	{
		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000388")]
	public IReadOnlyList<BMAEBPGMEPF> BIHNEKPCLPA
	{
		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000389")]
	public IReadOnlyList<FOJEKGBELPH> JBEACDGFIFG
	{
		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038A")]
	public string? AKNIMEMCMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0xA674F0", Offset = "0xA664F0", VA = "0x180A674F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008B6")]
	[Cpp2IlInjected.Address(RVA = "0x7627300", Offset = "0x7626300", VA = "0x187627300", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B7")]
	[Cpp2IlInjected.Address(RVA = "0x7627390", Offset = "0x7626390", VA = "0x187627390")]
	public KADHOADEOED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
[KGCDFDOGPOJ]
public class JAMDEOPMLEI : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700038B")]
	public KGOJLHJNIOD<KADHOADEOED> IJBEHPGCOHL
	{
		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038C")]
	public decimal JKCJDKPLEOO
	{
		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0xD36D60", Offset = "0xD35D60", VA = "0x180D36D60")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0xF0BE40", Offset = "0xF0AE40", VA = "0x180F0BE40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008BC")]
	[Cpp2IlInjected.Address(RVA = "0x75284E0", Offset = "0x75274E0", VA = "0x1875284E0", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BD")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public JAMDEOPMLEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
public enum BNPBPJMHLPI
{
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	Empty,
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	Low,
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	Good
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
[KGCDFDOGPOJ]
public class NHOIAIMJPHM : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700038D")]
	public BNPBPJMHLPI KMHIGILFHOK
	{
		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(BNPBPJMHLPI);
		}
		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038E")]
	public DateTime FPIPDMHEFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0xDAD320", Offset = "0xDAC320", VA = "0x180DAD320")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008C2")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C3")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public NHOIAIMJPHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
[KGCDFDOGPOJ]
public class DEHMPFFKIBP : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700038F")]
	public BNPBPJMHLPI LHPCFKAHDJC
	{
		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(BNPBPJMHLPI);
		}
		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000390")]
	public float PFNGGJIIHOO
	{
		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0xE3ABF0", Offset = "0xE39BF0", VA = "0x180E3ABF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0xE3AD30", Offset = "0xE39D30", VA = "0x180E3AD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008C8")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C9")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public DEHMPFFKIBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
[KGCDFDOGPOJ]
public class HHANLBFAHIP : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000391")]
	public BNPBPJMHLPI KMHIGILFHOK
	{
		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
		[CompilerGenerated]
		get
		{
			return default(BNPBPJMHLPI);
		}
		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000392")]
	public DateTime FPIPDMHEFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0xDAD320", Offset = "0xDAC320", VA = "0x180DAD320")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000393")]
	public BNPBPJMHLPI LHPCFKAHDJC
	{
		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return default(BNPBPJMHLPI);
		}
		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAAD190", VA = "0x180AAE190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000394")]
	public float PFNGGJIIHOO
	{
		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0xAADEE0", Offset = "0xAACEE0", VA = "0x180AADEE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0xAAEDA0", Offset = "0xAADDA0", VA = "0x180AAEDA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000395")]
	public BNPBPJMHLPI FNHPFBLDGAI
	{
		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0xA655B0", Offset = "0xA645B0", VA = "0x180A655B0")]
		[CompilerGenerated]
		get
		{
			return default(BNPBPJMHLPI);
		}
		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0xA655C0", Offset = "0xA645C0", VA = "0x180A655C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000396")]
	public float NKDDHONFEMH
	{
		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0xD54030", Offset = "0xD53030", VA = "0x180D54030")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0xD54040", Offset = "0xD53040", VA = "0x180D54040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008D6")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D7")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public HHANLBFAHIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
[KGCDFDOGPOJ]
public class PGCCEHPFAPF : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000397")]
	public TimeSpan PNPHGOECEGH
	{
		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000398")]
	public TimeSpan BJIMIPGDEKB
	{
		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0xDAD320", Offset = "0xDAC320", VA = "0x180DAD320")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008DC")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DD")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public PGCCEHPFAPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
[KGCDFDOGPOJ]
public class CEONNKHDNPG : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000399")]
	public List<string> BDJLGAHJNPH
	{
		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008E0")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E1")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public CEONNKHDNPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
[KGCDFDOGPOJ]
public class HKDPENNHCLD : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700039A")]
	public string? MANJBECCIEI
	{
		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039B")]
	public string DGLJDCBGKEO
	{
		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039C")]
	public string ELIEPKMFMDB
	{
		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039D")]
	public string ODIGKKJCMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039E")]
	public string? NKCMICPDOJF
	{
		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039F")]
	public bool JJDJMPIMKEB
	{
		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0xABB4F0", Offset = "0xABA4F0", VA = "0x180ABB4F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0xABBF50", Offset = "0xABAF50", VA = "0x180ABBF50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008EE")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EF")]
	[Cpp2IlInjected.Address(RVA = "0x7624B60", Offset = "0x7623B60", VA = "0x187624B60")]
	public HKDPENNHCLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
public class ADFPNAMGPEC
{
	[Cpp2IlInjected.Token(Token = "0x170003A0")]
	public decimal PHPMJCNMALC
	{
		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE60", Offset = "0xE5DE60", VA = "0x180E5EE60")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE70", Offset = "0xE5DE70", VA = "0x180E5EE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008F2")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public ADFPNAMGPEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
[KGCDFDOGPOJ]
public class KNKBLKHAIDL : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170003A1")]
	public JFNAKFCGDAO DIMPKACKBJO
	{
		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A2")]
	public BNPBPJMHLPI OOMGGPJEHJA
	{
		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
		[CompilerGenerated]
		get
		{
			return default(BNPBPJMHLPI);
		}
		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0xA6A6F0", Offset = "0xA696F0", VA = "0x180A6A6F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A3")]
	public long? MJEFBKOCCPE
	{
		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0xE60260", Offset = "0xE5F260", VA = "0x180E60260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0xF3B430", Offset = "0xF3A430", VA = "0x180F3B430")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A4")]
	public DateTime? KFCMPJFJKBI
	{
		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0xF0CDA0", Offset = "0xF0BDA0", VA = "0x180F0CDA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0xF0D8F0", Offset = "0xF0C8F0", VA = "0x180F0D8F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A5")]
	public long? GGIFHJIMDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x10064E0", Offset = "0x10054E0", VA = "0x1810064E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x1006510", Offset = "0x1005510", VA = "0x181006510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008FD")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FE")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public KNKBLKHAIDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
[KGCDFDOGPOJ]
public class GBOKKONFEFG : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170003A6")]
	public List<IBOADFBIPJF> HFFCEACHNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000901")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000902")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public GBOKKONFEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
[KGCDFDOGPOJ]
public class IBOADFBIPJF : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170003A7")]
	public string BAAMMHMADOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000905")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000906")]
	[Cpp2IlInjected.Address(RVA = "0x7625100", Offset = "0x7624100", VA = "0x187625100")]
	public IBOADFBIPJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015B")]
[KGCDFDOGPOJ]
public class JPLLGHHHFIE : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170003A8")]
	public List<ELLDOKHIDOP> GIMANHHDALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A9")]
	public string EMIIENBIJOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600090B")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090C")]
	[Cpp2IlInjected.Address(RVA = "0x76272A0", Offset = "0x76262A0", VA = "0x1876272A0")]
	public JPLLGHHHFIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
[KGCDFDOGPOJ]
public class ELLDOKHIDOP : PDDMBELEHHJ
{
	[Cpp2IlInjected.Token(Token = "0x170003AA")]
	public string CMGKJAEFCGA
	{
		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AB")]
	public string OAMNBLGFEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AC")]
	public string PFIIBPNOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AD")]
	public string PDHGAHGALML
	{
		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AE")]
	public DateTime POBHENPHPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0xA68450", Offset = "0xA67450", VA = "0x180A68450")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0xA6BBE0", Offset = "0xA6ABE0", VA = "0x180A6BBE0")]
	public ELLDOKHIDOP(string PBJHGGBBAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000918")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void CPOBHIECLEN()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200015D")]
public class HLGNEFPMHEK
{
	[Cpp2IlInjected.Token(Token = "0x6000919")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public HLGNEFPMHEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091A")]
	[Cpp2IlInjected.Address(RVA = "0x7343BF0", Offset = "0x7342BF0", VA = "0x187343BF0")]
	public static string KDHGMCJJDJH(byte[] APPLLJJBAIJ, byte[] ONHOGPDMCCD)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
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
