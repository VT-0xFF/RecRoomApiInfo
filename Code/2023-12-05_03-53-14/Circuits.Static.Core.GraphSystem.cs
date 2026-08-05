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
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CCEB30", Offset = "0x1CCDF30", VA = "0x181CCEB30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79C170", Offset = "0x79B570", VA = "0x18079C170")]
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
		[Cpp2IlInjected.Address(RVA = "0x79C1B0", Offset = "0x79B5B0", VA = "0x18079C1B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LHLAEJHDDKN<TMInput, TMOutput, TMNode> : IEnumerator<JLMPPIICGFM<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private OCOBLFLCDBE<TMInput, TMOutput, TMNode> NMEODFJINMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private JLGDDKAIMOG<TMInput, TMOutput, TMNode> FCJCDJBFOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool IDCFLJHCFLM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly JLMPPIICGFM<TMNode> ADHFGEBEBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3A94080", Offset = "0x3A93480", VA = "0x183A94080", Slot = "4")]
		get
		{
			return default(JLMPPIICGFM<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3A93F20", Offset = "0x3A93320", VA = "0x183A93F20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3A93FB0", Offset = "0x3A933B0", VA = "0x183A93FB0")]
	internal LHLAEJHDDKN([In] OCOBLFLCDBE<TMInput, TMOutput, TMNode> FHIDLDMKIAD, [In] JLGDDKAIMOG<TMInput, TMOutput, TMNode> IKGJGLDOACL, bool HCHJHNALEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3A93DE0", Offset = "0x3A931E0", VA = "0x183A93DE0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3A93EA0", Offset = "0x3A932A0", VA = "0x183A93EA0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3A93D60", Offset = "0x3A93160", VA = "0x183A93D60", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FIIBNHMHGHE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x24FD930", Offset = "0x24FCD30", VA = "0x1824FD930")]
	public static LHLAEJHDDKN<TMInput, TMOutput, TMNode> PBDMNAJCIOP<TMInput, TMOutput, TMNode>([In] BKIOCBBIGBG<TMInput, TMOutput, TMNode> NDNKIIFLGMB, JLMPPIICGFM<TMNode> OLLLMHFOLHJ)
	{
		return default(LHLAEJHDDKN<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct JLGDDKAIMOG<TMInput, TMOutput, TMNode> : IEnumerator<JLMPPIICGFM<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>.LMFENLOPODE AIKAEJOGAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private HLOKAJPLCDB<JLMPPIICGFM<TMInput>>.LMFENLOPODE GCBKGIAOIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly PNDCAPNIBAO<TMInput, TMOutput, TMNode> DAJJDKHNMPG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JLMPPIICGFM<TMInput> ADHFGEBEBLN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x390AAB0", Offset = "0x3909EB0", VA = "0x18390AAB0", Slot = "4")]
		get
		{
			return default(JLMPPIICGFM<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x390A980", Offset = "0x3909D80", VA = "0x18390A980", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x390AA30", Offset = "0x3909E30", VA = "0x18390AA30")]
	internal JLGDDKAIMOG([In] HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>.LMFENLOPODE GEPFOFIKPFF, [In] HLOKAJPLCDB<JLMPPIICGFM<TMInput>>.LMFENLOPODE HFEMJGFCEEP, [In] PNDCAPNIBAO<TMInput, TMOutput, TMNode> CGIIGHBDHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x390A7B0", Offset = "0x3909BB0", VA = "0x18390A7B0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x390A910", Offset = "0x3909D10", VA = "0x18390A910", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x390A740", Offset = "0x3909B40", VA = "0x18390A740", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CCAGIBBBKIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2332CF0", Offset = "0x23320F0", VA = "0x182332CF0")]
	public static JLGDDKAIMOG<TMInput, TMOutput, TMNode> PBDMNAJCIOP<TMInput, TMOutput, TMNode>([In] BKIOCBBIGBG<TMInput, TMOutput, TMNode> NDNKIIFLGMB, JLMPPIICGFM<TMNode> OLLLMHFOLHJ)
	{
		return default(JLGDDKAIMOG<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct OCOBLFLCDBE<TMInput, TMOutput, TMNode> : IEnumerator<JLMPPIICGFM<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HLOKAJPLCDB<JLMPPIICGFM<TMInput>>.LMFENLOPODE OIADBDGCGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>.LMFENLOPODE HGIOLGBBACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly FKDOPLKDGBB<TMInput, TMOutput, TMNode> NDMJCLEALMK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JLMPPIICGFM<TMOutput> ADHFGEBEBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x390AAB0", Offset = "0x3909EB0", VA = "0x18390AAB0", Slot = "4")]
		get
		{
			return default(JLMPPIICGFM<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x390A980", Offset = "0x3909D80", VA = "0x18390A980", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x390AA30", Offset = "0x3909E30", VA = "0x18390AA30")]
	internal OCOBLFLCDBE([In] HLOKAJPLCDB<JLMPPIICGFM<TMInput>>.LMFENLOPODE CMDNDNJBMDD, [In] HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>.LMFENLOPODE GBJAONHNNDG, [In] FKDOPLKDGBB<TMInput, TMOutput, TMNode> DGKDOPLIJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x390A7B0", Offset = "0x3909BB0", VA = "0x18390A7B0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x390A910", Offset = "0x3909D10", VA = "0x18390A910", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x390A740", Offset = "0x3909B40", VA = "0x18390A740", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class MFAFOHJMNEH
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x25A2C90", Offset = "0x25A2090", VA = "0x1825A2C90")]
	public static OCOBLFLCDBE<TMInput, TMOutput, TMNode> PBDMNAJCIOP<TMInput, TMOutput, TMNode>([In] BKIOCBBIGBG<TMInput, TMOutput, TMNode> NDNKIIFLGMB, JLMPPIICGFM<TMNode> OLLLMHFOLHJ)
	{
		return default(OCOBLFLCDBE<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct BKIOCBBIGBG<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public FKDOPLKDGBB<TMInput, TMOutput, TMNode> FDPBHIGMOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public PNDCAPNIBAO<TMInput, TMOutput, TMNode> LBMKNFPKIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NMLBBNIIDBJ<TMInput, TMOutput, TMNode> JLPJFFPLHAC;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x457CCA0", Offset = "0x457C0A0", VA = "0x18457CCA0")]
	internal BKIOCBBIGBG([In] FKDOPLKDGBB<TMInput, TMOutput, TMNode> DGKDOPLIJNF, [In] PNDCAPNIBAO<TMInput, TMOutput, TMNode> CGIIGHBDHFK, [In] NMLBBNIIDBJ<TMInput, TMOutput, TMNode> GBCBLAELKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x457C9F0", Offset = "0x457BDF0", VA = "0x18457C9F0")]
	public static BKIOCBBIGBG<TMInput?, TMOutput?, TMNode?> PBDMNAJCIOP()
	{
		return default(BKIOCBBIGBG<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class IJFPBKNDBGP
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2541DC0", Offset = "0x25411C0", VA = "0x182541DC0")]
	public static LANJKLGMODP? ALIOEPOJFBC<TMInput, TMOutput, TMNode>([In] this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x25426C0", Offset = "0x2541AC0", VA = "0x1825426C0")]
	public static BKIOCBBIGBG<TMInput?, TMOutput?, TMNode?> JKMDPBEAKHM<TMInput, TMOutput, TMNode>(this LANJKLGMODP EAODMOEAJOC)
	{
		return default(BKIOCBBIGBG<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2541FC0", Offset = "0x25413C0", VA = "0x182541FC0")]
	public static void DIHPMBNDHDJ<TMInput, TMOutput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2541F50", Offset = "0x2541350", VA = "0x182541F50")]
	public static void CNEBIAELCFA<TMInput, TMOutput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> AMEJPNELJNL, JLMPPIICGFM<TMInput> HKPLMMDDJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2542C20", Offset = "0x2542020", VA = "0x182542C20")]
	public static void OHBEEADEOGM<TMInput, TMOutput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> AMEJPNELJNL, JLMPPIICGFM<TMInput> HKPLMMDDJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2542240", Offset = "0x2541640", VA = "0x182542240")]
	public static bool HLPEBMNADOC<TMInput, TMOutput, TMNode>([In] this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> AMEJPNELJNL, JLMPPIICGFM<TMInput> HKPLMMDDJKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2542B90", Offset = "0x2541F90", VA = "0x182542B90")]
	public static JLMPPIICGFM<TMNode?> NDFLBMIDOIN<TMNode, TMInput, TMOutput>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
		return default(JLMPPIICGFM<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x25424A0", Offset = "0x25418A0", VA = "0x1825424A0")]
	public static void IHEFNMGFILG<TMInput, TMOutput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> OLLLMHFOLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2542A30", Offset = "0x2541E30", VA = "0x182542A30")]
	public static JLMPPIICGFM<TMInput?> KECCKOIPIJC<TMInput, TMOutput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> OLLLMHFOLHJ)
	{
		return default(JLMPPIICGFM<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2542AA0", Offset = "0x2541EA0", VA = "0x182542AA0")]
	public static JLMPPIICGFM<TMOutput?> LIJCOJPJOAO<TMOutput, TMInput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> OLLLMHFOLHJ)
	{
		return default(JLMPPIICGFM<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2542B10", Offset = "0x2541F10", VA = "0x182542B10")]
	public static JLMPPIICGFM<TMInput?> MFIDJNIJPJE<TMInput, TMOutput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> OLLLMHFOLHJ, int DIENMHDGFGP)
	{
		return default(JLMPPIICGFM<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2542D70", Offset = "0x2542170", VA = "0x182542D70")]
	public static JLMPPIICGFM<TMOutput?> PPHGAKHNNEG<TMOutput, TMInput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> OLLLMHFOLHJ, int DIENMHDGFGP)
	{
		return default(JLMPPIICGFM<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x25421A0", Offset = "0x25415A0", VA = "0x1825421A0")]
	public static void HHAINKDHMGA<TMInput, TMOutput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> OLLLMHFOLHJ, int KONMHAPMBJO, int HFKOPDAKCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2542100", Offset = "0x2541500", VA = "0x182542100")]
	public static void HBNGOLEOEIB<TMInput, TMOutput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> OLLLMHFOLHJ, int KONMHAPMBJO, int HFKOPDAKCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2542C80", Offset = "0x2542080", VA = "0x182542C80")]
	public static void ONNAIHHNMJB<TMInput, TMOutput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMInput> PGFPAAAJLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2542020", Offset = "0x2541420", VA = "0x182542020")]
	public static void GJKEIMJMMDM<TMInput, TMOutput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> FAHIGLLICML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x848FA0", Offset = "0x8483A0", VA = "0x180848FA0")]
	public static OCOELDLOPMI<TMInput?> FKHLCNKAECN<TMInput, TMOutput, TMNode>([In] this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
		return default(OCOELDLOPMI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2541DB0", Offset = "0x25411B0", VA = "0x182541DB0")]
	public static OCOELDLOPMI<TMOutput?> AKFDCHIBFKF<TMOutput, TMInput, TMNode>([In] this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
		return default(OCOELDLOPMI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2541FB0", Offset = "0x25413B0", VA = "0x182541FB0")]
	public static OCOELDLOPMI<TMNode?> CPAJMDKJFIE<TMNode, TMInput, TMOutput>([In] this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
		return default(OCOELDLOPMI<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2541D40", Offset = "0x2541140", VA = "0x182541D40")]
	public static JLGDDKAIMOG<TMInput?, TMOutput?, TMNode?> ABLBBMIIPOD<TMInput, TMOutput, TMNode>([In] this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(JLGDDKAIMOG<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2541D40", Offset = "0x2541140", VA = "0x182541D40")]
	public static OCOBLFLCDBE<TMInput?, TMOutput?, TMNode?> NAOEEPNNONK<TMInput, TMOutput, TMNode>([In] this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(OCOBLFLCDBE<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2541EA0", Offset = "0x25412A0", VA = "0x182541EA0")]
	public static LHLAEJHDDKN<TMInput?, TMOutput?, TMNode?> BMAPPELFJCL<TMInput, TMOutput, TMNode>([In] this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(LHLAEJHDDKN<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x25425B0", Offset = "0x25419B0", VA = "0x1825425B0")]
	public static NKIBEBFNDJA<JLMPPIICGFM<TMInput?>, JLGDDKAIMOG<TMInput?, TMOutput?, TMNode?>> IKMODOGLHEH<TMInput, TMOutput, TMNode>([In] this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(NKIBEBFNDJA<JLMPPIICGFM<TMInput>, JLGDDKAIMOG<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2542310", Offset = "0x2541710", VA = "0x182542310")]
	public static NKIBEBFNDJA<JLMPPIICGFM<TMNode?>, LHLAEJHDDKN<TMInput?, TMOutput?, TMNode?>> IAIEIFOADLO<TMNode, TMInput, TMOutput>([In] this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(NKIBEBFNDJA<JLMPPIICGFM<TMNode>, LHLAEJHDDKN<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct FKDOPLKDGBB<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal OCOELDLOPMI<TMInput> IKCBGOHBJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal IPBJPLPEBMD<TMInput, JLMPPIICGFM<TMNode>> CNKLNMGEAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal IPBJPLPEBMD<TMInput, HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>> DAJJDKHNMPG;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x34738F0", Offset = "0x3472CF0", VA = "0x1834738F0")]
	internal FKDOPLKDGBB([In] OCOELDLOPMI<TMInput> GGLAHGHFNGH, [In] IPBJPLPEBMD<TMInput, JLMPPIICGFM<TMNode>> GBCBLAELKEL, [In] IPBJPLPEBMD<TMInput, HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>> CGIIGHBDHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3473730", Offset = "0x3472B30", VA = "0x183473730")]
	internal static FKDOPLKDGBB<TMInput, TMOutput, TMNode> PBDMNAJCIOP()
	{
		return default(FKDOPLKDGBB<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GDAJEGEIPMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x250A4D0", Offset = "0x25098D0", VA = "0x18250A4D0")]
	internal static HGMMPDBFMNK ALIOEPOJFBC<TMInput, TMOutput, TMNode>([In] this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x250AFD0", Offset = "0x250A3D0", VA = "0x18250AFD0")]
	internal static FKDOPLKDGBB<TMInput, TMOutput, TMNode> JKMDPBEAKHM<TMInput, TMOutput, TMNode>(this HGMMPDBFMNK EAODMOEAJOC)
	{
		return default(FKDOPLKDGBB<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x250AD60", Offset = "0x250A160", VA = "0x18250AD60")]
	private static DJHKGCHHNAL HAFLPJIJBKB<TMOutput>([In] this HLOKAJPLCDB<JLMPPIICGFM<TMOutput>> EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x250A860", Offset = "0x2509C60", VA = "0x18250A860")]
	private static HLOKAJPLCDB<JLMPPIICGFM<TMOutput>> DGHGACNBGLN<TMOutput>(this DJHKGCHHNAL EAODMOEAJOC)
	{
		return default(HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x250AAE0", Offset = "0x2509EE0", VA = "0x18250AAE0")]
	internal static void DIHPMBNDHDJ<TMInput, TMOutput, TMNode>(this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x250AF30", Offset = "0x250A330", VA = "0x18250AF30")]
	internal static JLMPPIICGFM<TMInput> JJFGHGNGJII<TMInput, TMOutput, TMNode>(this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> JKACDAAJHJD)
	{
		return default(JLMPPIICGFM<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x250ACD0", Offset = "0x250A0D0", VA = "0x18250ACD0")]
	internal static void FHBGBJJCKEM<TMInput, TMOutput, TMNode>(this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMInput> EPDCALNHKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2349520", Offset = "0x2348920", VA = "0x182349520")]
	public static bool ALLBKFLILAE<TMInput, TMOutput, TMNode>([In] this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMInput> EPDCALNHKAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x250B4E0", Offset = "0x250A8E0", VA = "0x18250B4E0")]
	public static JLMPPIICGFM<TMNode> JPDPGDCHHOO<TMNode, TMInput, TMOutput>([In] this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMInput> EPDCALNHKAP)
	{
		return default(JLMPPIICGFM<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x250B500", Offset = "0x250A900", VA = "0x18250B500")]
	public static int PHMNNAEIFHL<TMInput, TMOutput, TMNode>([In] this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMInput> EPDCALNHKAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x250A480", Offset = "0x2509880", VA = "0x18250A480")]
	public static JLMPPIICGFM<TMOutput> AINMPDAAKDK<TMOutput, TMInput, TMNode>([In] this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMInput> EPDCALNHKAP, int DIENMHDGFGP)
	{
		return default(JLMPPIICGFM<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x250A440", Offset = "0x2509840", VA = "0x18250A440")]
	internal static void AEPIFIFJIFI<TMInput, TMOutput, TMNode>(this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMInput> EPDCALNHKAP, JLMPPIICGFM<TMOutput> FAHIGLLICML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x250A440", Offset = "0x2509840", VA = "0x18250A440")]
	internal static void HLJFNMIDEOC<TMInput, TMOutput, TMNode>(this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMInput> EPDCALNHKAP, JLMPPIICGFM<TMOutput> FAHIGLLICML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x250AC70", Offset = "0x250A070", VA = "0x18250AC70")]
	public static HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>.LMFENLOPODE KLOFBLNLEAI<TMOutput, TMInput, TMNode>([In] this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMInput> EPDCALNHKAP)
	{
		return default(HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>.LMFENLOPODE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x250AC70", Offset = "0x250A070", VA = "0x18250AC70")]
	public static GAIFAHOIPAK<JLMPPIICGFM<TMOutput>, HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>.LMFENLOPODE> FDAPCHACHJJ<TMOutput, TMInput, TMNode>([In] this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMInput> EPDCALNHKAP)
	{
		return default(GAIFAHOIPAK<JLMPPIICGFM<TMOutput>, HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>.LMFENLOPODE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct NMLBBNIIDBJ<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal OCOELDLOPMI<TMNode> IKCBGOHBJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal IPBJPLPEBMD<TMNode, HLOKAJPLCDB<JLMPPIICGFM<TMInput>>> NDMJCLEALMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal IPBJPLPEBMD<TMNode, HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>> DAJJDKHNMPG;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x34738F0", Offset = "0x3472CF0", VA = "0x1834738F0")]
	internal NMLBBNIIDBJ([In] OCOELDLOPMI<TMNode> GGLAHGHFNGH, [In] IPBJPLPEBMD<TMNode, HLOKAJPLCDB<JLMPPIICGFM<TMInput>>> DGKDOPLIJNF, [In] IPBJPLPEBMD<TMNode, HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>> CGIIGHBDHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3473730", Offset = "0x3472B30", VA = "0x183473730")]
	internal static NMLBBNIIDBJ<TMInput, TMOutput, TMNode> PBDMNAJCIOP()
	{
		return default(NMLBBNIIDBJ<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class IKPDMPEBKJB
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2545140", Offset = "0x2544540", VA = "0x182545140")]
	internal static OLPJHDOLLJB ALIOEPOJFBC<TMInput, TMOutput, TMNode>([In] this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x25462F0", Offset = "0x25456F0", VA = "0x1825462F0")]
	internal static NMLBBNIIDBJ<TMInput, TMOutput, TMNode> JKMDPBEAKHM<TMInput, TMOutput, TMNode>(this OLPJHDOLLJB EAODMOEAJOC)
	{
		return default(NMLBBNIIDBJ<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2546050", Offset = "0x2545450", VA = "0x182546050")]
	private static GGBCCPHOOEH HLLFECFNLLJ<TMInput>([In] this HLOKAJPLCDB<JLMPPIICGFM<TMInput>> EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2545820", Offset = "0x2544C20", VA = "0x182545820")]
	private static HLOKAJPLCDB<JLMPPIICGFM<TMInput>> FCFOCEHIFKA<TMInput>(this GGBCCPHOOEH EAODMOEAJOC)
	{
		return default(HLOKAJPLCDB<JLMPPIICGFM<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2545C00", Offset = "0x2545000", VA = "0x182545C00")]
	private static IDDELBIBDBL GNALIFHAAOG<TMOutput>([In] this HLOKAJPLCDB<JLMPPIICGFM<TMOutput>> EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2545DD0", Offset = "0x25451D0", VA = "0x182545DD0")]
	private static HLOKAJPLCDB<JLMPPIICGFM<TMOutput>> HHJNONCEMKO<TMOutput>(this IDDELBIBDBL EAODMOEAJOC)
	{
		return default(HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2545560", Offset = "0x2544960", VA = "0x182545560")]
	internal static void DIHPMBNDHDJ<TMInput, TMOutput, TMNode>(this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2546260", Offset = "0x2545660", VA = "0x182546260")]
	internal static JLMPPIICGFM<TMNode> JJFGHGNGJII<TMNode, TMInput, TMOutput>(this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, [In] HLOKAJPLCDB<JLMPPIICGFM<TMInput>> DGKDOPLIJNF, [In] HLOKAJPLCDB<JLMPPIICGFM<TMOutput>> CGIIGHBDHFK)
	{
		return default(JLMPPIICGFM<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2545AF0", Offset = "0x2544EF0", VA = "0x182545AF0")]
	internal static void FHBGBJJCKEM<TMInput, TMOutput, TMNode>(this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2349520", Offset = "0x2348920", VA = "0x182349520")]
	public static bool ALLBKFLILAE<TMInput, TMOutput, TMNode>([In] this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2546220", Offset = "0x2545620", VA = "0x182546220")]
	public static int JADODMNACMG<TMInput, TMOutput, TMNode>([In] this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x250B500", Offset = "0x250A900", VA = "0x18250B500")]
	public static int PHMNNAEIFHL<TMInput, TMOutput, TMNode>([In] this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2545BB0", Offset = "0x2544FB0", VA = "0x182545BB0")]
	public static JLMPPIICGFM<TMInput> FOMJEHDEBEE<TMInput, TMOutput, TMNode>([In] this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP, int DIENMHDGFGP)
	{
		return default(JLMPPIICGFM<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x250A480", Offset = "0x2509880", VA = "0x18250A480")]
	public static JLMPPIICGFM<TMOutput> AINMPDAAKDK<TMOutput, TMInput, TMNode>([In] this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP, int DIENMHDGFGP)
	{
		return default(JLMPPIICGFM<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2546800", Offset = "0x2545C00", VA = "0x182546800")]
	internal static void NBCAFLMADGB<TMInput, TMOutput, TMNode>(this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP, JLMPPIICGFM<TMInput> PGFPAAAJLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x250A440", Offset = "0x2509840", VA = "0x18250A440")]
	internal static void AEPIFIFJIFI<TMInput, TMOutput, TMNode>(this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP, JLMPPIICGFM<TMOutput> FAHIGLLICML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2546840", Offset = "0x2545C40", VA = "0x182546840")]
	internal static void PMJLJKMMJDC<TMInput, TMOutput, TMNode>(this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP, int DIENMHDGFGP, JLMPPIICGFM<TMInput> PGFPAAAJLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2545AA0", Offset = "0x2544EA0", VA = "0x182545AA0")]
	internal static void FGHLKMKJAKJ<TMInput, TMOutput, TMNode>(this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP, int DIENMHDGFGP, JLMPPIICGFM<TMOutput> FAHIGLLICML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2546800", Offset = "0x2545C00", VA = "0x182546800")]
	internal static void JMKAIPNFNLH<TMInput, TMOutput, TMNode>(this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP, JLMPPIICGFM<TMInput> PGFPAAAJLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x250A440", Offset = "0x2509840", VA = "0x18250A440")]
	internal static void HLJFNMIDEOC<TMInput, TMOutput, TMNode>(this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP, JLMPPIICGFM<TMOutput> FAHIGLLICML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2545500", Offset = "0x2544900", VA = "0x182545500")]
	public static HLOKAJPLCDB<JLMPPIICGFM<TMInput>>.LMFENLOPODE CJLFGNPLLBH<TMInput, TMOutput, TMNode>([In] this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(HLOKAJPLCDB<JLMPPIICGFM<TMInput>>.LMFENLOPODE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x250AC70", Offset = "0x250A070", VA = "0x18250AC70")]
	public static HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>.LMFENLOPODE KLOFBLNLEAI<TMOutput, TMInput, TMNode>([In] this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>.LMFENLOPODE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2545500", Offset = "0x2544900", VA = "0x182545500")]
	public static GAIFAHOIPAK<JLMPPIICGFM<TMInput>, HLOKAJPLCDB<JLMPPIICGFM<TMInput>>.LMFENLOPODE> JEBFGPIGDHI<TMInput, TMOutput, TMNode>([In] this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(GAIFAHOIPAK<JLMPPIICGFM<TMInput>, HLOKAJPLCDB<JLMPPIICGFM<TMInput>>.LMFENLOPODE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x250AC70", Offset = "0x250A070", VA = "0x18250AC70")]
	public static GAIFAHOIPAK<JLMPPIICGFM<TMOutput>, HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>.LMFENLOPODE> FDAPCHACHJJ<TMOutput, TMInput, TMNode>([In] this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(GAIFAHOIPAK<JLMPPIICGFM<TMOutput>, HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>.LMFENLOPODE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x22CAA50", Offset = "0x22C9E50", VA = "0x1822CAA50")]
	public static NKIBEBFNDJA<JLMPPIICGFM<TMNode>, OCOELDLOPMI<TMNode>.ALJFABKEDPF> EHCFEGLEEGL<TMNode, TMInput, TMOutput>([In] this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
		return default(NKIBEBFNDJA<JLMPPIICGFM<TMNode>, OCOELDLOPMI<TMNode>.ALJFABKEDPF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct PNDCAPNIBAO<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal OCOELDLOPMI<TMOutput> IKCBGOHBJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal IPBJPLPEBMD<TMOutput, JLMPPIICGFM<TMNode>> CNKLNMGEAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal IPBJPLPEBMD<TMOutput, HLOKAJPLCDB<JLMPPIICGFM<TMInput>>> NDMJCLEALMK;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x34738F0", Offset = "0x3472CF0", VA = "0x1834738F0")]
	internal PNDCAPNIBAO([In] OCOELDLOPMI<TMOutput> GGLAHGHFNGH, [In] IPBJPLPEBMD<TMOutput, JLMPPIICGFM<TMNode>> GBCBLAELKEL, [In] IPBJPLPEBMD<TMOutput, HLOKAJPLCDB<JLMPPIICGFM<TMInput>>> DGKDOPLIJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3473730", Offset = "0x3472B30", VA = "0x183473730")]
	internal static PNDCAPNIBAO<TMInput, TMOutput, TMNode> PBDMNAJCIOP()
	{
		return default(PNDCAPNIBAO<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class HDNLOKMMCMA
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x252BBB0", Offset = "0x252AFB0", VA = "0x18252BBB0")]
	internal static BKDOJCENLOO ALIOEPOJFBC<TMInput, TMOutput, TMNode>([In] this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x252C390", Offset = "0x252B790", VA = "0x18252C390")]
	internal static PNDCAPNIBAO<TMInput, TMOutput, TMNode> JKMDPBEAKHM<TMInput, TMOutput, TMNode>(this BKDOJCENLOO EAODMOEAJOC)
	{
		return default(PNDCAPNIBAO<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x252C1C0", Offset = "0x252B5C0", VA = "0x18252C1C0")]
	private static EAHDKFPCHEN EPJEGDCNGPH<TMInput>([In] this HLOKAJPLCDB<JLMPPIICGFM<TMInput>> EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x252BF40", Offset = "0x252B340", VA = "0x18252BF40")]
	private static HLOKAJPLCDB<JLMPPIICGFM<TMInput>> BMHOOAFCEIP<TMInput>(this EAHDKFPCHEN EAODMOEAJOC)
	{
		return default(HLOKAJPLCDB<JLMPPIICGFM<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x250AAE0", Offset = "0x2509EE0", VA = "0x18250AAE0")]
	internal static void DIHPMBNDHDJ<TMInput, TMOutput, TMNode>(this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x250AF30", Offset = "0x250A330", VA = "0x18250AF30")]
	internal static JLMPPIICGFM<TMOutput> JJFGHGNGJII<TMOutput, TMInput, TMNode>(this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> JKACDAAJHJD)
	{
		return default(JLMPPIICGFM<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x250ACD0", Offset = "0x250A0D0", VA = "0x18250ACD0")]
	internal static void FHBGBJJCKEM<TMInput, TMOutput, TMNode>(this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> EPDCALNHKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2349520", Offset = "0x2348920", VA = "0x182349520")]
	public static bool ALLBKFLILAE<TMInput, TMOutput, TMNode>([In] this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> EPDCALNHKAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x250B4E0", Offset = "0x250A8E0", VA = "0x18250B4E0")]
	public static JLMPPIICGFM<TMNode> JPDPGDCHHOO<TMNode, TMInput, TMOutput>([In] this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> EPDCALNHKAP)
	{
		return default(JLMPPIICGFM<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x250B500", Offset = "0x250A900", VA = "0x18250B500")]
	public static int JADODMNACMG<TMInput, TMOutput, TMNode>([In] this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> EPDCALNHKAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x250A480", Offset = "0x2509880", VA = "0x18250A480")]
	public static JLMPPIICGFM<TMInput> FOMJEHDEBEE<TMInput, TMOutput, TMNode>([In] this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> EPDCALNHKAP, int DIENMHDGFGP)
	{
		return default(JLMPPIICGFM<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x250A440", Offset = "0x2509840", VA = "0x18250A440")]
	internal static void NBCAFLMADGB<TMInput, TMOutput, TMNode>(this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> EPDCALNHKAP, JLMPPIICGFM<TMInput> PGFPAAAJLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x250A440", Offset = "0x2509840", VA = "0x18250A440")]
	internal static void JMKAIPNFNLH<TMInput, TMOutput, TMNode>(this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> EPDCALNHKAP, JLMPPIICGFM<TMInput> PGFPAAAJLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x250AC70", Offset = "0x250A070", VA = "0x18250AC70")]
	public static HLOKAJPLCDB<JLMPPIICGFM<TMInput>>.LMFENLOPODE CJLFGNPLLBH<TMInput, TMOutput, TMNode>([In] this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> EPDCALNHKAP)
	{
		return default(HLOKAJPLCDB<JLMPPIICGFM<TMInput>>.LMFENLOPODE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x250AC70", Offset = "0x250A070", VA = "0x18250AC70")]
	public static GAIFAHOIPAK<JLMPPIICGFM<TMInput>, HLOKAJPLCDB<JLMPPIICGFM<TMInput>>.LMFENLOPODE> JEBFGPIGDHI<TMInput, TMOutput, TMNode>([In] this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> EPDCALNHKAP)
	{
		return default(GAIFAHOIPAK<JLMPPIICGFM<TMInput>, HLOKAJPLCDB<JLMPPIICGFM<TMInput>>.LMFENLOPODE>);
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
