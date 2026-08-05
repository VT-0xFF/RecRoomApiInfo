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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x277F790", Offset = "0x277DF90", VA = "0x18277F790")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
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
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BFNOFNGICCN<TMNode> : IEnumerator<NLPIAAOFKEO<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly NLPIAAOFKEO<TMNode> OMDEBPBELGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly OABOCIAOEJE<TMNode, NLPIAAOFKEO<TMNode>> JMLKOPCKPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NLPIAAOFKEO<TMNode> FJJOCKHDIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool CPMHKJOGBFE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NLPIAAOFKEO<TMNode> IECKFCICFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470", Slot = "4")]
		get
		{
			return default(NLPIAAOFKEO<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5E28CE0", Offset = "0x5E274E0", VA = "0x185E28CE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E28D50", Offset = "0x5E27550", VA = "0x185E28D50")]
	internal BFNOFNGICCN(NLPIAAOFKEO<TMNode> MLFBDFDDHEO, [In] OABOCIAOEJE<TMNode, NLPIAAOFKEO<TMNode>> KNGEPMJCFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E28A70", Offset = "0x5E27270", VA = "0x185E28A70", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E28CD0", Offset = "0x5E274D0", VA = "0x185E28CD0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct DLPJIHMBLCO<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal static readonly NLPIAAOFKEO<TMNode> OGLDLMPCPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal DPFLMJLLNFF<TMNode> JCHCLFCDCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal OABOCIAOEJE<TMNode, NLPIAAOFKEO<TMNode>> JMLKOPCKPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal OABOCIAOEJE<TMNode, PFLMDAPEOIN<NLPIAAOFKEO<TMNode>>> BDBGLEDBKJM;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2776C50", Offset = "0x2775450", VA = "0x182776C50")]
	internal DLPJIHMBLCO([In] DPFLMJLLNFF<TMNode> GFLKAHBLNKA, [In] OABOCIAOEJE<TMNode, NLPIAAOFKEO<TMNode>> KNGEPMJCFBL, [In] OABOCIAOEJE<TMNode, PFLMDAPEOIN<NLPIAAOFKEO<TMNode>>> KONOHDNOGNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x68E3780", Offset = "0x68E1F80", VA = "0x1868E3780")]
	public static DLPJIHMBLCO<TMNode> CJOJELENPLJ()
	{
		return default(DLPJIHMBLCO<TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class JNJENKIJJFH
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x380CA30", Offset = "0x380B230", VA = "0x18380CA30")]
	public static MPDGNLIPDBD LIJGMGKAKKG<TMNode>([In] this DLPJIHMBLCO<TMNode> NFOGFJOGLPE) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x380BA10", Offset = "0x380A210", VA = "0x18380BA10")]
	internal static DDDLHCNMFOG CJOGELICMMP<TMNode>([In] this PFLMDAPEOIN<NLPIAAOFKEO<TMNode>> NFOGFJOGLPE) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x380BC50", Offset = "0x380A450", VA = "0x18380BC50")]
	internal static PFLMDAPEOIN<NLPIAAOFKEO<TMNode>> EAPGIGIIAOF<TMNode>(this DDDLHCNMFOG NFOGFJOGLPE) where TMNode : notnull
	{
		return default(PFLMDAPEOIN<NLPIAAOFKEO<TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x380C740", Offset = "0x380AF40", VA = "0x18380C740")]
	public static void KNAKPKDGKOD<TMNode>(this DLPJIHMBLCO<TMNode> NFOGFJOGLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x380C620", Offset = "0x380AE20", VA = "0x18380C620")]
	public static bool IPJBOCLFEHF<TMNode>([In] this DLPJIHMBLCO<TMNode> NFOGFJOGLPE, NLPIAAOFKEO<TMNode> MLBCMOLHELH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x380C0C0", Offset = "0x380A8C0", VA = "0x18380C0C0")]
	public static int GFDFFPIHKCJ<TMNode>([In] this DLPJIHMBLCO<TMNode> NFOGFJOGLPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x380C930", Offset = "0x380B130", VA = "0x18380C930")]
	public static NLPIAAOFKEO<TMNode?> LIDOJKMJGCF<TMNode>(this DLPJIHMBLCO<TMNode> NFOGFJOGLPE)
	{
		return default(NLPIAAOFKEO<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x380C630", Offset = "0x380AE30", VA = "0x18380C630")]
	public static NLPIAAOFKEO<TMNode?> JBAKOMDCPOC<TMNode>(this DLPJIHMBLCO<TMNode> NFOGFJOGLPE, NLPIAAOFKEO<TMNode> DFPCBMGPBFO)
	{
		return default(NLPIAAOFKEO<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x380C280", Offset = "0x380AA80", VA = "0x18380C280")]
	public static void IHLFGIKCBJJ<TMNode>(this DLPJIHMBLCO<TMNode> NFOGFJOGLPE, NLPIAAOFKEO<TMNode> MLBCMOLHELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x380BF00", Offset = "0x380A700", VA = "0x18380BF00")]
	public static bool EEIMJJONDNM<TMNode>([In] this DLPJIHMBLCO<TMNode> NFOGFJOGLPE, NLPIAAOFKEO<TMNode> MLBCMOLHELH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x380BFC0", Offset = "0x380A7C0", VA = "0x18380BFC0")]
	public static NLPIAAOFKEO<TMNode?> ENELMFFLDAO<TMNode>([In] this DLPJIHMBLCO<TMNode> NFOGFJOGLPE, NLPIAAOFKEO<TMNode> MLBCMOLHELH)
	{
		return default(NLPIAAOFKEO<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x380CEC0", Offset = "0x380B6C0", VA = "0x18380CEC0")]
	public static NLPIAAOFKEO<TMNode?>? PBDECGAMKIA<TMNode>([In] this DLPJIHMBLCO<TMNode> NFOGFJOGLPE, NLPIAAOFKEO<TMNode> MLBCMOLHELH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x380C0D0", Offset = "0x380A8D0", VA = "0x18380C0D0")]
	public static void HPFNBCNEJHD<TMNode>(this DLPJIHMBLCO<TMNode> NFOGFJOGLPE, NLPIAAOFKEO<TMNode> MLBCMOLHELH, NLPIAAOFKEO<TMNode> JGGJMMJEBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x380B980", Offset = "0x380A180", VA = "0x18380B980")]
	public static GCOMBNOPDLG<NLPIAAOFKEO<TMNode?>, PFLMDAPEOIN<NLPIAAOFKEO<TMNode?>>.FCGDBKGLPLM> CGECBEEEFOF<TMNode>([In] this DLPJIHMBLCO<TMNode> NFOGFJOGLPE, NLPIAAOFKEO<TMNode> MLBCMOLHELH)
	{
		return default(GCOMBNOPDLG<NLPIAAOFKEO<TMNode>, PFLMDAPEOIN<NLPIAAOFKEO<TMNode>>.FCGDBKGLPLM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0")]
	public static DPFLMJLLNFF<TMNode?> IHFAAOBBDAN<TMNode>([In] this DLPJIHMBLCO<TMNode> NFOGFJOGLPE)
	{
		return default(DPFLMJLLNFF<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x380BC10", Offset = "0x380A410", VA = "0x18380BC10")]
	public static DPFLMJLLNFF<TMNode?>.IBBHMEAIIGI DPNIJJHCOGM<TMNode>([In] this DLPJIHMBLCO<TMNode> NFOGFJOGLPE)
	{
		return default(DPFLMJLLNFF<TMNode>.IBBHMEAIIGI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x380C5E0", Offset = "0x380ADE0", VA = "0x18380C5E0")]
	public static PFNCDBFLBAH<NLPIAAOFKEO<TMNode?>, DPFLMJLLNFF<TMNode?>.IBBHMEAIIGI> IMMJCGFCONH<TMNode>([In] this DLPJIHMBLCO<TMNode> NFOGFJOGLPE)
	{
		return default(PFNCDBFLBAH<NLPIAAOFKEO<TMNode>, DPFLMJLLNFF<TMNode>.IBBHMEAIIGI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x380BFF0", Offset = "0x380A7F0", VA = "0x18380BFF0")]
	public static bool GELLBICOFEE<TMNode>([In] this DLPJIHMBLCO<TMNode> NFOGFJOGLPE, NLPIAAOFKEO<TMNode> GDFCBMOFMFN, NLPIAAOFKEO<TMNode> BILFPHLBMLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x380CE10", Offset = "0x380B610", VA = "0x18380CE10")]
	public static PFNCDBFLBAH<NLPIAAOFKEO<TMNode?>, BFNOFNGICCN<TMNode?>> NPGNOKNENCP<TMNode>([In] this DLPJIHMBLCO<TMNode> NFOGFJOGLPE, NLPIAAOFKEO<TMNode> GDFCBMOFMFN)
	{
		return default(PFNCDBFLBAH<NLPIAAOFKEO<TMNode>, BFNOFNGICCN<TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class MAJINAGFNNF
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x38A48D0", Offset = "0x38A30D0", VA = "0x1838A48D0")]
	public static DLPJIHMBLCO<TMNode> MPBEICGIKAG<TMNode>(this MPDGNLIPDBD NFOGFJOGLPE) where TMNode : notnull
	{
		return default(DLPJIHMBLCO<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x277F5A0", Offset = "0x277DDA0", VA = "0x18277F5A0")]
	public static void IHLFGIKCBJJ(this MPDGNLIPDBD NFOGFJOGLPE, int MLBCMOLHELH)
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
