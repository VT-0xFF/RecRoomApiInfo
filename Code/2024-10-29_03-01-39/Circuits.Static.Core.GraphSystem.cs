using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
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
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
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
		[Cpp2IlInjected.Address(RVA = "0x2314290", Offset = "0x2313290", VA = "0x182314290")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0550", Offset = "0x8DF550", VA = "0x1808E0550")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E0590", Offset = "0x8DF590", VA = "0x1808E0590")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct PLIEHNNCCHO : IEnumerator<NLABAOACMJG>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private OCCFKHHMDAK<DJNGCDCAKKJ>.GIPLKDPJMLC ILLGBOOALGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private CHILJMMPDOD<DJNGCDCAKKJ, GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>> HCKJAPKEBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>.CMGDFJODKDB BFOCFMAHNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool GOIGIJACNJG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NLABAOACMJG OEJFPPMIFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2318010", Offset = "0x2317010", VA = "0x182318010", Slot = "4")]
		get
		{
			return default(NLABAOACMJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2317F50", Offset = "0x2316F50", VA = "0x182317F50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2317FA0", Offset = "0x2316FA0", VA = "0x182317FA0")]
	internal PLIEHNNCCHO([In] OCCFKHHMDAK<DJNGCDCAKKJ>.GIPLKDPJMLC HOMGKNKFIAF, [In] CHILJMMPDOD<DJNGCDCAKKJ, GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>> JEBADBLEBMC, [In] GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>.CMGDFJODKDB GDNIFIHKCBK, bool IFFNHKJPBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2317D50", Offset = "0x2316D50", VA = "0x182317D50", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2317F10", Offset = "0x2316F10", VA = "0x182317F10", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2317CE0", Offset = "0x2316CE0", VA = "0x182317CE0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OEDEDNCPFAB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal PHHCGHAFDKP EOIHPOHDGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal HBKNGIIEEBC KLGLAGBBFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal HGPCDHEODFN CLIKPBDHMOF;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x23173D0", Offset = "0x23163D0", VA = "0x1823173D0")]
	internal OEDEDNCPFAB([In] PHHCGHAFDKP GHPOJDLNEJJ, [In] HBKNGIIEEBC OEOCEOHLKPP, [In] HGPCDHEODFN NJNCDHGKCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2314D70", Offset = "0x2313D70", VA = "0x182314D70")]
	public static OEDEDNCPFAB EJLELCHFLID()
	{
		return default(OEDEDNCPFAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2314790", Offset = "0x2313790", VA = "0x182314790", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x23150E0", Offset = "0x23140E0", VA = "0x1823150E0")]
	public readonly KDALNPOEFPI EKFEJLFJOKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2316610", Offset = "0x2315610", VA = "0x182316610")]
	public void NBOFIEGHMPI(FCEODKAEDJI<DJNGCDCAKKJ> KKKMPPFHMEK, FCEODKAEDJI<IDMOAGMBHCD> BJCFAMGFGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2314360", Offset = "0x2313360", VA = "0x182314360")]
	public FCEODKAEDJI<IDMOAGMBHCD> AECKDFCEPMA(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI)
	{
		return default(FCEODKAEDJI<IDMOAGMBHCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2315190", Offset = "0x2314190", VA = "0x182315190")]
	public FCEODKAEDJI<IMDHLBELCNK> GOBHGKMBNGO()
	{
		return default(FCEODKAEDJI<IMDHLBELCNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x23145D0", Offset = "0x23135D0", VA = "0x1823145D0")]
	public FCEODKAEDJI<DJNGCDCAKKJ> CEDBMDMPPGK(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI)
	{
		return default(FCEODKAEDJI<DJNGCDCAKKJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2315520", Offset = "0x2314520", VA = "0x182315520")]
	public readonly bool IOJLMCBJNNM(FCEODKAEDJI<DJNGCDCAKKJ> KKKMPPFHMEK, FCEODKAEDJI<IDMOAGMBHCD> BJCFAMGFGNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2315F80", Offset = "0x2314F80", VA = "0x182315F80")]
	public readonly PCENGIHBNCF<NLABAOACMJG, PLIEHNNCCHO> LCAHEKPIBHH()
	{
		return default(PCENGIHBNCF<NLABAOACMJG, PLIEHNNCCHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2316520", Offset = "0x2315520", VA = "0x182316520")]
	public readonly PLIEHNNCCHO MHKOGIJFHAN()
	{
		return default(PLIEHNNCCHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2316160", Offset = "0x2315160", VA = "0x182316160")]
	public readonly PCENGIHBNCF<FCEODKAEDJI<IDMOAGMBHCD>, OCCFKHHMDAK<IDMOAGMBHCD>.GIPLKDPJMLC> LMONIHBNEMI()
	{
		return default(PCENGIHBNCF<FCEODKAEDJI<IDMOAGMBHCD>, OCCFKHHMDAK<IDMOAGMBHCD>.GIPLKDPJMLC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2315EE0", Offset = "0x2314EE0", VA = "0x182315EE0")]
	public readonly FCEODKAEDJI<IDMOAGMBHCD> KOONBMFIPHK(FCEODKAEDJI<DJNGCDCAKKJ> LKEMMOGOMAB, int KLCJBCDLHHJ)
	{
		return default(FCEODKAEDJI<IDMOAGMBHCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2316FC0", Offset = "0x2315FC0", VA = "0x182316FC0")]
	public readonly PCENGIHBNCF<FCEODKAEDJI<OOEPOIHBEEC>, MMMDKFFGHAA<OOEPOIHBEEC>> OPDPBFKFFEL(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI)
	{
		return default(PCENGIHBNCF<FCEODKAEDJI<OOEPOIHBEEC>, MMMDKFFGHAA<OOEPOIHBEEC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2315730", Offset = "0x2314730", VA = "0x182315730")]
	public readonly MMMDKFFGHAA<OOEPOIHBEEC> JBGDKICCPLK(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI)
	{
		return default(MMMDKFFGHAA<OOEPOIHBEEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2314670", Offset = "0x2313670", VA = "0x182314670")]
	public readonly FCEODKAEDJI<IDMOAGMBHCD> CEKFKCEENFL(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI, FCEODKAEDJI<OOEPOIHBEEC> KLCJBCDLHHJ)
	{
		return default(FCEODKAEDJI<IDMOAGMBHCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2314C90", Offset = "0x2313C90", VA = "0x182314C90")]
	public readonly PCENGIHBNCF<FCEODKAEDJI<IDMOAGMBHCD>, BKPDCNAKJLA> EDOBFBGOIJL(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI)
	{
		return default(PCENGIHBNCF<FCEODKAEDJI<IDMOAGMBHCD>, BKPDCNAKJLA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2316430", Offset = "0x2315430", VA = "0x182316430")]
	public readonly BKPDCNAKJLA MHIOJGKLIKL(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI)
	{
		return default(BKPDCNAKJLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2315470", Offset = "0x2314470", VA = "0x182315470")]
	public readonly GAPOMHJCLDG<FCEODKAEDJI<IDMOAGMBHCD>, GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>.CMGDFJODKDB> IEJDPADJHKO(FCEODKAEDJI<DJNGCDCAKKJ> LKEMMOGOMAB)
	{
		return default(GAPOMHJCLDG<FCEODKAEDJI<IDMOAGMBHCD>, GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>.CMGDFJODKDB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2315B00", Offset = "0x2314B00", VA = "0x182315B00")]
	public readonly GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>.CMGDFJODKDB JOJOBEDKKJK(FCEODKAEDJI<DJNGCDCAKKJ> LKEMMOGOMAB)
	{
		return default(GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>.CMGDFJODKDB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2316380", Offset = "0x2315380", VA = "0x182316380")]
	public readonly GAPOMHJCLDG<FCEODKAEDJI<IDMOAGMBHCD>, GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>.CMGDFJODKDB> MHFEPEAONAH(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI)
	{
		return default(GAPOMHJCLDG<FCEODKAEDJI<IDMOAGMBHCD>, GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>.CMGDFJODKDB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2317050", Offset = "0x2316050", VA = "0x182317050")]
	public readonly GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>.CMGDFJODKDB OPEBPHOEHLD(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI)
	{
		return default(GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>.CMGDFJODKDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x23147C0", Offset = "0x23137C0", VA = "0x1823147C0")]
	public readonly PCENGIHBNCF<FCEODKAEDJI<IMDHLBELCNK>, EDJJFAADKOO> EBKDJNDDNMA(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI)
	{
		return default(PCENGIHBNCF<FCEODKAEDJI<IMDHLBELCNK>, EDJJFAADKOO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2315290", Offset = "0x2314290", VA = "0x182315290")]
	public readonly EDJJFAADKOO HGHLEDBBHLN(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI)
	{
		return default(EDJJFAADKOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2315400", Offset = "0x2314400", VA = "0x182315400")]
	public readonly PCENGIHBNCF<FCEODKAEDJI<IMDHLBELCNK>, OCCFKHHMDAK<IMDHLBELCNK>.GIPLKDPJMLC> HOIPDHDIMDN()
	{
		return default(PCENGIHBNCF<FCEODKAEDJI<IMDHLBELCNK>, OCCFKHHMDAK<IMDHLBELCNK>.GIPLKDPJMLC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2317100", Offset = "0x2316100", VA = "0x182317100")]
	public readonly int PDCDPJIEMCE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x23161D0", Offset = "0x23151D0", VA = "0x1823161D0")]
	public readonly int LNEBKACIGPN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2316F40", Offset = "0x2315F40", VA = "0x182316F40")]
	public readonly int OOIDMPOFFNI(FCEODKAEDJI<DJNGCDCAKKJ> LKEMMOGOMAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2314400", Offset = "0x2313400", VA = "0x182314400")]
	public readonly int BEOOMHLPDLL(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2316210", Offset = "0x2315210", VA = "0x182316210")]
	public readonly int MFEBJMCNDGE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x23165D0", Offset = "0x23155D0", VA = "0x1823165D0")]
	public readonly int NBIIIGDJPID()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2316710", Offset = "0x2315710", VA = "0x182316710")]
	public readonly int NHJFADGNIBI(FCEODKAEDJI<IDMOAGMBHCD> MMPLNFLCEPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2316EC0", Offset = "0x2315EC0", VA = "0x182316EC0")]
	public readonly int OKJKBMDGPNO(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x23162E0", Offset = "0x23152E0", VA = "0x1823162E0")]
	public readonly FCEODKAEDJI<DJNGCDCAKKJ> MHECOIJOKOL(FCEODKAEDJI<IDMOAGMBHCD> MMPLNFLCEPN, int HDFKMLJJHIN)
	{
		return default(FCEODKAEDJI<DJNGCDCAKKJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2316250", Offset = "0x2315250", VA = "0x182316250")]
	public readonly PCENGIHBNCF<FCEODKAEDJI<MHCMNEOALJM>, MMMDKFFGHAA<MHCMNEOALJM>> MFKKPOBNDFD(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI)
	{
		return default(PCENGIHBNCF<FCEODKAEDJI<MHCMNEOALJM>, MMMDKFFGHAA<MHCMNEOALJM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x23172B0", Offset = "0x23162B0", VA = "0x1823172B0")]
	public readonly MMMDKFFGHAA<MHCMNEOALJM> PEMAKOMCGNH(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI)
	{
		return default(MMMDKFFGHAA<MHCMNEOALJM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2314480", Offset = "0x2313480", VA = "0x182314480")]
	public readonly FCEODKAEDJI<DJNGCDCAKKJ> BGDGNKJCONA(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI, FCEODKAEDJI<MHCMNEOALJM> HDFKMLJJHIN)
	{
		return default(FCEODKAEDJI<DJNGCDCAKKJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2315E40", Offset = "0x2314E40", VA = "0x182315E40")]
	public readonly GAPOMHJCLDG<FCEODKAEDJI<DJNGCDCAKKJ>, GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>>.CMGDFJODKDB> KLHKGHBDCJP(FCEODKAEDJI<IDMOAGMBHCD> MMPLNFLCEPN)
	{
		return default(GAPOMHJCLDG<FCEODKAEDJI<DJNGCDCAKKJ>, GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>>.CMGDFJODKDB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x23160C0", Offset = "0x23150C0", VA = "0x1823160C0")]
	public readonly GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>>.CMGDFJODKDB LDPPADJKOCM(FCEODKAEDJI<IDMOAGMBHCD> MMPLNFLCEPN)
	{
		return default(GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>>.CMGDFJODKDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2315BB0", Offset = "0x2314BB0", VA = "0x182315BB0")]
	public readonly LBEDAMFKGEE KBIPBHDGFJC(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI)
	{
		return default(LBEDAMFKGEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2315390", Offset = "0x2314390", VA = "0x182315390")]
	public readonly OCCFKHHMDAK<DJNGCDCAKKJ>.GIPLKDPJMLC HKPIDNKEBBO()
	{
		return default(OCCFKHHMDAK<DJNGCDCAKKJ>.GIPLKDPJMLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2314520", Offset = "0x2313520", VA = "0x182314520")]
	public readonly GAPOMHJCLDG<FCEODKAEDJI<DJNGCDCAKKJ>, GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>>.CMGDFJODKDB> BNBMLJDKPNP(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI)
	{
		return default(GAPOMHJCLDG<FCEODKAEDJI<DJNGCDCAKKJ>, GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>>.CMGDFJODKDB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2316790", Offset = "0x2315790", VA = "0x182316790")]
	public readonly GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>>.CMGDFJODKDB NKJCKFPKEIF(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI)
	{
		return default(GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>>.CMGDFJODKDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x23156B0", Offset = "0x23146B0", VA = "0x1823156B0")]
	public readonly FCEODKAEDJI<IMDHLBELCNK> IPBLCHFFPBA(FCEODKAEDJI<IDMOAGMBHCD> MMPLNFLCEPN)
	{
		return default(FCEODKAEDJI<IMDHLBELCNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2314710", Offset = "0x2313710", VA = "0x182314710")]
	public readonly FCEODKAEDJI<IMDHLBELCNK> DBLPLGFDPIC(FCEODKAEDJI<DJNGCDCAKKJ> LKEMMOGOMAB)
	{
		return default(FCEODKAEDJI<IMDHLBELCNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2315DA0", Offset = "0x2314DA0", VA = "0x182315DA0")]
	public readonly bool KFFIMDKIOFB(FCEODKAEDJI<IDMOAGMBHCD> MMPLNFLCEPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2317310", Offset = "0x2316310", VA = "0x182317310")]
	public FCEODKAEDJI<IDMOAGMBHCD> PODNPEKBLNP(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI, FCEODKAEDJI<OOEPOIHBEEC> KLCJBCDLHHJ)
	{
		return default(FCEODKAEDJI<IDMOAGMBHCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2316E00", Offset = "0x2315E00", VA = "0x182316E00")]
	public FCEODKAEDJI<DJNGCDCAKKJ> OGCEEJHLJAD(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI, FCEODKAEDJI<MHCMNEOALJM> HDFKMLJJHIN)
	{
		return default(FCEODKAEDJI<DJNGCDCAKKJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2314D50", Offset = "0x2313D50", VA = "0x182314D50")]
	public readonly bool EGGFOFFLGDO(FCEODKAEDJI<IDMOAGMBHCD> MMPLNFLCEPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2317290", Offset = "0x2316290", VA = "0x182317290")]
	public readonly bool PDLHKGIKHIN(FCEODKAEDJI<DJNGCDCAKKJ> LKEMMOGOMAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2314B90", Offset = "0x2313B90", VA = "0x182314B90")]
	public void EDILDINBMMN(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI, FCEODKAEDJI<OOEPOIHBEEC> HIOIHKGNKBB, FCEODKAEDJI<OOEPOIHBEEC> FLGJDMEKLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2315CA0", Offset = "0x2314CA0", VA = "0x182315CA0")]
	public void KDDJACBEMCJ(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI, FCEODKAEDJI<MHCMNEOALJM> IBKAIDBBNHN, FCEODKAEDJI<MHCMNEOALJM> HNDMOBPGGEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2315DF0", Offset = "0x2314DF0", VA = "0x182315DF0")]
	public readonly bool KGMEDFPGKPH(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2314310", Offset = "0x2313310", VA = "0x182314310")]
	public readonly bool ACHEEPLCLKI(FCEODKAEDJI<DJNGCDCAKKJ> LKEMMOGOMAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2315790", Offset = "0x2314790", VA = "0x182315790")]
	public void JMJFHMGNJFK(FCEODKAEDJI<DJNGCDCAKKJ> KKKMPPFHMEK, FCEODKAEDJI<IDMOAGMBHCD> BJCFAMGFGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2315890", Offset = "0x2314890", VA = "0x182315890")]
	public void JOHPPFFCMNE(FCEODKAEDJI<IDMOAGMBHCD> MMPLNFLCEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2316840", Offset = "0x2315840", VA = "0x182316840")]
	public void NLNEPGBDDNI(FCEODKAEDJI<IMDHLBELCNK> FEPPDLNKELI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2314920", Offset = "0x2313920", VA = "0x182314920")]
	public void ECOFNAHOMCO(FCEODKAEDJI<DJNGCDCAKKJ> LKEMMOGOMAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class AIDBCELNKOA
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20")]
	public static OCCFKHHMDAK<IDMOAGMBHCD> CJCLHFPBAOM([In] this OEDEDNCPFAB GFJPFDOHONG)
	{
		return default(OCCFKHHMDAK<IDMOAGMBHCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2310A50", Offset = "0x230FA50", VA = "0x182310A50")]
	public static OCCFKHHMDAK<DJNGCDCAKKJ> OABFGHDPIDJ([In] this OEDEDNCPFAB GFJPFDOHONG)
	{
		return default(OCCFKHHMDAK<DJNGCDCAKKJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2310A40", Offset = "0x230FA40", VA = "0x182310A40")]
	public static OCCFKHHMDAK<IMDHLBELCNK> LJINFDABBBC([In] this OEDEDNCPFAB GFJPFDOHONG)
	{
		return default(OCCFKHHMDAK<IMDHLBELCNK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal struct PHHCGHAFDKP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public OCCFKHHMDAK<IDMOAGMBHCD> CAGDECEHCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public CHILJMMPDOD<IDMOAGMBHCD, FCEODKAEDJI<IMDHLBELCNK>> OFMIMOHBICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public CHILJMMPDOD<IDMOAGMBHCD, GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>>> HBLJCINIKBJ;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x23119C0", Offset = "0x23109C0", VA = "0x1823119C0")]
	public PHHCGHAFDKP([In] OCCFKHHMDAK<IDMOAGMBHCD> BNCDBCNPBHL, [In] CHILJMMPDOD<IDMOAGMBHCD, FCEODKAEDJI<IMDHLBELCNK>> NJNCDHGKCML, [In] CHILJMMPDOD<IDMOAGMBHCD, GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>>> OEOCEOHLKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2317950", Offset = "0x2316950", VA = "0x182317950")]
	public static PHHCGHAFDKP EJLELCHFLID()
	{
		return default(PHHCGHAFDKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x23177B0", Offset = "0x23167B0", VA = "0x1823177B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2317A30", Offset = "0x2316A30", VA = "0x182317A30")]
	public readonly NBKAALHGNND EKFEJLFJOKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x23174B0", Offset = "0x23164B0", VA = "0x1823174B0")]
	public FCEODKAEDJI<IDMOAGMBHCD> CMADBBEBGIC(FCEODKAEDJI<IMDHLBELCNK> CHMIAHGMJKI)
	{
		return default(FCEODKAEDJI<IDMOAGMBHCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x23176D0", Offset = "0x23166D0", VA = "0x1823176D0")]
	public void DIPKALJLHOB(FCEODKAEDJI<IDMOAGMBHCD> JHCIODFGPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2317570", Offset = "0x2316570", VA = "0x182317570")]
	[CompilerGenerated]
	internal static GKDFJLCLHAL DEDKAJLEPNP([In] GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>> GFJPFDOHONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct BKPDCNAKJLA : IEnumerator<FCEODKAEDJI<IDMOAGMBHCD>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>>.CMGDFJODKDB ILLGBOOALGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>.CMGDFJODKDB NLLFJBCMDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CHILJMMPDOD<DJNGCDCAKKJ, GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>> MKIGIOBECLG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public FCEODKAEDJI<IDMOAGMBHCD> OEJFPPMIFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2310D30", Offset = "0x230FD30", VA = "0x182310D30", Slot = "4")]
		get
		{
			return default(FCEODKAEDJI<IDMOAGMBHCD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2310C60", Offset = "0x230FC60", VA = "0x182310C60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2310CD0", Offset = "0x230FCD0", VA = "0x182310CD0")]
	internal BKPDCNAKJLA([In] GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>>.CMGDFJODKDB HOMGKNKFIAF, [In] GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>.CMGDFJODKDB GPFDDPKOIJO, [In] CHILJMMPDOD<DJNGCDCAKKJ, GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>> JOEHOAAMKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2310AC0", Offset = "0x230FAC0", VA = "0x182310AC0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2310C00", Offset = "0x230FC00", VA = "0x182310C00", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2310A60", Offset = "0x230FA60", VA = "0x182310A60", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal struct HGPCDHEODFN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public OCCFKHHMDAK<IMDHLBELCNK> CAGDECEHCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public CHILJMMPDOD<IMDHLBELCNK, GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>> IJCKOKHAOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public CHILJMMPDOD<IMDHLBELCNK, GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>>> HBLJCINIKBJ;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x23119C0", Offset = "0x23109C0", VA = "0x1823119C0")]
	public HGPCDHEODFN([In] OCCFKHHMDAK<IMDHLBELCNK> BNCDBCNPBHL, [In] CHILJMMPDOD<IMDHLBELCNK, GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>> GHPOJDLNEJJ, [In] CHILJMMPDOD<IMDHLBELCNK, GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>>> OEOCEOHLKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2312050", Offset = "0x2311050", VA = "0x182312050")]
	public static HGPCDHEODFN EJLELCHFLID()
	{
		return default(HGPCDHEODFN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2311D80", Offset = "0x2310D80", VA = "0x182311D80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2312130", Offset = "0x2311130", VA = "0x182312130")]
	public readonly FNNJOJBMFKM EKFEJLFJOKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2311B90", Offset = "0x2310B90", VA = "0x182311B90")]
	public FCEODKAEDJI<IMDHLBELCNK> CMADBBEBGIC([In] GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>> GHPOJDLNEJJ, [In] GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>> OEOCEOHLKPP)
	{
		return default(FCEODKAEDJI<IMDHLBELCNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2311C40", Offset = "0x2310C40", VA = "0x182311C40")]
	public void DIPKALJLHOB(FCEODKAEDJI<IMDHLBELCNK> JHCIODFGPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2312410", Offset = "0x2311410", VA = "0x182312410")]
	[CompilerGenerated]
	internal static PBPELJJDGKH GEOBJNHJNDN([In] GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>> GFJPFDOHONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2311A30", Offset = "0x2310A30", VA = "0x182311A30")]
	[CompilerGenerated]
	internal static LBABLCOGGFL ALKGMLMHPGH([In] GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>> GFJPFDOHONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct EDJJFAADKOO : IEnumerator<FCEODKAEDJI<IMDHLBELCNK>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private BKPDCNAKJLA AJMHFMDLLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly CHILJMMPDOD<IDMOAGMBHCD, FCEODKAEDJI<IMDHLBELCNK>> CALPOCAEOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private LBEDAMFKGEE AEPJGMPLAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly CHILJMMPDOD<DJNGCDCAKKJ, FCEODKAEDJI<IMDHLBELCNK>> LOBLNHHBDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private bool BAGBPNKDDEK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public readonly FCEODKAEDJI<IMDHLBELCNK> OEJFPPMIFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2311010", Offset = "0x2310010", VA = "0x182311010", Slot = "4")]
		get
		{
			return default(FCEODKAEDJI<IMDHLBELCNK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2310F10", Offset = "0x230FF10", VA = "0x182310F10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2310F60", Offset = "0x230FF60", VA = "0x182310F60")]
	internal EDJJFAADKOO([In] BKPDCNAKJLA GDCCPJKMAHE, [In] CHILJMMPDOD<IDMOAGMBHCD, FCEODKAEDJI<IMDHLBELCNK>> CCCGCGNMIKF, [In] LBEDAMFKGEE BIJIEODAKPH, [In] CHILJMMPDOD<DJNGCDCAKKJ, FCEODKAEDJI<IMDHLBELCNK>> BFBGIDOOGCC, bool GEIBPLEDPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2310E10", Offset = "0x230FE10", VA = "0x182310E10", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2310E60", Offset = "0x230FE60", VA = "0x182310E60", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2310D70", Offset = "0x230FD70", VA = "0x182310D70", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal struct HBKNGIIEEBC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public OCCFKHHMDAK<DJNGCDCAKKJ> CAGDECEHCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public CHILJMMPDOD<DJNGCDCAKKJ, FCEODKAEDJI<IMDHLBELCNK>> OFMIMOHBICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public CHILJMMPDOD<DJNGCDCAKKJ, GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>> IJCKOKHAOAH;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x23119C0", Offset = "0x23109C0", VA = "0x1823119C0")]
	public HBKNGIIEEBC([In] OCCFKHHMDAK<DJNGCDCAKKJ> BNCDBCNPBHL, [In] CHILJMMPDOD<DJNGCDCAKKJ, FCEODKAEDJI<IMDHLBELCNK>> NJNCDHGKCML, [In] CHILJMMPDOD<DJNGCDCAKKJ, GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>> GHPOJDLNEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x23114D0", Offset = "0x23104D0", VA = "0x1823114D0")]
	public static HBKNGIIEEBC EJLELCHFLID()
	{
		return default(HBKNGIIEEBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2311330", Offset = "0x2310330", VA = "0x182311330", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x23115B0", Offset = "0x23105B0", VA = "0x1823115B0")]
	public readonly HEPPMLNIGAL EKFEJLFJOKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2311190", Offset = "0x2310190", VA = "0x182311190")]
	public FCEODKAEDJI<DJNGCDCAKKJ> CMADBBEBGIC(FCEODKAEDJI<IMDHLBELCNK> CHMIAHGMJKI)
	{
		return default(FCEODKAEDJI<DJNGCDCAKKJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2311250", Offset = "0x2310250", VA = "0x182311250")]
	public void DIPKALJLHOB(FCEODKAEDJI<DJNGCDCAKKJ> JHCIODFGPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2311860", Offset = "0x2310860", VA = "0x182311860")]
	[CompilerGenerated]
	internal static DOLBEPKGJID IJCNNAFHBFD([In] GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>> GFJPFDOHONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct LBEDAMFKGEE : IEnumerator<FCEODKAEDJI<DJNGCDCAKKJ>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>.CMGDFJODKDB JIAIFOKCCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>>.CMGDFJODKDB JPMNFNGHJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly CHILJMMPDOD<IDMOAGMBHCD, GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>>> LIJLBOLPGLG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FCEODKAEDJI<DJNGCDCAKKJ> OEJFPPMIFNH
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2313960", Offset = "0x2312960", VA = "0x182313960", Slot = "4")]
		get
		{
			return default(FCEODKAEDJI<DJNGCDCAKKJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x23138F0", Offset = "0x23128F0", VA = "0x1823138F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2310CD0", Offset = "0x230FCD0", VA = "0x182310CD0")]
	internal LBEDAMFKGEE([In] GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>.CMGDFJODKDB KCEDFBMNHEF, [In] GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>>.CMGDFJODKDB FNJGJILJIMM, [In] CHILJMMPDOD<IDMOAGMBHCD, GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>>> CDKKGOLKHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2313750", Offset = "0x2312750", VA = "0x182313750", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2313890", Offset = "0x2312890", VA = "0x182313890", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x23136F0", Offset = "0x23126F0", VA = "0x1823136F0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal static class LOJCEIGEBCM
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2313E00", Offset = "0x2312E00", VA = "0x182313E00")]
	public static HGPCDHEODFN OGCNNFLPKKP(this FNNJOJBMFKM GFJPFDOHONG)
	{
		return default(HGPCDHEODFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x23139A0", Offset = "0x23129A0", VA = "0x1823139A0")]
	[CompilerGenerated]
	internal static GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>> IGDHFIFDNPL(PBPELJJDGKH GFJPFDOHONG)
	{
		return default(GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2313BD0", Offset = "0x2312BD0", VA = "0x182313BD0")]
	[CompilerGenerated]
	internal static GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>> NKECAHCAKNL(LBABLCOGGFL GFJPFDOHONG)
	{
		return default(GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class INHKPDIBFAE
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2312C30", Offset = "0x2311C30", VA = "0x182312C30")]
	public static OEDEDNCPFAB OGCNNFLPKKP(this KDALNPOEFPI GFJPFDOHONG)
	{
		return default(OEDEDNCPFAB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal static class HOMOFCPOFPH
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x23127A0", Offset = "0x23117A0", VA = "0x1823127A0")]
	public static PHHCGHAFDKP OGCNNFLPKKP(this NBKAALHGNND GFJPFDOHONG)
	{
		return default(PHHCGHAFDKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2312570", Offset = "0x2311570", VA = "0x182312570")]
	[CompilerGenerated]
	internal static GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>> IHMLFKIPMPI(GKDFJLCLHAL GFJPFDOHONG)
	{
		return default(GJHCMIKLJBB<FCEODKAEDJI<DJNGCDCAKKJ>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal static class KFBGJMHOHNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2313260", Offset = "0x2312260", VA = "0x182313260")]
	public static HBKNGIIEEBC OGCNNFLPKKP(this HEPPMLNIGAL GFJPFDOHONG)
	{
		return default(HBKNGIIEEBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2313030", Offset = "0x2312030", VA = "0x182313030")]
	[CompilerGenerated]
	internal static GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>> HFOBNNLAAGF(DOLBEPKGJID GFJPFDOHONG)
	{
		return default(GJHCMIKLJBB<FCEODKAEDJI<IDMOAGMBHCD>>);
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
