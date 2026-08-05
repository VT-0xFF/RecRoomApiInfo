using System;
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
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2219720", Offset = "0x2218920", VA = "0x182219720")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C0750", Offset = "0x8BF950", VA = "0x1808C0750")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C0790", Offset = "0x8BF990", VA = "0x1808C0790")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct IMBJGNPGCAL<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal static readonly GJCCLPKGONN<TMNode> NMEMMCJLMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal CCPCEGIBCBK<TMNode> NBLGAGMMMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal FILDJDALFDC<TMNode, GJCCLPKGONN<TMNode>> HMJAKLGGPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal FILDJDALFDC<TMNode, BCBMJGBJHDO<GJCCLPKGONN<TMNode>>> POFIOBKMEDB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2211FC0", Offset = "0x22111C0", VA = "0x182211FC0")]
	internal IMBJGNPGCAL([In] CCPCEGIBCBK<TMNode> EINNDIFLJFM, [In] FILDJDALFDC<TMNode, GJCCLPKGONN<TMNode>> IFEMDINNKGM, [In] FILDJDALFDC<TMNode, BCBMJGBJHDO<GJCCLPKGONN<TMNode>>> OOMBIMDKGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4182D30", Offset = "0x4181F30", VA = "0x184182D30")]
	public static IMBJGNPGCAL<TMNode> MIFIOLMMIDE()
	{
		return default(IMBJGNPGCAL<TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BGBOJBEJPEA
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7B50", Offset = "0x2BA6D50", VA = "0x182BA7B50")]
	public static GGBAGEBHMNE LMOHAAKIFFE<TMNode>([In] this IMBJGNPGCAL<TMNode> AEFKHDNCNFD) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7790", Offset = "0x2BA6990", VA = "0x182BA7790")]
	internal static HEFOLBNANPP KMLFICCNAJN<TMNode>([In] this BCBMJGBJHDO<GJCCLPKGONN<TMNode>> AEFKHDNCNFD) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7060", Offset = "0x2BA6260", VA = "0x182BA7060")]
	internal static BCBMJGBJHDO<GJCCLPKGONN<TMNode>> IFGNNLAMCNC<TMNode>(this HEFOLBNANPP AEFKHDNCNFD) where TMNode : notnull
	{
		return default(BCBMJGBJHDO<GJCCLPKGONN<TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6E30", Offset = "0x2BA6030", VA = "0x182BA6E30")]
	public static void GJKAEPPOOPE<TMNode>(this IMBJGNPGCAL<TMNode> AEFKHDNCNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6CE0", Offset = "0x2BA5EE0", VA = "0x182BA6CE0")]
	public static bool BBGJCOKFMOM<TMNode>([In] this IMBJGNPGCAL<TMNode> AEFKHDNCNFD, GJCCLPKGONN<TMNode> MHMAFIBKDFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7990", Offset = "0x2BA6B90", VA = "0x182BA7990")]
	public static int LACCJJBLCDC<TMNode>([In] this IMBJGNPGCAL<TMNode> AEFKHDNCNFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7330", Offset = "0x2BA6530", VA = "0x182BA7330")]
	public static GJCCLPKGONN<TMNode?> ILNJPFGNICF<TMNode>(this IMBJGNPGCAL<TMNode> AEFKHDNCNFD)
	{
		return default(GJCCLPKGONN<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6CF0", Offset = "0x2BA5EF0", VA = "0x182BA6CF0")]
	public static GJCCLPKGONN<TMNode?> FDFBEDKLMAE<TMNode>(this IMBJGNPGCAL<TMNode> AEFKHDNCNFD, GJCCLPKGONN<TMNode> MBOJNCFILKL)
	{
		return default(GJCCLPKGONN<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7430", Offset = "0x2BA6630", VA = "0x182BA7430")]
	public static void IMHGPOENCOG<TMNode>(this IMBJGNPGCAL<TMNode> AEFKHDNCNFD, GJCCLPKGONN<TMNode> MHMAFIBKDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6E00", Offset = "0x2BA6000", VA = "0x182BA6E00")]
	public static GJCCLPKGONN<TMNode?> GIBOCKIFPIG<TMNode>([In] this IMBJGNPGCAL<TMNode> AEFKHDNCNFD, GJCCLPKGONN<TMNode> MHMAFIBKDFF)
	{
		return default(GJCCLPKGONN<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2BA79A0", Offset = "0x2BA6BA0", VA = "0x182BA79A0")]
	public static void LFJKCOJGMGE<TMNode>(this IMBJGNPGCAL<TMNode> AEFKHDNCNFD, GJCCLPKGONN<TMNode> MHMAFIBKDFF, GJCCLPKGONN<TMNode> HOIJHODHKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7F30", Offset = "0x2BA7130", VA = "0x182BA7F30")]
	public static INCKFOCJECF<GJCCLPKGONN<TMNode?>, BCBMJGBJHDO<GJCCLPKGONN<TMNode?>>.AFCOHCGDPFO> MMOKHGKLAHG<TMNode>([In] this IMBJGNPGCAL<TMNode> AEFKHDNCNFD, GJCCLPKGONN<TMNode> MHMAFIBKDFF)
	{
		return default(INCKFOCJECF<GJCCLPKGONN<TMNode>, BCBMJGBJHDO<GJCCLPKGONN<TMNode>>.AFCOHCGDPFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0")]
	public static CCPCEGIBCBK<TMNode?> AOOHIFKIECA<TMNode>([In] this IMBJGNPGCAL<TMNode> AEFKHDNCNFD)
	{
		return default(CCPCEGIBCBK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2BA6CA0", Offset = "0x2BA5EA0", VA = "0x182BA6CA0")]
	public static CCPCEGIBCBK<TMNode?>.GLJGEACBAKE AKJNNDDNIOE<TMNode>([In] this IMBJGNPGCAL<TMNode> AEFKHDNCNFD)
	{
		return default(CCPCEGIBCBK<TMNode>.GLJGEACBAKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7020", Offset = "0x2BA6220", VA = "0x182BA7020")]
	public static MNCNKNGEPBJ<GJCCLPKGONN<TMNode?>, CCPCEGIBCBK<TMNode?>.GLJGEACBAKE> HELOCFDMKIM<TMNode>([In] this IMBJGNPGCAL<TMNode> AEFKHDNCNFD)
	{
		return default(MNCNKNGEPBJ<GJCCLPKGONN<TMNode>, CCPCEGIBCBK<TMNode>.GLJGEACBAKE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class NMJCPILGJDF
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2F84290", Offset = "0x2F83490", VA = "0x182F84290")]
	public static IMBJGNPGCAL<TMNode> GBKBNNNFJGC<TMNode>(this GGBAGEBHMNE AEFKHDNCNFD) where TMNode : notnull
	{
		return default(IMBJGNPGCAL<TMNode>);
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
