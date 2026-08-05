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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x29475B0", Offset = "0x29461B0", VA = "0x1829475B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FCBOAGOOKHG<TMNode> : IEnumerator<IKLALLBKLKC<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly IKLALLBKLKC<TMNode> BFKDJMPMGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly FKBNOJLBGKB<TMNode, IKLALLBKLKC<TMNode>> DMCDDAJJFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private IKLALLBKLKC<TMNode> KCNNJBACLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool MMNLPBOEKCE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public IKLALLBKLKC<TMNode> FGILBCMPPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA217D0", Offset = "0xA203D0", VA = "0x180A217D0", Slot = "4")]
		get
		{
			return default(IKLALLBKLKC<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4B86EF0", Offset = "0x4B85AF0", VA = "0x184B86EF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4B86F60", Offset = "0x4B85B60", VA = "0x184B86F60")]
	internal FCBOAGOOKHG(IKLALLBKLKC<TMNode> EILAIOEPAPK, [In] FKBNOJLBGKB<TMNode, IKLALLBKLKC<TMNode>> MKBPPMEGIKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4B86CB0", Offset = "0x4B858B0", VA = "0x184B86CB0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4B86EE0", Offset = "0x4B85AE0", VA = "0x184B86EE0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct CMNDBMIDBGM<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal static readonly IKLALLBKLKC<TMNode> DJFADKONJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal HHAPOFMILMM<TMNode> ACHKKDGNGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal FKBNOJLBGKB<TMNode, IKLALLBKLKC<TMNode>> DMCDDAJJFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal FKBNOJLBGKB<TMNode, MJLLGLFJCNK<IKLALLBKLKC<TMNode>>> PDLGHNPNJPA;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x293F350", Offset = "0x293DF50", VA = "0x18293F350")]
	internal CMNDBMIDBGM([In] HHAPOFMILMM<TMNode> KPNJGDJFCEM, [In] FKBNOJLBGKB<TMNode, IKLALLBKLKC<TMNode>> MKBPPMEGIKB, [In] FKBNOJLBGKB<TMNode, MJLLGLFJCNK<IKLALLBKLKC<TMNode>>> LJIGLNBHMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x698E680", Offset = "0x698D280", VA = "0x18698E680")]
	public static CMNDBMIDBGM<TMNode> JHMOIFLKJAD()
	{
		return default(CMNDBMIDBGM<TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class NPLOFHMHDAO
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3C45B00", Offset = "0x3C44700", VA = "0x183C45B00")]
	public static NDMNAOEPCCG BLPDEIDOFHH<TMNode>([In] this CMNDBMIDBGM<TMNode> LAAPKLDJLPE) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3C465D0", Offset = "0x3C451D0", VA = "0x183C465D0")]
	internal static DCAJHHEOHAE JCGPPBNOCCA<TMNode>([In] this MJLLGLFJCNK<IKLALLBKLKC<TMNode>> LAAPKLDJLPE) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3C46370", Offset = "0x3C44F70", VA = "0x183C46370")]
	internal static MJLLGLFJCNK<IKLALLBKLKC<TMNode>> JBPMIOGKIMF<TMNode>(this DCAJHHEOHAE LAAPKLDJLPE) where TMNode : notnull
	{
		return default(MJLLGLFJCNK<IKLALLBKLKC<TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3C45970", Offset = "0x3C44570", VA = "0x183C45970")]
	public static void AMAAGOMLOEN<TMNode>(this CMNDBMIDBGM<TMNode> LAAPKLDJLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3C46000", Offset = "0x3C44C00", VA = "0x183C46000")]
	public static bool DOBEMPPDGDH<TMNode>([In] this CMNDBMIDBGM<TMNode> LAAPKLDJLPE, IKLALLBKLKC<TMNode> ALPNKEJICNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3C467A0", Offset = "0x3C453A0", VA = "0x183C467A0")]
	public static int LAABOLCNHBB<TMNode>([In] this CMNDBMIDBGM<TMNode> LAAPKLDJLPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3C45E80", Offset = "0x3C44A80", VA = "0x183C45E80")]
	public static IKLALLBKLKC<TMNode?> BNBBJFBFOAH<TMNode>(this CMNDBMIDBGM<TMNode> LAAPKLDJLPE)
	{
		return default(IKLALLBKLKC<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3C467B0", Offset = "0x3C453B0", VA = "0x183C467B0")]
	public static IKLALLBKLKC<TMNode?> LCDBHBOKMMK<TMNode>(this CMNDBMIDBGM<TMNode> LAAPKLDJLPE, IKLALLBKLKC<TMNode> LIPFJJEAFCE)
	{
		return default(IKLALLBKLKC<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3C460B0", Offset = "0x3C44CB0", VA = "0x183C460B0")]
	public static void FLLBKAADJOO<TMNode>(this CMNDBMIDBGM<TMNode> LAAPKLDJLPE, IKLALLBKLKC<TMNode> ALPNKEJICNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3C45F70", Offset = "0x3C44B70", VA = "0x183C45F70")]
	public static bool DGGJALNGJOA<TMNode>([In] this CMNDBMIDBGM<TMNode> LAAPKLDJLPE, IKLALLBKLKC<TMNode> ALPNKEJICNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3BB81D0", Offset = "0x3BB6DD0", VA = "0x183BB81D0")]
	public static IKLALLBKLKC<TMNode?> GPBMOMKFEAK<TMNode>([In] this CMNDBMIDBGM<TMNode> LAAPKLDJLPE, IKLALLBKLKC<TMNode> ALPNKEJICNA)
	{
		return default(IKLALLBKLKC<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3C469B0", Offset = "0x3C455B0", VA = "0x183C469B0")]
	public static IKLALLBKLKC<TMNode?>? OJLLKJNJNMF<TMNode>([In] this CMNDBMIDBGM<TMNode> LAAPKLDJLPE, IKLALLBKLKC<TMNode> ALPNKEJICNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3C46880", Offset = "0x3C45480", VA = "0x183C46880")]
	public static void OAEJNILHEEP<TMNode>(this CMNDBMIDBGM<TMNode> LAAPKLDJLPE, IKLALLBKLKC<TMNode> ALPNKEJICNA, IKLALLBKLKC<TMNode> AHOAACEFKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3C46310", Offset = "0x3C44F10", VA = "0x183C46310")]
	public static DKOOOCCOGAN<IKLALLBKLKC<TMNode?>, MJLLGLFJCNK<IKLALLBKLKC<TMNode?>>.OCHMFNAODOK> IJJIJBIAFML<TMNode>([In] this CMNDBMIDBGM<TMNode> LAAPKLDJLPE, IKLALLBKLKC<TMNode> ALPNKEJICNA)
	{
		return default(DKOOOCCOGAN<IKLALLBKLKC<TMNode>, MJLLGLFJCNK<IKLALLBKLKC<TMNode>>.OCHMFNAODOK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30")]
	public static HHAPOFMILMM<TMNode?> MLHMIDGOFLA<TMNode>([In] this CMNDBMIDBGM<TMNode> LAAPKLDJLPE)
	{
		return default(HHAPOFMILMM<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3BBA960", Offset = "0x3BB9560", VA = "0x183BBA960")]
	public static HHAPOFMILMM<TMNode?>.NPNIFFCFGKL MEEEBEDBKAB<TMNode>([In] this CMNDBMIDBGM<TMNode> LAAPKLDJLPE)
	{
		return default(HHAPOFMILMM<TMNode>.NPNIFFCFGKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3BB82E0", Offset = "0x3BB6EE0", VA = "0x183BB82E0")]
	public static ECABMMAFEOH<IKLALLBKLKC<TMNode?>, HHAPOFMILMM<TMNode?>.NPNIFFCFGKL> BMCABIHKPIG<TMNode>([In] this CMNDBMIDBGM<TMNode> LAAPKLDJLPE)
	{
		return default(ECABMMAFEOH<IKLALLBKLKC<TMNode>, HHAPOFMILMM<TMNode>.NPNIFFCFGKL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3C46010", Offset = "0x3C44C10", VA = "0x183C46010")]
	public static bool EPFEHCGBAIL<TMNode>([In] this CMNDBMIDBGM<TMNode> LAAPKLDJLPE, IKLALLBKLKC<TMNode> PBOIPJOJPLG, IKLALLBKLKC<TMNode> EPHPNLHEOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3C458E0", Offset = "0x3C444E0", VA = "0x183C458E0")]
	public static ECABMMAFEOH<IKLALLBKLKC<TMNode?>, FCBOAGOOKHG<TMNode?>> AGCLOMCFJMP<TMNode>([In] this CMNDBMIDBGM<TMNode> LAAPKLDJLPE, IKLALLBKLKC<TMNode> PBOIPJOJPLG)
	{
		return default(ECABMMAFEOH<IKLALLBKLKC<TMNode>, FCBOAGOOKHG<TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class NOJJLJGCONG
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3C450E0", Offset = "0x3C43CE0", VA = "0x183C450E0")]
	public static CMNDBMIDBGM<TMNode> EBAGJKMAFHO<TMNode>(this NDMNAOEPCCG LAAPKLDJLPE) where TMNode : notnull
	{
		return default(CMNDBMIDBGM<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x29473C0", Offset = "0x2945FC0", VA = "0x1829473C0")]
	public static void FLLBKAADJOO(this NDMNAOEPCCG LAAPKLDJLPE, int ALPNKEJICNA)
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
