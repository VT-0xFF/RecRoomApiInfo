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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A5B220", Offset = "0x2A5A220", VA = "0x182A5B220")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
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
public struct GCCKKCNFFFM<TMNode> : IEnumerator<OCIDMCEKJIP<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly OCIDMCEKJIP<TMNode> CCNDJCFONND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly OPOENCIBKDO<TMNode, OCIDMCEKJIP<TMNode>> BGNLFKNGGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private OCIDMCEKJIP<TMNode> EIALBMFGGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool ADFPMNBKMFH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public OCIDMCEKJIP<TMNode> AJOLFNCECJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700", Slot = "4")]
		get
		{
			return default(OCIDMCEKJIP<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4E4D7A0", Offset = "0x4E4C7A0", VA = "0x184E4D7A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4E4D810", Offset = "0x4E4C810", VA = "0x184E4D810")]
	internal GCCKKCNFFFM(OCIDMCEKJIP<TMNode> LMLEMDDGACN, [In] OPOENCIBKDO<TMNode, OCIDMCEKJIP<TMNode>> PMOOBGJMBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4E4D560", Offset = "0x4E4C560", VA = "0x184E4D560", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4E4D790", Offset = "0x4E4C790", VA = "0x184E4D790", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct DDFGCKKIONO<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal static readonly OCIDMCEKJIP<TMNode> PCHKKCOMPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal ILEMODONLAI<TMNode> JCOPGDGCBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal OPOENCIBKDO<TMNode, OCIDMCEKJIP<TMNode>> BGNLFKNGGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal OPOENCIBKDO<TMNode, PBFBDJCALEG<OCIDMCEKJIP<TMNode>>> LCIHLCFEAHJ;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2A52640", Offset = "0x2A51640", VA = "0x182A52640")]
	internal DDFGCKKIONO([In] ILEMODONLAI<TMNode> OBKKPLKNIJE, [In] OPOENCIBKDO<TMNode, OCIDMCEKJIP<TMNode>> PMOOBGJMBHK, [In] OPOENCIBKDO<TMNode, PBFBDJCALEG<OCIDMCEKJIP<TMNode>>> OAEJIHKFLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6E82610", Offset = "0x6E81610", VA = "0x186E82610")]
	public static DDFGCKKIONO<TMNode> MPFKOOIPONO()
	{
		return default(DDFGCKKIONO<TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class EHBICGGCCHM
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3AD0130", Offset = "0x3ACF130", VA = "0x183AD0130")]
	public static IJHGAKMCEFE FBGBLPHHDGN<TMNode>([In] this DDFGCKKIONO<TMNode> OLHDOIOOPGE) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3ACF870", Offset = "0x3ACE870", VA = "0x183ACF870")]
	internal static DHKOCFDPHAL ADPPNDKKFNI<TMNode>([In] this PBFBDJCALEG<OCIDMCEKJIP<TMNode>> OLHDOIOOPGE) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3ACFB90", Offset = "0x3ACEB90", VA = "0x183ACFB90")]
	internal static PBFBDJCALEG<OCIDMCEKJIP<TMNode>> DFEOHBDNCPE<TMNode>(this DHKOCFDPHAL OLHDOIOOPGE) where TMNode : notnull
	{
		return default(PBFBDJCALEG<OCIDMCEKJIP<TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3AD0550", Offset = "0x3ACF550", VA = "0x183AD0550")]
	public static void GBLOHGCCHFB<TMNode>(this DDFGCKKIONO<TMNode> OLHDOIOOPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3AD0990", Offset = "0x3ACF990", VA = "0x183AD0990")]
	public static bool KLJIOEKBNLN<TMNode>([In] this DDFGCKKIONO<TMNode> OLHDOIOOPGE, OCIDMCEKJIP<TMNode> PBJHGGBBAAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3AD0980", Offset = "0x3ACF980", VA = "0x183AD0980")]
	public static int JFHJAFBIKCK<TMNode>([In] this DDFGCKKIONO<TMNode> OLHDOIOOPGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3ACFA40", Offset = "0x3ACEA40", VA = "0x183ACFA40")]
	public static OCIDMCEKJIP<TMNode?> AILCCJNOEBG<TMNode>(this DDFGCKKIONO<TMNode> OLHDOIOOPGE)
	{
		return default(OCIDMCEKJIP<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3AD0060", Offset = "0x3ACF060", VA = "0x183AD0060")]
	public static OCIDMCEKJIP<TMNode?> EGALNLINPEG<TMNode>(this DDFGCKKIONO<TMNode> OLHDOIOOPGE, OCIDMCEKJIP<TMNode> EBJBKAEFOPM)
	{
		return default(OCIDMCEKJIP<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3ACFE00", Offset = "0x3ACEE00", VA = "0x183ACFE00")]
	public static void ECPMCGAOIHB<TMNode>(this DDFGCKKIONO<TMNode> OLHDOIOOPGE, OCIDMCEKJIP<TMNode> PBJHGGBBAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3AD04C0", Offset = "0x3ACF4C0", VA = "0x183AD04C0")]
	public static bool FKHKIDHBPAC<TMNode>([In] this DDFGCKKIONO<TMNode> OLHDOIOOPGE, OCIDMCEKJIP<TMNode> PBJHGGBBAAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3AD06E0", Offset = "0x3ACF6E0", VA = "0x183AD06E0")]
	public static OCIDMCEKJIP<TMNode?> GHBGGJNGHEC<TMNode>([In] this DDFGCKKIONO<TMNode> OLHDOIOOPGE, OCIDMCEKJIP<TMNode> PBJHGGBBAAF)
	{
		return default(OCIDMCEKJIP<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3AD0740", Offset = "0x3ACF740", VA = "0x183AD0740")]
	public static OCIDMCEKJIP<TMNode?>? GMOGNCEHPCC<TMNode>([In] this DDFGCKKIONO<TMNode> OLHDOIOOPGE, OCIDMCEKJIP<TMNode> PBJHGGBBAAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3AD0810", Offset = "0x3ACF810", VA = "0x183AD0810")]
	public static void IIIBKIPEKLL<TMNode>(this DDFGCKKIONO<TMNode> OLHDOIOOPGE, OCIDMCEKJIP<TMNode> PBJHGGBBAAF, OCIDMCEKJIP<TMNode> ICPGCNLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3ACFB30", Offset = "0x3ACEB30", VA = "0x183ACFB30")]
	public static CPMJCNKKGMI<OCIDMCEKJIP<TMNode?>, PBFBDJCALEG<OCIDMCEKJIP<TMNode?>>.IAIKJCEGMMG> DCLAKFMFDKN<TMNode>([In] this DDFGCKKIONO<TMNode> OLHDOIOOPGE, OCIDMCEKJIP<TMNode> PBJHGGBBAAF)
	{
		return default(CPMJCNKKGMI<OCIDMCEKJIP<TMNode>, PBFBDJCALEG<OCIDMCEKJIP<TMNode>>.IAIKJCEGMMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xDBBB10", Offset = "0xDBAB10", VA = "0x180DBBB10")]
	public static ILEMODONLAI<TMNode?> NPPGGEJDHGE<TMNode>([In] this DDFGCKKIONO<TMNode> OLHDOIOOPGE)
	{
		return default(ILEMODONLAI<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3AD0700", Offset = "0x3ACF700", VA = "0x183AD0700")]
	public static ILEMODONLAI<TMNode?>.NLKJPKJCPBP GHDHEBFDHCI<TMNode>([In] this DDFGCKKIONO<TMNode> OLHDOIOOPGE)
	{
		return default(ILEMODONLAI<TMNode>.NLKJPKJCPBP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3AD0940", Offset = "0x3ACF940", VA = "0x183AD0940")]
	public static BBLBDLCFINE<OCIDMCEKJIP<TMNode?>, ILEMODONLAI<TMNode?>.NLKJPKJCPBP> IIKILNHNIHK<TMNode>([In] this DDFGCKKIONO<TMNode> OLHDOIOOPGE)
	{
		return default(BBLBDLCFINE<OCIDMCEKJIP<TMNode>, ILEMODONLAI<TMNode>.NLKJPKJCPBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3AD09A0", Offset = "0x3ACF9A0", VA = "0x183AD09A0")]
	public static bool NGFPPLPOBIP<TMNode>([In] this DDFGCKKIONO<TMNode> OLHDOIOOPGE, OCIDMCEKJIP<TMNode> ABOLKPCCJOL, OCIDMCEKJIP<TMNode> EMENNBOEONK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3AD0A40", Offset = "0x3ACFA40", VA = "0x183AD0A40")]
	public static BBLBDLCFINE<OCIDMCEKJIP<TMNode?>, GCCKKCNFFFM<TMNode?>> OMPOLHFJIMJ<TMNode>([In] this DDFGCKKIONO<TMNode> OLHDOIOOPGE, OCIDMCEKJIP<TMNode> ABOLKPCCJOL)
	{
		return default(BBLBDLCFINE<OCIDMCEKJIP<TMNode>, GCCKKCNFFFM<TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class ILFBACENCEJ
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3CCB7D0", Offset = "0x3CCA7D0", VA = "0x183CCB7D0")]
	public static DDFGCKKIONO<TMNode> LABNBGADOBH<TMNode>(this IJHGAKMCEFE OLHDOIOOPGE) where TMNode : notnull
	{
		return default(DDFGCKKIONO<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2A5B030", Offset = "0x2A5A030", VA = "0x182A5B030")]
	public static void ECPMCGAOIHB(this IJHGAKMCEFE OLHDOIOOPGE, int PBJHGGBBAAF)
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
