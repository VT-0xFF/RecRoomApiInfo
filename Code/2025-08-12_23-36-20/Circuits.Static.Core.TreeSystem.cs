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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AF25E0", Offset = "0x2AF13E0", VA = "0x182AF25E0")]
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
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
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
public struct OOBLHNAEIAB<TMNode> : IEnumerator<PFJMKELOBBL<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly PFJMKELOBBL<TMNode> BFLICNFFJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly DMCDLOLKCAK<TMNode, PFJMKELOBBL<TMNode>> EOGPDLEJPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private PFJMKELOBBL<TMNode> KBAJKMNMFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool HKGOHMJGNAM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public PFJMKELOBBL<TMNode> BONNGALDEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20", Slot = "4")]
		get
		{
			return default(PFJMKELOBBL<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5B2B480", Offset = "0x5B2A280", VA = "0x185B2B480", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5B2B500", Offset = "0x5B2A300", VA = "0x185B2B500")]
	internal OOBLHNAEIAB(PFJMKELOBBL<TMNode> NBLNCONJINM, [In] DMCDLOLKCAK<TMNode, PFJMKELOBBL<TMNode>> HMDGCANLOCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5B2B220", Offset = "0x5B2A020", VA = "0x185B2B220", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5B2B470", Offset = "0x5B2A270", VA = "0x185B2B470", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OHBDDNBABHL<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal static readonly PFJMKELOBBL<TMNode> KPBALDJBLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal MJLAEMKGHHA<TMNode> CMICLKNKMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal DMCDLOLKCAK<TMNode, PFJMKELOBBL<TMNode>> EOGPDLEJPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal DMCDLOLKCAK<TMNode, MHNDIBEMFIN<PFJMKELOBBL<TMNode>>> MFGECBGDHGK;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9C70", Offset = "0x2AE8A70", VA = "0x182AE9C70")]
	internal OHBDDNBABHL([In] MJLAEMKGHHA<TMNode> PIDHDCCPHMO, [In] DMCDLOLKCAK<TMNode, PFJMKELOBBL<TMNode>> HMDGCANLOCL, [In] DMCDLOLKCAK<TMNode, MHNDIBEMFIN<PFJMKELOBBL<TMNode>>> DPOHIAJFNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5ACE560", Offset = "0x5ACD360", VA = "0x185ACE560")]
	public static OHBDDNBABHL<TMNode> ELDPFIHNJDG()
	{
		return default(OHBDDNBABHL<TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class NNCPCFLDIPF
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3E78B90", Offset = "0x3E77990", VA = "0x183E78B90")]
	public static AIGEFEDGGFE OFACCHGGJAP<TMNode>([In] this OHBDDNBABHL<TMNode> DBBEADIHLKO) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3E792F0", Offset = "0x3E780F0", VA = "0x183E792F0")]
	internal static EPCMBGAMKIA PHOJKLIHGNB<TMNode>([In] this MHNDIBEMFIN<PFJMKELOBBL<TMNode>> DBBEADIHLKO) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3E78680", Offset = "0x3E77480", VA = "0x183E78680")]
	internal static MHNDIBEMFIN<PFJMKELOBBL<TMNode>> FLGBDPPLHIG<TMNode>(this EPCMBGAMKIA DBBEADIHLKO) where TMNode : notnull
	{
		return default(MHNDIBEMFIN<PFJMKELOBBL<TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3E78950", Offset = "0x3E77750", VA = "0x183E78950")]
	public static void MFDBANBONAB<TMNode>(this OHBDDNBABHL<TMNode> DBBEADIHLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3E78940", Offset = "0x3E77740", VA = "0x183E78940")]
	public static bool LHCDGKCPPOM<TMNode>([In] this OHBDDNBABHL<TMNode> DBBEADIHLKO, PFJMKELOBBL<TMNode> FMFDAFLDAAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3E78AE0", Offset = "0x3E778E0", VA = "0x183E78AE0")]
	public static int NNNKKPCBCFG<TMNode>([In] this OHBDDNBABHL<TMNode> DBBEADIHLKO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3E78390", Offset = "0x3E77190", VA = "0x183E78390")]
	public static PFJMKELOBBL<TMNode?> CMDLJCGLGFE<TMNode>(this OHBDDNBABHL<TMNode> DBBEADIHLKO)
	{
		return default(PFJMKELOBBL<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3E794C0", Offset = "0x3E782C0", VA = "0x183E794C0")]
	public static PFJMKELOBBL<TMNode?> PJEEGDIFIJD<TMNode>(this OHBDDNBABHL<TMNode> DBBEADIHLKO, PFJMKELOBBL<TMNode> PJGOIMBEKPK)
	{
		return default(PFJMKELOBBL<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3E78F10", Offset = "0x3E77D10", VA = "0x183E78F10")]
	public static void OJNCHOHBCNI<TMNode>(this OHBDDNBABHL<TMNode> DBBEADIHLKO, PFJMKELOBBL<TMNode> FMFDAFLDAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3E785D0", Offset = "0x3E773D0", VA = "0x183E785D0")]
	public static bool DIDGIOCFILP<TMNode>([In] this OHBDDNBABHL<TMNode> DBBEADIHLKO, PFJMKELOBBL<TMNode> FMFDAFLDAAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3E78660", Offset = "0x3E77460", VA = "0x183E78660")]
	public static PFJMKELOBBL<TMNode?> EDCKDJLGGGP<TMNode>([In] this OHBDDNBABHL<TMNode> DBBEADIHLKO, PFJMKELOBBL<TMNode> FMFDAFLDAAK)
	{
		return default(PFJMKELOBBL<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3E78480", Offset = "0x3E77280", VA = "0x183E78480")]
	public static PFJMKELOBBL<TMNode?>? DAAONBKPEPL<TMNode>([In] this OHBDDNBABHL<TMNode> DBBEADIHLKO, PFJMKELOBBL<TMNode> FMFDAFLDAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3E79180", Offset = "0x3E77F80", VA = "0x183E79180")]
	public static void OKBLDPAHCHJ<TMNode>(this OHBDDNBABHL<TMNode> DBBEADIHLKO, PFJMKELOBBL<TMNode> FMFDAFLDAAK, PFJMKELOBBL<TMNode> ABMDIDNJBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3E788E0", Offset = "0x3E776E0", VA = "0x183E788E0")]
	public static MNJCONLGFAK<PFJMKELOBBL<TMNode?>, MHNDIBEMFIN<PFJMKELOBBL<TMNode?>>.OLAIHPAEMGN> INLACFFEJLL<TMNode>([In] this OHBDDNBABHL<TMNode> DBBEADIHLKO, PFJMKELOBBL<TMNode> FMFDAFLDAAK)
	{
		return default(MNJCONLGFAK<PFJMKELOBBL<TMNode>, MHNDIBEMFIN<PFJMKELOBBL<TMNode>>.OLAIHPAEMGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xE08C40", Offset = "0xE07A40", VA = "0x180E08C40")]
	public static MJLAEMKGHHA<TMNode?> HIBKPOIAKIK<TMNode>([In] this OHBDDNBABHL<TMNode> DBBEADIHLKO)
	{
		return default(MJLAEMKGHHA<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3E792B0", Offset = "0x3E780B0", VA = "0x183E792B0")]
	public static MJLAEMKGHHA<TMNode?>.JCIKOCHPLKM OLGNAIIDMLF<TMNode>([In] this OHBDDNBABHL<TMNode> DBBEADIHLKO)
	{
		return default(MJLAEMKGHHA<TMNode>.JCIKOCHPLKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3E78350", Offset = "0x3E77150", VA = "0x183E78350")]
	public static POOMGNPCHMB<PFJMKELOBBL<TMNode?>, MJLAEMKGHHA<TMNode?>.JCIKOCHPLKM> CCICGPIJGHH<TMNode>([In] this OHBDDNBABHL<TMNode> DBBEADIHLKO)
	{
		return default(POOMGNPCHMB<PFJMKELOBBL<TMNode>, MJLAEMKGHHA<TMNode>.JCIKOCHPLKM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3E78AF0", Offset = "0x3E778F0", VA = "0x183E78AF0")]
	public static bool NPHHNNMKFEN<TMNode>([In] this OHBDDNBABHL<TMNode> DBBEADIHLKO, PFJMKELOBBL<TMNode> DFHOHFFNCIJ, PFJMKELOBBL<TMNode> MGCCLFGPDDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3E78540", Offset = "0x3E77340", VA = "0x183E78540")]
	public static POOMGNPCHMB<PFJMKELOBBL<TMNode?>, OOBLHNAEIAB<TMNode?>> DGLDKKDIOAO<TMNode>([In] this OHBDDNBABHL<TMNode> DBBEADIHLKO, PFJMKELOBBL<TMNode> DFHOHFFNCIJ)
	{
		return default(POOMGNPCHMB<PFJMKELOBBL<TMNode>, OOBLHNAEIAB<TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class FBGKNKCPHAI
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3CD9F10", Offset = "0x3CD8D10", VA = "0x183CD9F10")]
	public static OHBDDNBABHL<TMNode> PPEAGMPJINO<TMNode>(this AIGEFEDGGFE DBBEADIHLKO) where TMNode : notnull
	{
		return default(OHBDDNBABHL<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2AF23F0", Offset = "0x2AF11F0", VA = "0x182AF23F0")]
	public static void OJNCHOHBCNI(this AIGEFEDGGFE DBBEADIHLKO, int FMFDAFLDAAK)
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
