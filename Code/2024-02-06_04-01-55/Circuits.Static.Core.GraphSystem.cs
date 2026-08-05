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
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1D4FA00", Offset = "0x1D4EE00", VA = "0x181D4FA00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CA360", Offset = "0x7C9760", VA = "0x1807CA360")]
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
		[Cpp2IlInjected.Address(RVA = "0x7CA3A0", Offset = "0x7C97A0", VA = "0x1807CA3A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BECFJGNOOPO<TMInput, TMOutput, TMNode> : IEnumerator<LELHOHFMKKF<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private JELAKGJOJFN<TMInput, TMOutput, TMNode> PELBPCPIPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private OAJMHNHHCIB<TMInput, TMOutput, TMNode> BIAJBJMIDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool LLILEFIBIEL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly LELHOHFMKKF<TMNode> PPPEJOJKNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x471AA30", Offset = "0x4719E30", VA = "0x18471AA30", Slot = "4")]
		get
		{
			return default(LELHOHFMKKF<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x471A8D0", Offset = "0x4719CD0", VA = "0x18471A8D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x471A960", Offset = "0x4719D60", VA = "0x18471A960")]
	internal BECFJGNOOPO([In] JELAKGJOJFN<TMInput, TMOutput, TMNode> FGMENFLKIHE, [In] OAJMHNHHCIB<TMInput, TMOutput, TMNode> KPBAKEPJCON, bool JLFCBABLNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x471A790", Offset = "0x4719B90", VA = "0x18471A790", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x471A850", Offset = "0x4719C50", VA = "0x18471A850", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x471A710", Offset = "0x4719B10", VA = "0x18471A710", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OGHNICOHKEL
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x27DBF00", Offset = "0x27DB300", VA = "0x1827DBF00")]
	public static BECFJGNOOPO<TMInput, TMOutput, TMNode> CPLKLKACALP<TMInput, TMOutput, TMNode>([In] GJMONNNAFBC<TMInput, TMOutput, TMNode> HMCKLMCEECJ, LELHOHFMKKF<TMNode> MADPFKENMIG)
	{
		return default(BECFJGNOOPO<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct OAJMHNHHCIB<TMInput, TMOutput, TMNode> : IEnumerator<LELHOHFMKKF<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DLJGBCHBPKA<LELHOHFMKKF<TMOutput>>.NEMOJDLALBJ JCIMDNAKHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private DLJGBCHBPKA<LELHOHFMKKF<TMInput>>.NEMOJDLALBJ LGGPGIENFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly NBCPDKNCDAC<TMInput, TMOutput, TMNode> BPDHAMJMEOP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LELHOHFMKKF<TMInput> PPPEJOJKNAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3A24B90", Offset = "0x3A23F90", VA = "0x183A24B90", Slot = "4")]
		get
		{
			return default(LELHOHFMKKF<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3A24A60", Offset = "0x3A23E60", VA = "0x183A24A60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3A24B10", Offset = "0x3A23F10", VA = "0x183A24B10")]
	internal OAJMHNHHCIB([In] DLJGBCHBPKA<LELHOHFMKKF<TMOutput>>.NEMOJDLALBJ MHOHNKCFLNC, [In] DLJGBCHBPKA<LELHOHFMKKF<TMInput>>.NEMOJDLALBJ HKHNDNMGFEP, [In] NBCPDKNCDAC<TMInput, TMOutput, TMNode> PHGKKOHPNNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3A24890", Offset = "0x3A23C90", VA = "0x183A24890", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3A249F0", Offset = "0x3A23DF0", VA = "0x183A249F0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3A24820", Offset = "0x3A23C20", VA = "0x183A24820", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BHBBEDJIHIA
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x245E600", Offset = "0x245DA00", VA = "0x18245E600")]
	public static OAJMHNHHCIB<TMInput, TMOutput, TMNode> CPLKLKACALP<TMInput, TMOutput, TMNode>([In] GJMONNNAFBC<TMInput, TMOutput, TMNode> HMCKLMCEECJ, LELHOHFMKKF<TMNode> MADPFKENMIG)
	{
		return default(OAJMHNHHCIB<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct JELAKGJOJFN<TMInput, TMOutput, TMNode> : IEnumerator<LELHOHFMKKF<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private DLJGBCHBPKA<LELHOHFMKKF<TMInput>>.NEMOJDLALBJ AAFIPBGBNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private DLJGBCHBPKA<LELHOHFMKKF<TMOutput>>.NEMOJDLALBJ FOKPPCKPMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly ONNDFHIPHLM<TMInput, TMOutput, TMNode> MGAKJPAKPPK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LELHOHFMKKF<TMOutput> PPPEJOJKNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3A24B90", Offset = "0x3A23F90", VA = "0x183A24B90", Slot = "4")]
		get
		{
			return default(LELHOHFMKKF<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3A24A60", Offset = "0x3A23E60", VA = "0x183A24A60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3A24B10", Offset = "0x3A23F10", VA = "0x183A24B10")]
	internal JELAKGJOJFN([In] DLJGBCHBPKA<LELHOHFMKKF<TMInput>>.NEMOJDLALBJ NAHDGINHKLI, [In] DLJGBCHBPKA<LELHOHFMKKF<TMOutput>>.NEMOJDLALBJ AABNIDHOAHM, [In] ONNDFHIPHLM<TMInput, TMOutput, TMNode> EAELCGHJPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3A24890", Offset = "0x3A23C90", VA = "0x183A24890", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3A249F0", Offset = "0x3A23DF0", VA = "0x183A249F0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3A24820", Offset = "0x3A23C20", VA = "0x183A24820", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class LMDCHEDOBGP
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2739EF0", Offset = "0x27392F0", VA = "0x182739EF0")]
	public static JELAKGJOJFN<TMInput, TMOutput, TMNode> CPLKLKACALP<TMInput, TMOutput, TMNode>([In] GJMONNNAFBC<TMInput, TMOutput, TMNode> HMCKLMCEECJ, LELHOHFMKKF<TMNode> MADPFKENMIG)
	{
		return default(JELAKGJOJFN<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct GJMONNNAFBC<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public ONNDFHIPHLM<TMInput, TMOutput, TMNode> LPNIECGEGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NBCPDKNCDAC<TMInput, TMOutput, TMNode> KBAKOFJGELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public OGAHCHNHMHH<TMInput, TMOutput, TMNode> ACNGPLEIHKK;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3714470", Offset = "0x3713870", VA = "0x183714470")]
	internal GJMONNNAFBC([In] ONNDFHIPHLM<TMInput, TMOutput, TMNode> EAELCGHJPDI, [In] NBCPDKNCDAC<TMInput, TMOutput, TMNode> PHGKKOHPNNN, [In] OGAHCHNHMHH<TMInput, TMOutput, TMNode> NFNIOOIAHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x37141C0", Offset = "0x37135C0", VA = "0x1837141C0")]
	public static GJMONNNAFBC<TMInput?, TMOutput?, TMNode?> CPLKLKACALP()
	{
		return default(GJMONNNAFBC<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MENPGJKDNND
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x274C8E0", Offset = "0x274BCE0", VA = "0x18274C8E0")]
	public static NHKDKFMPAHC? ILCGODJBNBA<TMInput, TMOutput, TMNode>([In] this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x274CA30", Offset = "0x274BE30", VA = "0x18274CA30")]
	public static GJMONNNAFBC<TMInput?, TMOutput?, TMNode?> JCEFODEMOAF<TMInput, TMOutput, TMNode>(this NHKDKFMPAHC LOMPFKEACIP)
	{
		return default(GJMONNNAFBC<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x274C7A0", Offset = "0x274BBA0", VA = "0x18274C7A0")]
	public static void HJKKNDHGMPB<TMInput, TMOutput, TMNode>(this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x274C480", Offset = "0x274B880", VA = "0x18274C480")]
	public static void GGCHAHKJJND<TMInput, TMOutput, TMNode>(this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMOutput> CNIDDMNDOKF, LELHOHFMKKF<TMInput> JGFGPGBGCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x274C880", Offset = "0x274BC80", VA = "0x18274C880")]
	public static void IDNBNBLKKBC<TMInput, TMOutput, TMNode>(this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMOutput> CNIDDMNDOKF, LELHOHFMKKF<TMInput> JGFGPGBGCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x274C3B0", Offset = "0x274B7B0", VA = "0x18274C3B0")]
	public static bool GAMGGAAJPJM<TMInput, TMOutput, TMNode>([In] this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMOutput> CNIDDMNDOKF, LELHOHFMKKF<TMInput> JGFGPGBGCAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x274C710", Offset = "0x274BB10", VA = "0x18274C710")]
	public static LELHOHFMKKF<TMNode?> HENJMFCBFJC<TMNode, TMInput, TMOutput>(this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP)
	{
		return default(LELHOHFMKKF<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x274CE40", Offset = "0x274C240", VA = "0x18274CE40")]
	public static void JIEANJNKHCB<TMInput, TMOutput, TMNode>(this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> MADPFKENMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x274C9C0", Offset = "0x274BDC0", VA = "0x18274C9C0")]
	public static LELHOHFMKKF<TMInput?> JCDAGAJHINP<TMInput, TMOutput, TMNode>(this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> MADPFKENMIG)
	{
		return default(LELHOHFMKKF<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x274C800", Offset = "0x274BC00", VA = "0x18274C800")]
	public static LELHOHFMKKF<TMOutput?> IBOOJDJEKBJ<TMOutput, TMInput, TMNode>(this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> MADPFKENMIG)
	{
		return default(LELHOHFMKKF<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x274C4E0", Offset = "0x274B8E0", VA = "0x18274C4E0")]
	public static LELHOHFMKKF<TMInput?> GMPFFMKPDIC<TMInput, TMOutput, TMNode>(this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> MADPFKENMIG, int AHDNEIKOMIB)
	{
		return default(LELHOHFMKKF<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x274C130", Offset = "0x274B530", VA = "0x18274C130")]
	public static LELHOHFMKKF<TMOutput?> AJJEKIBAHIM<TMOutput, TMInput, TMNode>(this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> MADPFKENMIG, int AHDNEIKOMIB)
	{
		return default(LELHOHFMKKF<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x274C560", Offset = "0x274B960", VA = "0x18274C560")]
	public static void HAIGEMCLICA<TMInput, TMOutput, TMNode>(this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> MADPFKENMIG, int BPEMDINFAPH, int HPKIJPNLABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x274CDA0", Offset = "0x274C1A0", VA = "0x18274CDA0")]
	public static void JCHODONMFEK<TMInput, TMOutput, TMNode>(this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> MADPFKENMIG, int BPEMDINFAPH, int HPKIJPNLABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x274CF60", Offset = "0x274C360", VA = "0x18274CF60")]
	public static void NAPPDCLNLGF<TMInput, TMOutput, TMNode>(this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMInput> MIPIBMCBIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x274C260", Offset = "0x274B660", VA = "0x18274C260")]
	public static void CDHJPGOGNCM<TMInput, TMOutput, TMNode>(this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMOutput> KPOALPLEIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x86E470", Offset = "0x86D870", VA = "0x18086E470")]
	public static DNLJCIPGMCH<TMInput?> FKIJDPNLKKI<TMInput, TMOutput, TMNode>([In] this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP)
	{
		return default(DNLJCIPGMCH<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x274C870", Offset = "0x274BC70", VA = "0x18274C870")]
	public static DNLJCIPGMCH<TMOutput?> ICCNLEMPAJD<TMOutput, TMInput, TMNode>([In] this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP)
	{
		return default(DNLJCIPGMCH<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x274CF50", Offset = "0x274C350", VA = "0x18274CF50")]
	public static DNLJCIPGMCH<TMNode?> MDLGHGKECIG<TMNode, TMInput, TMOutput>([In] this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP)
	{
		return default(DNLJCIPGMCH<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x274C340", Offset = "0x274B740", VA = "0x18274C340")]
	public static OAJMHNHHCIB<TMInput?, TMOutput?, TMNode?> FCLEMGJLIJD<TMInput, TMOutput, TMNode>([In] this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> FNOGEAGAPLC)
	{
		return default(OAJMHNHHCIB<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x274C340", Offset = "0x274B740", VA = "0x18274C340")]
	public static JELAKGJOJFN<TMInput?, TMOutput?, TMNode?> FEGOKHMFLGE<TMInput, TMOutput, TMNode>([In] this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> FNOGEAGAPLC)
	{
		return default(JELAKGJOJFN<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x274C1B0", Offset = "0x274B5B0", VA = "0x18274C1B0")]
	public static BECFJGNOOPO<TMInput?, TMOutput?, TMNode?> BKHCHNCAIMD<TMInput, TMOutput, TMNode>([In] this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> FNOGEAGAPLC)
	{
		return default(BECFJGNOOPO<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x274C600", Offset = "0x274BA00", VA = "0x18274C600")]
	public static PHIPIOALAPA<LELHOHFMKKF<TMInput?>, OAJMHNHHCIB<TMInput?, TMOutput?, TMNode?>> HDNPHDNMJBD<TMInput, TMOutput, TMNode>([In] this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> FNOGEAGAPLC)
	{
		return default(PHIPIOALAPA<LELHOHFMKKF<TMInput>, OAJMHNHHCIB<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x274BFA0", Offset = "0x274B3A0", VA = "0x18274BFA0")]
	public static PHIPIOALAPA<LELHOHFMKKF<TMNode?>, BECFJGNOOPO<TMInput?, TMOutput?, TMNode?>> AGCEBOHGMMH<TMNode, TMInput, TMOutput>([In] this GJMONNNAFBC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> FNOGEAGAPLC)
	{
		return default(PHIPIOALAPA<LELHOHFMKKF<TMNode>, BECFJGNOOPO<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct ONNDFHIPHLM<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal DNLJCIPGMCH<TMInput> CIFGPMLAAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal LBJJCFEPAMD<TMInput, LELHOHFMKKF<TMNode>> OBOMFHLIHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal LBJJCFEPAMD<TMInput, DLJGBCHBPKA<LELHOHFMKKF<TMOutput>>> BPDHAMJMEOP;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3AD2010", Offset = "0x3AD1410", VA = "0x183AD2010")]
	internal ONNDFHIPHLM([In] DNLJCIPGMCH<TMInput> KACCELJHPBO, [In] LBJJCFEPAMD<TMInput, LELHOHFMKKF<TMNode>> NFNIOOIAHDN, [In] LBJJCFEPAMD<TMInput, DLJGBCHBPKA<LELHOHFMKKF<TMOutput>>> PHGKKOHPNNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3AD1DA0", Offset = "0x3AD11A0", VA = "0x183AD1DA0")]
	internal static ONNDFHIPHLM<TMInput, TMOutput, TMNode> CPLKLKACALP()
	{
		return default(ONNDFHIPHLM<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DNMEDJCLPMI
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2520550", Offset = "0x251F950", VA = "0x182520550")]
	internal static IEPEBIKELHC ILCGODJBNBA<TMInput, TMOutput, TMNode>([In] this ONNDFHIPHLM<TMInput, TMOutput, TMNode> LOMPFKEACIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2520AB0", Offset = "0x251FEB0", VA = "0x182520AB0")]
	internal static ONNDFHIPHLM<TMInput, TMOutput, TMNode> JCEFODEMOAF<TMInput, TMOutput, TMNode>(this IEPEBIKELHC LOMPFKEACIP)
	{
		return default(ONNDFHIPHLM<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x25208E0", Offset = "0x251FCE0", VA = "0x1825208E0")]
	private static JPIKIHIICJP IMGINFBGENE<TMOutput>([In] this DLJGBCHBPKA<LELHOHFMKKF<TMOutput>> LOMPFKEACIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2520040", Offset = "0x251F440", VA = "0x182520040")]
	private static DLJGBCHBPKA<LELHOHFMKKF<TMOutput>> CEDEPOELDPJ<TMOutput>(this JPIKIHIICJP LOMPFKEACIP)
	{
		return default(DLJGBCHBPKA<LELHOHFMKKF<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x25203C0", Offset = "0x251F7C0", VA = "0x1825203C0")]
	internal static void HJKKNDHGMPB<TMInput, TMOutput, TMNode>(this ONNDFHIPHLM<TMInput, TMOutput, TMNode> LOMPFKEACIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2520320", Offset = "0x251F720", VA = "0x182520320")]
	internal static LELHOHFMKKF<TMInput> FOJKOLMDIHF<TMInput, TMOutput, TMNode>(this ONNDFHIPHLM<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> DKBEBHEBAJO)
	{
		return default(LELHOHFMKKF<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2520FC0", Offset = "0x25203C0", VA = "0x182520FC0")]
	internal static void JGNAPAAMDNO<TMInput, TMOutput, TMNode>(this ONNDFHIPHLM<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMInput> FNOGEAGAPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2519BF0", Offset = "0x2518FF0", VA = "0x182519BF0")]
	public static bool HMCLEKMJLHA<TMInput, TMOutput, TMNode>([In] this ONNDFHIPHLM<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMInput> FNOGEAGAPLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x23A3250", Offset = "0x23A2650", VA = "0x1823A3250")]
	public static int IDODILDAIEM<TMInput, TMOutput, TMNode>([In] this ONNDFHIPHLM<TMInput, TMOutput, TMNode> LOMPFKEACIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2520300", Offset = "0x251F700", VA = "0x182520300")]
	public static LELHOHFMKKF<TMNode> ELBKKGJKBOB<TMNode, TMInput, TMOutput>([In] this ONNDFHIPHLM<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMInput> FNOGEAGAPLC)
	{
		return default(LELHOHFMKKF<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2521050", Offset = "0x2520450", VA = "0x182521050")]
	public static int JMMKOMNGMIB<TMInput, TMOutput, TMNode>([In] this ONNDFHIPHLM<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMInput> FNOGEAGAPLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x251FF90", Offset = "0x251F390", VA = "0x18251FF90")]
	public static LELHOHFMKKF<TMOutput> AFBKNKHCJHN<TMOutput, TMInput, TMNode>([In] this ONNDFHIPHLM<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMInput> FNOGEAGAPLC, int AHDNEIKOMIB)
	{
		return default(LELHOHFMKKF<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x25202C0", Offset = "0x251F6C0", VA = "0x1825202C0")]
	internal static void IONHIGJOKLK<TMInput, TMOutput, TMNode>(this ONNDFHIPHLM<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMInput> FNOGEAGAPLC, LELHOHFMKKF<TMOutput> KPOALPLEIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x25202C0", Offset = "0x251F6C0", VA = "0x1825202C0")]
	internal static void DCBPIPOEBPD<TMInput, TMOutput, TMNode>(this ONNDFHIPHLM<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMInput> FNOGEAGAPLC, LELHOHFMKKF<TMOutput> KPOALPLEIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x251FFE0", Offset = "0x251F3E0", VA = "0x18251FFE0")]
	public static DLJGBCHBPKA<LELHOHFMKKF<TMOutput>>.NEMOJDLALBJ BPPMJJHJLFH<TMOutput, TMInput, TMNode>([In] this ONNDFHIPHLM<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMInput> FNOGEAGAPLC)
	{
		return default(DLJGBCHBPKA<LELHOHFMKKF<TMOutput>>.NEMOJDLALBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x251FFE0", Offset = "0x251F3E0", VA = "0x18251FFE0")]
	public static BNHKMAPMMAI<LELHOHFMKKF<TMOutput>, DLJGBCHBPKA<LELHOHFMKKF<TMOutput>>.NEMOJDLALBJ> OOJOLEAMDOA<TMOutput, TMInput, TMNode>([In] this ONNDFHIPHLM<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMInput> FNOGEAGAPLC)
	{
		return default(BNHKMAPMMAI<LELHOHFMKKF<TMOutput>, DLJGBCHBPKA<LELHOHFMKKF<TMOutput>>.NEMOJDLALBJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct OGAHCHNHMHH<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal DNLJCIPGMCH<TMNode> CIFGPMLAAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal LBJJCFEPAMD<TMNode, DLJGBCHBPKA<LELHOHFMKKF<TMInput>>> MGAKJPAKPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal LBJJCFEPAMD<TMNode, DLJGBCHBPKA<LELHOHFMKKF<TMOutput>>> BPDHAMJMEOP;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3AD2010", Offset = "0x3AD1410", VA = "0x183AD2010")]
	internal OGAHCHNHMHH([In] DNLJCIPGMCH<TMNode> KACCELJHPBO, [In] LBJJCFEPAMD<TMNode, DLJGBCHBPKA<LELHOHFMKKF<TMInput>>> EAELCGHJPDI, [In] LBJJCFEPAMD<TMNode, DLJGBCHBPKA<LELHOHFMKKF<TMOutput>>> PHGKKOHPNNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3AD1DA0", Offset = "0x3AD11A0", VA = "0x183AD1DA0")]
	internal static OGAHCHNHMHH<TMInput, TMOutput, TMNode> CPLKLKACALP()
	{
		return default(OGAHCHNHMHH<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class GKHIMBNGCCH
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x267F7A0", Offset = "0x267EBA0", VA = "0x18267F7A0")]
	internal static HHAEGILAPOL ILCGODJBNBA<TMInput, TMOutput, TMNode>([In] this OGAHCHNHMHH<TMInput, TMOutput, TMNode> LOMPFKEACIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x267FB60", Offset = "0x267EF60", VA = "0x18267FB60")]
	internal static OGAHCHNHMHH<TMInput, TMOutput, TMNode> JCEFODEMOAF<TMInput, TMOutput, TMNode>(this HHAEGILAPOL LOMPFKEACIP)
	{
		return default(OGAHCHNHMHH<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2680350", Offset = "0x267F750", VA = "0x182680350")]
	private static ANJMALDLOMB ONAEHJABEGP<TMInput>([In] this DLJGBCHBPKA<LELHOHFMKKF<TMInput>> LOMPFKEACIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x267F520", Offset = "0x267E920", VA = "0x18267F520")]
	private static DLJGBCHBPKA<LELHOHFMKKF<TMInput>> IJANFKKNMLA<TMInput>(this ANJMALDLOMB LOMPFKEACIP)
	{
		return default(DLJGBCHBPKA<LELHOHFMKKF<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2680180", Offset = "0x267F580", VA = "0x182680180")]
	private static POHMNCGFAHJ KIKFLLDFAGN<TMOutput>([In] this DLJGBCHBPKA<LELHOHFMKKF<TMOutput>> LOMPFKEACIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2680520", Offset = "0x267F920", VA = "0x182680520")]
	private static DLJGBCHBPKA<LELHOHFMKKF<TMOutput>> PHEDOBHKONO<TMOutput>(this POHMNCGFAHJ LOMPFKEACIP)
	{
		return default(DLJGBCHBPKA<LELHOHFMKKF<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x267F260", Offset = "0x267E660", VA = "0x18267F260")]
	internal static void HJKKNDHGMPB<TMInput, TMOutput, TMNode>(this OGAHCHNHMHH<TMInput, TMOutput, TMNode> LOMPFKEACIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x267F1D0", Offset = "0x267E5D0", VA = "0x18267F1D0")]
	internal static LELHOHFMKKF<TMNode> FOJKOLMDIHF<TMNode, TMInput, TMOutput>(this OGAHCHNHMHH<TMInput, TMOutput, TMNode> LOMPFKEACIP, [In] DLJGBCHBPKA<LELHOHFMKKF<TMInput>> EAELCGHJPDI, [In] DLJGBCHBPKA<LELHOHFMKKF<TMOutput>> PHGKKOHPNNN)
	{
		return default(LELHOHFMKKF<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2680070", Offset = "0x267F470", VA = "0x182680070")]
	internal static void JGNAPAAMDNO<TMInput, TMOutput, TMNode>(this OGAHCHNHMHH<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> FNOGEAGAPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2519BF0", Offset = "0x2518FF0", VA = "0x182519BF0")]
	public static bool HMCLEKMJLHA<TMInput, TMOutput, TMNode>([In] this OGAHCHNHMHH<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> FNOGEAGAPLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x23A3250", Offset = "0x23A2650", VA = "0x1823A3250")]
	public static int IDODILDAIEM<TMInput, TMOutput, TMNode>([In] this OGAHCHNHMHH<TMInput, TMOutput, TMNode> LOMPFKEACIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x267F190", Offset = "0x267E590", VA = "0x18267F190")]
	public static int DNFDOOGPAHM<TMInput, TMOutput, TMNode>([In] this OGAHCHNHMHH<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> FNOGEAGAPLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2521050", Offset = "0x2520450", VA = "0x182521050")]
	public static int JMMKOMNGMIB<TMInput, TMOutput, TMNode>([In] this OGAHCHNHMHH<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> FNOGEAGAPLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2680130", Offset = "0x267F530", VA = "0x182680130")]
	public static LELHOHFMKKF<TMInput> JOLNBGDCADC<TMInput, TMOutput, TMNode>([In] this OGAHCHNHMHH<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> FNOGEAGAPLC, int AHDNEIKOMIB)
	{
		return default(LELHOHFMKKF<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x251FF90", Offset = "0x251F390", VA = "0x18251FF90")]
	public static LELHOHFMKKF<TMOutput> AFBKNKHCJHN<TMOutput, TMInput, TMNode>([In] this OGAHCHNHMHH<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> FNOGEAGAPLC, int AHDNEIKOMIB)
	{
		return default(LELHOHFMKKF<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x267F0A0", Offset = "0x267E4A0", VA = "0x18267F0A0")]
	internal static void AJBGAEBIPDE<TMInput, TMOutput, TMNode>(this OGAHCHNHMHH<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> FNOGEAGAPLC, LELHOHFMKKF<TMInput> MIPIBMCBIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x25202C0", Offset = "0x251F6C0", VA = "0x1825202C0")]
	internal static void IONHIGJOKLK<TMInput, TMOutput, TMNode>(this OGAHCHNHMHH<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> FNOGEAGAPLC, LELHOHFMKKF<TMOutput> KPOALPLEIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x26807A0", Offset = "0x267FBA0", VA = "0x1826807A0")]
	internal static void PIAONOCOBBH<TMInput, TMOutput, TMNode>(this OGAHCHNHMHH<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> FNOGEAGAPLC, int AHDNEIKOMIB, LELHOHFMKKF<TMInput> MIPIBMCBIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x267F140", Offset = "0x267E540", VA = "0x18267F140")]
	internal static void DCHGHJFALNG<TMInput, TMOutput, TMNode>(this OGAHCHNHMHH<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> FNOGEAGAPLC, int AHDNEIKOMIB, LELHOHFMKKF<TMOutput> KPOALPLEIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x267F0A0", Offset = "0x267E4A0", VA = "0x18267F0A0")]
	internal static void LEEILGGFKDD<TMInput, TMOutput, TMNode>(this OGAHCHNHMHH<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> FNOGEAGAPLC, LELHOHFMKKF<TMInput> MIPIBMCBIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x25202C0", Offset = "0x251F6C0", VA = "0x1825202C0")]
	internal static void DCBPIPOEBPD<TMInput, TMOutput, TMNode>(this OGAHCHNHMHH<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> FNOGEAGAPLC, LELHOHFMKKF<TMOutput> KPOALPLEIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x267F0E0", Offset = "0x267E4E0", VA = "0x18267F0E0")]
	public static DLJGBCHBPKA<LELHOHFMKKF<TMInput>>.NEMOJDLALBJ JPKHDNGBNKL<TMInput, TMOutput, TMNode>([In] this OGAHCHNHMHH<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> FNOGEAGAPLC)
	{
		return default(DLJGBCHBPKA<LELHOHFMKKF<TMInput>>.NEMOJDLALBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x251FFE0", Offset = "0x251F3E0", VA = "0x18251FFE0")]
	public static DLJGBCHBPKA<LELHOHFMKKF<TMOutput>>.NEMOJDLALBJ BPPMJJHJLFH<TMOutput, TMInput, TMNode>([In] this OGAHCHNHMHH<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> FNOGEAGAPLC)
	{
		return default(DLJGBCHBPKA<LELHOHFMKKF<TMOutput>>.NEMOJDLALBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x267F0E0", Offset = "0x267E4E0", VA = "0x18267F0E0")]
	public static BNHKMAPMMAI<LELHOHFMKKF<TMInput>, DLJGBCHBPKA<LELHOHFMKKF<TMInput>>.NEMOJDLALBJ> AKPFFEBMDON<TMInput, TMOutput, TMNode>([In] this OGAHCHNHMHH<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> FNOGEAGAPLC)
	{
		return default(BNHKMAPMMAI<LELHOHFMKKF<TMInput>, DLJGBCHBPKA<LELHOHFMKKF<TMInput>>.NEMOJDLALBJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x251FFE0", Offset = "0x251F3E0", VA = "0x18251FFE0")]
	public static BNHKMAPMMAI<LELHOHFMKKF<TMOutput>, DLJGBCHBPKA<LELHOHFMKKF<TMOutput>>.NEMOJDLALBJ> OOJOLEAMDOA<TMOutput, TMInput, TMNode>([In] this OGAHCHNHMHH<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> FNOGEAGAPLC)
	{
		return default(BNHKMAPMMAI<LELHOHFMKKF<TMOutput>, DLJGBCHBPKA<LELHOHFMKKF<TMOutput>>.NEMOJDLALBJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x25176B0", Offset = "0x2516AB0", VA = "0x1825176B0")]
	public static PHIPIOALAPA<LELHOHFMKKF<TMNode>, DNLJCIPGMCH<TMNode>.GEDDBIKJFJH> GPFMAJJBKOB<TMNode, TMInput, TMOutput>([In] this OGAHCHNHMHH<TMInput, TMOutput, TMNode> LOMPFKEACIP)
	{
		return default(PHIPIOALAPA<LELHOHFMKKF<TMNode>, DNLJCIPGMCH<TMNode>.GEDDBIKJFJH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct NBCPDKNCDAC<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal DNLJCIPGMCH<TMOutput> CIFGPMLAAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal LBJJCFEPAMD<TMOutput, LELHOHFMKKF<TMNode>> OBOMFHLIHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal LBJJCFEPAMD<TMOutput, DLJGBCHBPKA<LELHOHFMKKF<TMInput>>> MGAKJPAKPPK;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3AD2010", Offset = "0x3AD1410", VA = "0x183AD2010")]
	internal NBCPDKNCDAC([In] DNLJCIPGMCH<TMOutput> KACCELJHPBO, [In] LBJJCFEPAMD<TMOutput, LELHOHFMKKF<TMNode>> NFNIOOIAHDN, [In] LBJJCFEPAMD<TMOutput, DLJGBCHBPKA<LELHOHFMKKF<TMInput>>> EAELCGHJPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3AD1DA0", Offset = "0x3AD11A0", VA = "0x183AD1DA0")]
	internal static NBCPDKNCDAC<TMInput, TMOutput, TMNode> CPLKLKACALP()
	{
		return default(NBCPDKNCDAC<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class IHELHMHGJBM
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x26A7D70", Offset = "0x26A7170", VA = "0x1826A7D70")]
	internal static HJDMBFHJDOO ILCGODJBNBA<TMInput, TMOutput, TMNode>([In] this NBCPDKNCDAC<TMInput, TMOutput, TMNode> LOMPFKEACIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x26A8100", Offset = "0x26A7500", VA = "0x1826A8100")]
	internal static NBCPDKNCDAC<TMInput, TMOutput, TMNode> JCEFODEMOAF<TMInput, TMOutput, TMNode>(this HJDMBFHJDOO LOMPFKEACIP)
	{
		return default(NBCPDKNCDAC<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x26A7BA0", Offset = "0x26A6FA0", VA = "0x1826A7BA0")]
	private static BMFNPJFJLBB HDACGHBAMEC<TMInput>([In] this DLJGBCHBPKA<LELHOHFMKKF<TMInput>> LOMPFKEACIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x26A8610", Offset = "0x26A7A10", VA = "0x1826A8610")]
	private static DLJGBCHBPKA<LELHOHFMKKF<TMInput>> KCNHBBLNFBH<TMInput>(this BMFNPJFJLBB LOMPFKEACIP)
	{
		return default(DLJGBCHBPKA<LELHOHFMKKF<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x25203C0", Offset = "0x251F7C0", VA = "0x1825203C0")]
	internal static void HJKKNDHGMPB<TMInput, TMOutput, TMNode>(this NBCPDKNCDAC<TMInput, TMOutput, TMNode> LOMPFKEACIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2520320", Offset = "0x251F720", VA = "0x182520320")]
	internal static LELHOHFMKKF<TMOutput> FOJKOLMDIHF<TMOutput, TMInput, TMNode>(this NBCPDKNCDAC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMNode> DKBEBHEBAJO)
	{
		return default(LELHOHFMKKF<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2520FC0", Offset = "0x25203C0", VA = "0x182520FC0")]
	internal static void JGNAPAAMDNO<TMInput, TMOutput, TMNode>(this NBCPDKNCDAC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMOutput> FNOGEAGAPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2519BF0", Offset = "0x2518FF0", VA = "0x182519BF0")]
	public static bool HMCLEKMJLHA<TMInput, TMOutput, TMNode>([In] this NBCPDKNCDAC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMOutput> FNOGEAGAPLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x23A3250", Offset = "0x23A2650", VA = "0x1823A3250")]
	public static int IDODILDAIEM<TMInput, TMOutput, TMNode>([In] this NBCPDKNCDAC<TMInput, TMOutput, TMNode> LOMPFKEACIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2520300", Offset = "0x251F700", VA = "0x182520300")]
	public static LELHOHFMKKF<TMNode> ELBKKGJKBOB<TMNode, TMInput, TMOutput>([In] this NBCPDKNCDAC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMOutput> FNOGEAGAPLC)
	{
		return default(LELHOHFMKKF<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2521050", Offset = "0x2520450", VA = "0x182521050")]
	public static int DNFDOOGPAHM<TMInput, TMOutput, TMNode>([In] this NBCPDKNCDAC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMOutput> FNOGEAGAPLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x251FF90", Offset = "0x251F390", VA = "0x18251FF90")]
	public static LELHOHFMKKF<TMInput> JOLNBGDCADC<TMInput, TMOutput, TMNode>([In] this NBCPDKNCDAC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMOutput> FNOGEAGAPLC, int AHDNEIKOMIB)
	{
		return default(LELHOHFMKKF<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x25202C0", Offset = "0x251F6C0", VA = "0x1825202C0")]
	internal static void AJBGAEBIPDE<TMInput, TMOutput, TMNode>(this NBCPDKNCDAC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMOutput> FNOGEAGAPLC, LELHOHFMKKF<TMInput> MIPIBMCBIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x25202C0", Offset = "0x251F6C0", VA = "0x1825202C0")]
	internal static void LEEILGGFKDD<TMInput, TMOutput, TMNode>(this NBCPDKNCDAC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMOutput> FNOGEAGAPLC, LELHOHFMKKF<TMInput> MIPIBMCBIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x251FFE0", Offset = "0x251F3E0", VA = "0x18251FFE0")]
	public static DLJGBCHBPKA<LELHOHFMKKF<TMInput>>.NEMOJDLALBJ JPKHDNGBNKL<TMInput, TMOutput, TMNode>([In] this NBCPDKNCDAC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMOutput> FNOGEAGAPLC)
	{
		return default(DLJGBCHBPKA<LELHOHFMKKF<TMInput>>.NEMOJDLALBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x251FFE0", Offset = "0x251F3E0", VA = "0x18251FFE0")]
	public static BNHKMAPMMAI<LELHOHFMKKF<TMInput>, DLJGBCHBPKA<LELHOHFMKKF<TMInput>>.NEMOJDLALBJ> AKPFFEBMDON<TMInput, TMOutput, TMNode>([In] this NBCPDKNCDAC<TMInput, TMOutput, TMNode> LOMPFKEACIP, LELHOHFMKKF<TMOutput> FNOGEAGAPLC)
	{
		return default(BNHKMAPMMAI<LELHOHFMKKF<TMInput>, DLJGBCHBPKA<LELHOHFMKKF<TMInput>>.NEMOJDLALBJ>);
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
