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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x27B3060", Offset = "0x27B1660", VA = "0x1827B3060")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA154F0", Offset = "0xA13AF0", VA = "0x180A154F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA15530", Offset = "0xA13B30", VA = "0x180A15530")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct CDGAOOFJMBE<TMNode> : IEnumerator<EDBALDILLBK<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly EDBALDILLBK<TMNode> OGNIDKLGPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly MDCFHPFNPDO<TMNode, EDBALDILLBK<TMNode>> OJGDOOALCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EDBALDILLBK<TMNode> GIEFLNCNHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool LNKAMFDLBDJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EDBALDILLBK<TMNode> FFKIBMLIABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0", Slot = "4")]
		get
		{
			return default(EDBALDILLBK<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x67A0880", Offset = "0x679EE80", VA = "0x1867A0880", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x67A08F0", Offset = "0x679EEF0", VA = "0x1867A08F0")]
	internal CDGAOOFJMBE(EDBALDILLBK<TMNode> IPAELMFFKOA, [In] MDCFHPFNPDO<TMNode, EDBALDILLBK<TMNode>> GJBCDGBBFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x67A0610", Offset = "0x679EC10", VA = "0x1867A0610", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67A0870", Offset = "0x679EE70", VA = "0x1867A0870", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct PJDGGNIOEGD<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal static readonly EDBALDILLBK<TMNode> AFLEIHBMGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal HJDCHFHKCJH<TMNode> HLNFEPBHOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal MDCFHPFNPDO<TMNode, EDBALDILLBK<TMNode>> OJGDOOALCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal MDCFHPFNPDO<TMNode, AKAJMPNFKFH<EDBALDILLBK<TMNode>>> EAEOMMFMLFI;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x27A9DC0", Offset = "0x27A83C0", VA = "0x1827A9DC0")]
	internal PJDGGNIOEGD([In] HJDCHFHKCJH<TMNode> DOGFLLCGOCA, [In] MDCFHPFNPDO<TMNode, EDBALDILLBK<TMNode>> GJBCDGBBFFE, [In] MDCFHPFNPDO<TMNode, AKAJMPNFKFH<EDBALDILLBK<TMNode>>> PFPOPNGDHGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x561DC90", Offset = "0x561C290", VA = "0x18561DC90")]
	public static PJDGGNIOEGD<TMNode> ACADPGMDEBE()
	{
		return default(PJDGGNIOEGD<TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class CDGCHNPJAAO
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x364ECA0", Offset = "0x364D2A0", VA = "0x18364ECA0")]
	public static NDAPOIGBFKM DFNAEDFOBIJ<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x364FBD0", Offset = "0x364E1D0", VA = "0x18364FBD0")]
	internal static BNDAOGAMMFB NFLNODDGJFP<TMNode>([In] this AKAJMPNFKFH<EDBALDILLBK<TMNode>> OCACDKEJIIB) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x364FEE0", Offset = "0x364E4E0", VA = "0x18364FEE0")]
	internal static AKAJMPNFKFH<EDBALDILLBK<TMNode>> PBKFPPBHEAG<TMNode>(this BNDAOGAMMFB OCACDKEJIIB) where TMNode : notnull
	{
		return default(AKAJMPNFKFH<EDBALDILLBK<TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x364F2B0", Offset = "0x364D8B0", VA = "0x18364F2B0")]
	public static void HMHHJKJOIHP<TMNode>(this PJDGGNIOEGD<TMNode> OCACDKEJIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x364FDD0", Offset = "0x364E3D0", VA = "0x18364FDD0")]
	public static bool NOMOJCGANNC<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB, EDBALDILLBK<TMNode> HJPLNJNIFLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x364FED0", Offset = "0x364E4D0", VA = "0x18364FED0")]
	public static int ONIGNBHFPKD<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x364F170", Offset = "0x364D770", VA = "0x18364F170")]
	public static EDBALDILLBK<TMNode?> EMNBOFGFIPB<TMNode>(this PJDGGNIOEGD<TMNode> OCACDKEJIIB)
	{
		return default(EDBALDILLBK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x364EB90", Offset = "0x364D190", VA = "0x18364EB90")]
	public static EDBALDILLBK<TMNode?> CNNHDJHOEGI<TMNode>(this PJDGGNIOEGD<TMNode> OCACDKEJIIB, EDBALDILLBK<TMNode> JHDAOHEONAC)
	{
		return default(EDBALDILLBK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x364F720", Offset = "0x364DD20", VA = "0x18364F720")]
	public static void KKIPOBFIFOD<TMNode>(this PJDGGNIOEGD<TMNode> OCACDKEJIIB, EDBALDILLBK<TMNode> HJPLNJNIFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x364FB10", Offset = "0x364E110", VA = "0x18364FB10")]
	public static bool MPKPPHOFPOF<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB, EDBALDILLBK<TMNode> HJPLNJNIFLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x364EB60", Offset = "0x364D160", VA = "0x18364EB60")]
	public static EDBALDILLBK<TMNode?> AGDGBBECAOP<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB, EDBALDILLBK<TMNode> HJPLNJNIFLL)
	{
		return default(EDBALDILLBK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x364F080", Offset = "0x364D680", VA = "0x18364F080")]
	public static EDBALDILLBK<TMNode?>? DKIHEICGEFJ<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB, EDBALDILLBK<TMNode> HJPLNJNIFLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x364F570", Offset = "0x364DB70", VA = "0x18364F570")]
	public static void KEDOMLCMECI<TMNode>(this PJDGGNIOEGD<TMNode> OCACDKEJIIB, EDBALDILLBK<TMNode> HJPLNJNIFLL, EDBALDILLBK<TMNode> ONKEPDCFAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x364FA80", Offset = "0x364E080", VA = "0x18364FA80")]
	public static DOIBLDHBKFC<EDBALDILLBK<TMNode?>, AKAJMPNFKFH<EDBALDILLBK<TMNode?>>.AFJAAIHPCGO> LCFFFIADLNM<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB, EDBALDILLBK<TMNode> HJPLNJNIFLL)
	{
		return default(DOIBLDHBKFC<EDBALDILLBK<TMNode>, AKAJMPNFKFH<EDBALDILLBK<TMNode>>.AFJAAIHPCGO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
	public static HJDCHFHKCJH<TMNode?> KACJILBJDLF<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB)
	{
		return default(HJDCHFHKCJH<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x364FE90", Offset = "0x364E490", VA = "0x18364FE90")]
	public static HJDCHFHKCJH<TMNode?>.FKEBJGIOAEP OMLAPONJPHN<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB)
	{
		return default(HJDCHFHKCJH<TMNode>.FKEBJGIOAEP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x364F270", Offset = "0x364D870", VA = "0x18364F270")]
	public static GOLJDLPFDHE<EDBALDILLBK<TMNode?>, HJDCHFHKCJH<TMNode?>.FKEBJGIOAEP> GNOINOCIHAP<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB)
	{
		return default(GOLJDLPFDHE<EDBALDILLBK<TMNode>, HJDCHFHKCJH<TMNode>.FKEBJGIOAEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x364F4A0", Offset = "0x364DAA0", VA = "0x18364F4A0")]
	public static bool IBOFHBHJCNH<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB, EDBALDILLBK<TMNode> GOJJJBGJPAM, EDBALDILLBK<TMNode> NJNGODBLHLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x364FDE0", Offset = "0x364E3E0", VA = "0x18364FDE0")]
	public static GOLJDLPFDHE<EDBALDILLBK<TMNode?>, CDGAOOFJMBE<TMNode?>> ODODGBIEFKN<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB, EDBALDILLBK<TMNode> GOJJJBGJPAM)
	{
		return default(GOLJDLPFDHE<EDBALDILLBK<TMNode>, CDGAOOFJMBE<TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class JBCKIOHMJOO
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x38BDA60", Offset = "0x38BC060", VA = "0x1838BDA60")]
	public static PJDGGNIOEGD<TMNode> AKDPGDCBDMI<TMNode>(this NDAPOIGBFKM OCACDKEJIIB) where TMNode : notnull
	{
		return default(PJDGGNIOEGD<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x27B2E70", Offset = "0x27B1470", VA = "0x1827B2E70")]
	public static void KKIPOBFIFOD(this NDAPOIGBFKM OCACDKEJIIB, int HJPLNJNIFLL)
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
