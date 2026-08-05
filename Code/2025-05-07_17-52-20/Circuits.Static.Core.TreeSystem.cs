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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x27B2650", Offset = "0x27B1650", VA = "0x1827B2650")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B220", Offset = "0xA1A220", VA = "0x180A1B220")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B260", Offset = "0xA1A260", VA = "0x180A1B260")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0", Slot = "4")]
		get
		{
			return default(EDBALDILLBK<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x67A64B0", Offset = "0x67A54B0", VA = "0x1867A64B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x67A6520", Offset = "0x67A5520", VA = "0x1867A6520")]
	internal CDGAOOFJMBE(EDBALDILLBK<TMNode> IPAELMFFKOA, [In] MDCFHPFNPDO<TMNode, EDBALDILLBK<TMNode>> GJBCDGBBFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x67A6220", Offset = "0x67A5220", VA = "0x1867A6220", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67A64A0", Offset = "0x67A54A0", VA = "0x1867A64A0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x27A9220", Offset = "0x27A8220", VA = "0x1827A9220")]
	internal PJDGGNIOEGD([In] HJDCHFHKCJH<TMNode> DOGFLLCGOCA, [In] MDCFHPFNPDO<TMNode, EDBALDILLBK<TMNode>> GJBCDGBBFFE, [In] MDCFHPFNPDO<TMNode, AKAJMPNFKFH<EDBALDILLBK<TMNode>>> PFPOPNGDHGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5610070", Offset = "0x560F070", VA = "0x185610070")]
	public static PJDGGNIOEGD<TMNode> ACADPGMDEBE()
	{
		return default(PJDGGNIOEGD<TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class CDGCHNPJAAO
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3631EB0", Offset = "0x3630EB0", VA = "0x183631EB0")]
	public static NDAPOIGBFKM DFNAEDFOBIJ<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3632E10", Offset = "0x3631E10", VA = "0x183632E10")]
	internal static BNDAOGAMMFB NFLNODDGJFP<TMNode>([In] this AKAJMPNFKFH<EDBALDILLBK<TMNode>> OCACDKEJIIB) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3633120", Offset = "0x3632120", VA = "0x183633120")]
	internal static AKAJMPNFKFH<EDBALDILLBK<TMNode>> PBKFPPBHEAG<TMNode>(this BNDAOGAMMFB OCACDKEJIIB) where TMNode : notnull
	{
		return default(AKAJMPNFKFH<EDBALDILLBK<TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x36324E0", Offset = "0x36314E0", VA = "0x1836324E0")]
	public static void HMHHJKJOIHP<TMNode>(this PJDGGNIOEGD<TMNode> OCACDKEJIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3633010", Offset = "0x3632010", VA = "0x183633010")]
	public static bool NOMOJCGANNC<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB, EDBALDILLBK<TMNode> HJPLNJNIFLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3633110", Offset = "0x3632110", VA = "0x183633110")]
	public static int ONIGNBHFPKD<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x36323A0", Offset = "0x36313A0", VA = "0x1836323A0")]
	public static EDBALDILLBK<TMNode?> EMNBOFGFIPB<TMNode>(this PJDGGNIOEGD<TMNode> OCACDKEJIIB)
	{
		return default(EDBALDILLBK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3631DA0", Offset = "0x3630DA0", VA = "0x183631DA0")]
	public static EDBALDILLBK<TMNode?> CNNHDJHOEGI<TMNode>(this PJDGGNIOEGD<TMNode> OCACDKEJIIB, EDBALDILLBK<TMNode> JHDAOHEONAC)
	{
		return default(EDBALDILLBK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3632950", Offset = "0x3631950", VA = "0x183632950")]
	public static void KKIPOBFIFOD<TMNode>(this PJDGGNIOEGD<TMNode> OCACDKEJIIB, EDBALDILLBK<TMNode> HJPLNJNIFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3632D50", Offset = "0x3631D50", VA = "0x183632D50")]
	public static bool MPKPPHOFPOF<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB, EDBALDILLBK<TMNode> HJPLNJNIFLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3631D70", Offset = "0x3630D70", VA = "0x183631D70")]
	public static EDBALDILLBK<TMNode?> AGDGBBECAOP<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB, EDBALDILLBK<TMNode> HJPLNJNIFLL)
	{
		return default(EDBALDILLBK<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x36322B0", Offset = "0x36312B0", VA = "0x1836322B0")]
	public static EDBALDILLBK<TMNode?>? DKIHEICGEFJ<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB, EDBALDILLBK<TMNode> HJPLNJNIFLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x36327A0", Offset = "0x36317A0", VA = "0x1836327A0")]
	public static void KEDOMLCMECI<TMNode>(this PJDGGNIOEGD<TMNode> OCACDKEJIIB, EDBALDILLBK<TMNode> HJPLNJNIFLL, EDBALDILLBK<TMNode> ONKEPDCFAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3632CC0", Offset = "0x3631CC0", VA = "0x183632CC0")]
	public static DOIBLDHBKFC<EDBALDILLBK<TMNode?>, AKAJMPNFKFH<EDBALDILLBK<TMNode?>>.AFJAAIHPCGO> LCFFFIADLNM<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB, EDBALDILLBK<TMNode> HJPLNJNIFLL)
	{
		return default(DOIBLDHBKFC<EDBALDILLBK<TMNode>, AKAJMPNFKFH<EDBALDILLBK<TMNode>>.AFJAAIHPCGO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xC771F0", Offset = "0xC761F0", VA = "0x180C771F0")]
	public static HJDCHFHKCJH<TMNode?> KACJILBJDLF<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB)
	{
		return default(HJDCHFHKCJH<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x36330D0", Offset = "0x36320D0", VA = "0x1836330D0")]
	public static HJDCHFHKCJH<TMNode?>.FKEBJGIOAEP OMLAPONJPHN<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB)
	{
		return default(HJDCHFHKCJH<TMNode>.FKEBJGIOAEP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x36324A0", Offset = "0x36314A0", VA = "0x1836324A0")]
	public static GOLJDLPFDHE<EDBALDILLBK<TMNode?>, HJDCHFHKCJH<TMNode?>.FKEBJGIOAEP> GNOINOCIHAP<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB)
	{
		return default(GOLJDLPFDHE<EDBALDILLBK<TMNode>, HJDCHFHKCJH<TMNode>.FKEBJGIOAEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x36326D0", Offset = "0x36316D0", VA = "0x1836326D0")]
	public static bool IBOFHBHJCNH<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB, EDBALDILLBK<TMNode> GOJJJBGJPAM, EDBALDILLBK<TMNode> NJNGODBLHLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3633020", Offset = "0x3632020", VA = "0x183633020")]
	public static GOLJDLPFDHE<EDBALDILLBK<TMNode?>, CDGAOOFJMBE<TMNode?>> ODODGBIEFKN<TMNode>([In] this PJDGGNIOEGD<TMNode> OCACDKEJIIB, EDBALDILLBK<TMNode> GOJJJBGJPAM)
	{
		return default(GOLJDLPFDHE<EDBALDILLBK<TMNode>, CDGAOOFJMBE<TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class JBCKIOHMJOO
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x389F9A0", Offset = "0x389E9A0", VA = "0x18389F9A0")]
	public static PJDGGNIOEGD<TMNode> AKDPGDCBDMI<TMNode>(this NDAPOIGBFKM OCACDKEJIIB) where TMNode : notnull
	{
		return default(PJDGGNIOEGD<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x27B2460", Offset = "0x27B1460", VA = "0x1827B2460")]
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
