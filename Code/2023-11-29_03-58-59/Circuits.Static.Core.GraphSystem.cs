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
		[Cpp2IlInjected.Address(RVA = "0x1CCE940", Offset = "0x1CCDD40", VA = "0x181CCE940")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A92C10", Offset = "0x3A92010", VA = "0x183A92C10", Slot = "4")]
		get
		{
			return default(JLMPPIICGFM<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3A92AB0", Offset = "0x3A91EB0", VA = "0x183A92AB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3A92B40", Offset = "0x3A91F40", VA = "0x183A92B40")]
	internal LHLAEJHDDKN([In] OCOBLFLCDBE<TMInput, TMOutput, TMNode> FHIDLDMKIAD, [In] JLGDDKAIMOG<TMInput, TMOutput, TMNode> IKGJGLDOACL, bool HCHJHNALEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3A92970", Offset = "0x3A91D70", VA = "0x183A92970", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3A92A30", Offset = "0x3A91E30", VA = "0x183A92A30", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3A928F0", Offset = "0x3A91CF0", VA = "0x183A928F0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FIIBNHMHGHE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x24FD8A0", Offset = "0x24FCCA0", VA = "0x1824FD8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3909500", Offset = "0x3908900", VA = "0x183909500", Slot = "4")]
		get
		{
			return default(JLMPPIICGFM<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x39093D0", Offset = "0x39087D0", VA = "0x1839093D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3909480", Offset = "0x3908880", VA = "0x183909480")]
	internal JLGDDKAIMOG([In] HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>.LMFENLOPODE GEPFOFIKPFF, [In] HLOKAJPLCDB<JLMPPIICGFM<TMInput>>.LMFENLOPODE HFEMJGFCEEP, [In] PNDCAPNIBAO<TMInput, TMOutput, TMNode> CGIIGHBDHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3909200", Offset = "0x3908600", VA = "0x183909200", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3909360", Offset = "0x3908760", VA = "0x183909360", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3909190", Offset = "0x3908590", VA = "0x183909190", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CCAGIBBBKIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2332C40", Offset = "0x2332040", VA = "0x182332C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x3909500", Offset = "0x3908900", VA = "0x183909500", Slot = "4")]
		get
		{
			return default(JLMPPIICGFM<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x39093D0", Offset = "0x39087D0", VA = "0x1839093D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3909480", Offset = "0x3908880", VA = "0x183909480")]
	internal OCOBLFLCDBE([In] HLOKAJPLCDB<JLMPPIICGFM<TMInput>>.LMFENLOPODE CMDNDNJBMDD, [In] HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>.LMFENLOPODE GBJAONHNNDG, [In] FKDOPLKDGBB<TMInput, TMOutput, TMNode> DGKDOPLIJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3909200", Offset = "0x3908600", VA = "0x183909200", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3909360", Offset = "0x3908760", VA = "0x183909360", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3909190", Offset = "0x3908590", VA = "0x183909190", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class MFAFOHJMNEH
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x25A2C00", Offset = "0x25A2000", VA = "0x1825A2C00")]
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
	[Cpp2IlInjected.Address(RVA = "0x457B880", Offset = "0x457AC80", VA = "0x18457B880")]
	internal BKIOCBBIGBG([In] FKDOPLKDGBB<TMInput, TMOutput, TMNode> DGKDOPLIJNF, [In] PNDCAPNIBAO<TMInput, TMOutput, TMNode> CGIIGHBDHFK, [In] NMLBBNIIDBJ<TMInput, TMOutput, TMNode> GBCBLAELKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x457B5D0", Offset = "0x457A9D0", VA = "0x18457B5D0")]
	public static BKIOCBBIGBG<TMInput?, TMOutput?, TMNode?> PBDMNAJCIOP()
	{
		return default(BKIOCBBIGBG<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class IJFPBKNDBGP
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2541D30", Offset = "0x2541130", VA = "0x182541D30")]
	public static LANJKLGMODP? ALIOEPOJFBC<TMInput, TMOutput, TMNode>([In] this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2542630", Offset = "0x2541A30", VA = "0x182542630")]
	public static BKIOCBBIGBG<TMInput?, TMOutput?, TMNode?> JKMDPBEAKHM<TMInput, TMOutput, TMNode>(this LANJKLGMODP EAODMOEAJOC)
	{
		return default(BKIOCBBIGBG<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2541F30", Offset = "0x2541330", VA = "0x182541F30")]
	public static void DIHPMBNDHDJ<TMInput, TMOutput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2541EC0", Offset = "0x25412C0", VA = "0x182541EC0")]
	public static void CNEBIAELCFA<TMInput, TMOutput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> AMEJPNELJNL, JLMPPIICGFM<TMInput> HKPLMMDDJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2542B90", Offset = "0x2541F90", VA = "0x182542B90")]
	public static void OHBEEADEOGM<TMInput, TMOutput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> AMEJPNELJNL, JLMPPIICGFM<TMInput> HKPLMMDDJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x25421B0", Offset = "0x25415B0", VA = "0x1825421B0")]
	public static bool HLPEBMNADOC<TMInput, TMOutput, TMNode>([In] this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> AMEJPNELJNL, JLMPPIICGFM<TMInput> HKPLMMDDJKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2542B00", Offset = "0x2541F00", VA = "0x182542B00")]
	public static JLMPPIICGFM<TMNode?> NDFLBMIDOIN<TMNode, TMInput, TMOutput>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
		return default(JLMPPIICGFM<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2542410", Offset = "0x2541810", VA = "0x182542410")]
	public static void IHEFNMGFILG<TMInput, TMOutput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> OLLLMHFOLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x25429A0", Offset = "0x2541DA0", VA = "0x1825429A0")]
	public static JLMPPIICGFM<TMInput?> KECCKOIPIJC<TMInput, TMOutput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> OLLLMHFOLHJ)
	{
		return default(JLMPPIICGFM<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2542A10", Offset = "0x2541E10", VA = "0x182542A10")]
	public static JLMPPIICGFM<TMOutput?> LIJCOJPJOAO<TMOutput, TMInput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> OLLLMHFOLHJ)
	{
		return default(JLMPPIICGFM<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2542A80", Offset = "0x2541E80", VA = "0x182542A80")]
	public static JLMPPIICGFM<TMInput?> MFIDJNIJPJE<TMInput, TMOutput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> OLLLMHFOLHJ, int DIENMHDGFGP)
	{
		return default(JLMPPIICGFM<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2542CE0", Offset = "0x25420E0", VA = "0x182542CE0")]
	public static JLMPPIICGFM<TMOutput?> PPHGAKHNNEG<TMOutput, TMInput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> OLLLMHFOLHJ, int DIENMHDGFGP)
	{
		return default(JLMPPIICGFM<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2542110", Offset = "0x2541510", VA = "0x182542110")]
	public static void HHAINKDHMGA<TMInput, TMOutput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> OLLLMHFOLHJ, int KONMHAPMBJO, int HFKOPDAKCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2542070", Offset = "0x2541470", VA = "0x182542070")]
	public static void HBNGOLEOEIB<TMInput, TMOutput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> OLLLMHFOLHJ, int KONMHAPMBJO, int HFKOPDAKCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2542BF0", Offset = "0x2541FF0", VA = "0x182542BF0")]
	public static void ONNAIHHNMJB<TMInput, TMOutput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMInput> PGFPAAAJLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2541F90", Offset = "0x2541390", VA = "0x182541F90")]
	public static void GJKEIMJMMDM<TMInput, TMOutput, TMNode>(this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> FAHIGLLICML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x848F60", Offset = "0x848360", VA = "0x180848F60")]
	public static OCOELDLOPMI<TMInput?> FKHLCNKAECN<TMInput, TMOutput, TMNode>([In] this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
		return default(OCOELDLOPMI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2541D20", Offset = "0x2541120", VA = "0x182541D20")]
	public static OCOELDLOPMI<TMOutput?> AKFDCHIBFKF<TMOutput, TMInput, TMNode>([In] this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
		return default(OCOELDLOPMI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2541F20", Offset = "0x2541320", VA = "0x182541F20")]
	public static OCOELDLOPMI<TMNode?> CPAJMDKJFIE<TMNode, TMInput, TMOutput>([In] this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
		return default(OCOELDLOPMI<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2541CB0", Offset = "0x25410B0", VA = "0x182541CB0")]
	public static JLGDDKAIMOG<TMInput?, TMOutput?, TMNode?> ABLBBMIIPOD<TMInput, TMOutput, TMNode>([In] this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(JLGDDKAIMOG<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2541CB0", Offset = "0x25410B0", VA = "0x182541CB0")]
	public static OCOBLFLCDBE<TMInput?, TMOutput?, TMNode?> NAOEEPNNONK<TMInput, TMOutput, TMNode>([In] this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(OCOBLFLCDBE<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2541E10", Offset = "0x2541210", VA = "0x182541E10")]
	public static LHLAEJHDDKN<TMInput?, TMOutput?, TMNode?> BMAPPELFJCL<TMInput, TMOutput, TMNode>([In] this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(LHLAEJHDDKN<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2542520", Offset = "0x2541920", VA = "0x182542520")]
	public static NKIBEBFNDJA<JLMPPIICGFM<TMInput?>, JLGDDKAIMOG<TMInput?, TMOutput?, TMNode?>> IKMODOGLHEH<TMInput, TMOutput, TMNode>([In] this BKIOCBBIGBG<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(NKIBEBFNDJA<JLMPPIICGFM<TMInput>, JLGDDKAIMOG<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2542280", Offset = "0x2541680", VA = "0x182542280")]
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
	[Cpp2IlInjected.Address(RVA = "0x34721A0", Offset = "0x34715A0", VA = "0x1834721A0")]
	internal FKDOPLKDGBB([In] OCOELDLOPMI<TMInput> GGLAHGHFNGH, [In] IPBJPLPEBMD<TMInput, JLMPPIICGFM<TMNode>> GBCBLAELKEL, [In] IPBJPLPEBMD<TMInput, HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>> CGIIGHBDHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3471FE0", Offset = "0x34713E0", VA = "0x183471FE0")]
	internal static FKDOPLKDGBB<TMInput, TMOutput, TMNode> PBDMNAJCIOP()
	{
		return default(FKDOPLKDGBB<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GDAJEGEIPMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x250A440", Offset = "0x2509840", VA = "0x18250A440")]
	internal static HGMMPDBFMNK ALIOEPOJFBC<TMInput, TMOutput, TMNode>([In] this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x250AF40", Offset = "0x250A340", VA = "0x18250AF40")]
	internal static FKDOPLKDGBB<TMInput, TMOutput, TMNode> JKMDPBEAKHM<TMInput, TMOutput, TMNode>(this HGMMPDBFMNK EAODMOEAJOC)
	{
		return default(FKDOPLKDGBB<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x250ACD0", Offset = "0x250A0D0", VA = "0x18250ACD0")]
	private static DJHKGCHHNAL HAFLPJIJBKB<TMOutput>([In] this HLOKAJPLCDB<JLMPPIICGFM<TMOutput>> EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x250A7D0", Offset = "0x2509BD0", VA = "0x18250A7D0")]
	private static HLOKAJPLCDB<JLMPPIICGFM<TMOutput>> DGHGACNBGLN<TMOutput>(this DJHKGCHHNAL EAODMOEAJOC)
	{
		return default(HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x250AA50", Offset = "0x2509E50", VA = "0x18250AA50")]
	internal static void DIHPMBNDHDJ<TMInput, TMOutput, TMNode>(this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x250AEA0", Offset = "0x250A2A0", VA = "0x18250AEA0")]
	internal static JLMPPIICGFM<TMInput> JJFGHGNGJII<TMInput, TMOutput, TMNode>(this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> JKACDAAJHJD)
	{
		return default(JLMPPIICGFM<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x250AC40", Offset = "0x250A040", VA = "0x18250AC40")]
	internal static void FHBGBJJCKEM<TMInput, TMOutput, TMNode>(this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMInput> EPDCALNHKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2349470", Offset = "0x2348870", VA = "0x182349470")]
	public static bool ALLBKFLILAE<TMInput, TMOutput, TMNode>([In] this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMInput> EPDCALNHKAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x250B450", Offset = "0x250A850", VA = "0x18250B450")]
	public static JLMPPIICGFM<TMNode> JPDPGDCHHOO<TMNode, TMInput, TMOutput>([In] this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMInput> EPDCALNHKAP)
	{
		return default(JLMPPIICGFM<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x250B470", Offset = "0x250A870", VA = "0x18250B470")]
	public static int PHMNNAEIFHL<TMInput, TMOutput, TMNode>([In] this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMInput> EPDCALNHKAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x250A3F0", Offset = "0x25097F0", VA = "0x18250A3F0")]
	public static JLMPPIICGFM<TMOutput> AINMPDAAKDK<TMOutput, TMInput, TMNode>([In] this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMInput> EPDCALNHKAP, int DIENMHDGFGP)
	{
		return default(JLMPPIICGFM<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x250A3B0", Offset = "0x25097B0", VA = "0x18250A3B0")]
	internal static void AEPIFIFJIFI<TMInput, TMOutput, TMNode>(this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMInput> EPDCALNHKAP, JLMPPIICGFM<TMOutput> FAHIGLLICML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x250A3B0", Offset = "0x25097B0", VA = "0x18250A3B0")]
	internal static void HLJFNMIDEOC<TMInput, TMOutput, TMNode>(this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMInput> EPDCALNHKAP, JLMPPIICGFM<TMOutput> FAHIGLLICML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x250ABE0", Offset = "0x2509FE0", VA = "0x18250ABE0")]
	public static HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>.LMFENLOPODE KLOFBLNLEAI<TMOutput, TMInput, TMNode>([In] this FKDOPLKDGBB<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMInput> EPDCALNHKAP)
	{
		return default(HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>.LMFENLOPODE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x250ABE0", Offset = "0x2509FE0", VA = "0x18250ABE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x34721A0", Offset = "0x34715A0", VA = "0x1834721A0")]
	internal NMLBBNIIDBJ([In] OCOELDLOPMI<TMNode> GGLAHGHFNGH, [In] IPBJPLPEBMD<TMNode, HLOKAJPLCDB<JLMPPIICGFM<TMInput>>> DGKDOPLIJNF, [In] IPBJPLPEBMD<TMNode, HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>> CGIIGHBDHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3471FE0", Offset = "0x34713E0", VA = "0x183471FE0")]
	internal static NMLBBNIIDBJ<TMInput, TMOutput, TMNode> PBDMNAJCIOP()
	{
		return default(NMLBBNIIDBJ<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class IKPDMPEBKJB
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x25450B0", Offset = "0x25444B0", VA = "0x1825450B0")]
	internal static OLPJHDOLLJB ALIOEPOJFBC<TMInput, TMOutput, TMNode>([In] this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2546260", Offset = "0x2545660", VA = "0x182546260")]
	internal static NMLBBNIIDBJ<TMInput, TMOutput, TMNode> JKMDPBEAKHM<TMInput, TMOutput, TMNode>(this OLPJHDOLLJB EAODMOEAJOC)
	{
		return default(NMLBBNIIDBJ<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2545FC0", Offset = "0x25453C0", VA = "0x182545FC0")]
	private static GGBCCPHOOEH HLLFECFNLLJ<TMInput>([In] this HLOKAJPLCDB<JLMPPIICGFM<TMInput>> EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2545790", Offset = "0x2544B90", VA = "0x182545790")]
	private static HLOKAJPLCDB<JLMPPIICGFM<TMInput>> FCFOCEHIFKA<TMInput>(this GGBCCPHOOEH EAODMOEAJOC)
	{
		return default(HLOKAJPLCDB<JLMPPIICGFM<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2545B70", Offset = "0x2544F70", VA = "0x182545B70")]
	private static IDDELBIBDBL GNALIFHAAOG<TMOutput>([In] this HLOKAJPLCDB<JLMPPIICGFM<TMOutput>> EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2545D40", Offset = "0x2545140", VA = "0x182545D40")]
	private static HLOKAJPLCDB<JLMPPIICGFM<TMOutput>> HHJNONCEMKO<TMOutput>(this IDDELBIBDBL EAODMOEAJOC)
	{
		return default(HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x25454D0", Offset = "0x25448D0", VA = "0x1825454D0")]
	internal static void DIHPMBNDHDJ<TMInput, TMOutput, TMNode>(this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x25461D0", Offset = "0x25455D0", VA = "0x1825461D0")]
	internal static JLMPPIICGFM<TMNode> JJFGHGNGJII<TMNode, TMInput, TMOutput>(this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, [In] HLOKAJPLCDB<JLMPPIICGFM<TMInput>> DGKDOPLIJNF, [In] HLOKAJPLCDB<JLMPPIICGFM<TMOutput>> CGIIGHBDHFK)
	{
		return default(JLMPPIICGFM<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2545A60", Offset = "0x2544E60", VA = "0x182545A60")]
	internal static void FHBGBJJCKEM<TMInput, TMOutput, TMNode>(this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2349470", Offset = "0x2348870", VA = "0x182349470")]
	public static bool ALLBKFLILAE<TMInput, TMOutput, TMNode>([In] this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2546190", Offset = "0x2545590", VA = "0x182546190")]
	public static int JADODMNACMG<TMInput, TMOutput, TMNode>([In] this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x250B470", Offset = "0x250A870", VA = "0x18250B470")]
	public static int PHMNNAEIFHL<TMInput, TMOutput, TMNode>([In] this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2545B20", Offset = "0x2544F20", VA = "0x182545B20")]
	public static JLMPPIICGFM<TMInput> FOMJEHDEBEE<TMInput, TMOutput, TMNode>([In] this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP, int DIENMHDGFGP)
	{
		return default(JLMPPIICGFM<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x250A3F0", Offset = "0x25097F0", VA = "0x18250A3F0")]
	public static JLMPPIICGFM<TMOutput> AINMPDAAKDK<TMOutput, TMInput, TMNode>([In] this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP, int DIENMHDGFGP)
	{
		return default(JLMPPIICGFM<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2546770", Offset = "0x2545B70", VA = "0x182546770")]
	internal static void NBCAFLMADGB<TMInput, TMOutput, TMNode>(this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP, JLMPPIICGFM<TMInput> PGFPAAAJLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x250A3B0", Offset = "0x25097B0", VA = "0x18250A3B0")]
	internal static void AEPIFIFJIFI<TMInput, TMOutput, TMNode>(this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP, JLMPPIICGFM<TMOutput> FAHIGLLICML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x25467B0", Offset = "0x2545BB0", VA = "0x1825467B0")]
	internal static void PMJLJKMMJDC<TMInput, TMOutput, TMNode>(this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP, int DIENMHDGFGP, JLMPPIICGFM<TMInput> PGFPAAAJLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2545A10", Offset = "0x2544E10", VA = "0x182545A10")]
	internal static void FGHLKMKJAKJ<TMInput, TMOutput, TMNode>(this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP, int DIENMHDGFGP, JLMPPIICGFM<TMOutput> FAHIGLLICML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2546770", Offset = "0x2545B70", VA = "0x182546770")]
	internal static void JMKAIPNFNLH<TMInput, TMOutput, TMNode>(this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP, JLMPPIICGFM<TMInput> PGFPAAAJLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x250A3B0", Offset = "0x25097B0", VA = "0x18250A3B0")]
	internal static void HLJFNMIDEOC<TMInput, TMOutput, TMNode>(this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP, JLMPPIICGFM<TMOutput> FAHIGLLICML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2545470", Offset = "0x2544870", VA = "0x182545470")]
	public static HLOKAJPLCDB<JLMPPIICGFM<TMInput>>.LMFENLOPODE CJLFGNPLLBH<TMInput, TMOutput, TMNode>([In] this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(HLOKAJPLCDB<JLMPPIICGFM<TMInput>>.LMFENLOPODE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x250ABE0", Offset = "0x2509FE0", VA = "0x18250ABE0")]
	public static HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>.LMFENLOPODE KLOFBLNLEAI<TMOutput, TMInput, TMNode>([In] this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>.LMFENLOPODE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2545470", Offset = "0x2544870", VA = "0x182545470")]
	public static GAIFAHOIPAK<JLMPPIICGFM<TMInput>, HLOKAJPLCDB<JLMPPIICGFM<TMInput>>.LMFENLOPODE> JEBFGPIGDHI<TMInput, TMOutput, TMNode>([In] this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(GAIFAHOIPAK<JLMPPIICGFM<TMInput>, HLOKAJPLCDB<JLMPPIICGFM<TMInput>>.LMFENLOPODE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x250ABE0", Offset = "0x2509FE0", VA = "0x18250ABE0")]
	public static GAIFAHOIPAK<JLMPPIICGFM<TMOutput>, HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>.LMFENLOPODE> FDAPCHACHJJ<TMOutput, TMInput, TMNode>([In] this NMLBBNIIDBJ<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> EPDCALNHKAP)
	{
		return default(GAIFAHOIPAK<JLMPPIICGFM<TMOutput>, HLOKAJPLCDB<JLMPPIICGFM<TMOutput>>.LMFENLOPODE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x22CA990", Offset = "0x22C9D90", VA = "0x1822CA990")]
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
	[Cpp2IlInjected.Address(RVA = "0x34721A0", Offset = "0x34715A0", VA = "0x1834721A0")]
	internal PNDCAPNIBAO([In] OCOELDLOPMI<TMOutput> GGLAHGHFNGH, [In] IPBJPLPEBMD<TMOutput, JLMPPIICGFM<TMNode>> GBCBLAELKEL, [In] IPBJPLPEBMD<TMOutput, HLOKAJPLCDB<JLMPPIICGFM<TMInput>>> DGKDOPLIJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3471FE0", Offset = "0x34713E0", VA = "0x183471FE0")]
	internal static PNDCAPNIBAO<TMInput, TMOutput, TMNode> PBDMNAJCIOP()
	{
		return default(PNDCAPNIBAO<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class HDNLOKMMCMA
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x252BB20", Offset = "0x252AF20", VA = "0x18252BB20")]
	internal static BKDOJCENLOO ALIOEPOJFBC<TMInput, TMOutput, TMNode>([In] this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x252C300", Offset = "0x252B700", VA = "0x18252C300")]
	internal static PNDCAPNIBAO<TMInput, TMOutput, TMNode> JKMDPBEAKHM<TMInput, TMOutput, TMNode>(this BKDOJCENLOO EAODMOEAJOC)
	{
		return default(PNDCAPNIBAO<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x252C130", Offset = "0x252B530", VA = "0x18252C130")]
	private static EAHDKFPCHEN EPJEGDCNGPH<TMInput>([In] this HLOKAJPLCDB<JLMPPIICGFM<TMInput>> EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x252BEB0", Offset = "0x252B2B0", VA = "0x18252BEB0")]
	private static HLOKAJPLCDB<JLMPPIICGFM<TMInput>> BMHOOAFCEIP<TMInput>(this EAHDKFPCHEN EAODMOEAJOC)
	{
		return default(HLOKAJPLCDB<JLMPPIICGFM<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x250AA50", Offset = "0x2509E50", VA = "0x18250AA50")]
	internal static void DIHPMBNDHDJ<TMInput, TMOutput, TMNode>(this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x250AEA0", Offset = "0x250A2A0", VA = "0x18250AEA0")]
	internal static JLMPPIICGFM<TMOutput> JJFGHGNGJII<TMOutput, TMInput, TMNode>(this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMNode> JKACDAAJHJD)
	{
		return default(JLMPPIICGFM<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x250AC40", Offset = "0x250A040", VA = "0x18250AC40")]
	internal static void FHBGBJJCKEM<TMInput, TMOutput, TMNode>(this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> EPDCALNHKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2349470", Offset = "0x2348870", VA = "0x182349470")]
	public static bool ALLBKFLILAE<TMInput, TMOutput, TMNode>([In] this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> EPDCALNHKAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x250B450", Offset = "0x250A850", VA = "0x18250B450")]
	public static JLMPPIICGFM<TMNode> JPDPGDCHHOO<TMNode, TMInput, TMOutput>([In] this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> EPDCALNHKAP)
	{
		return default(JLMPPIICGFM<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x250B470", Offset = "0x250A870", VA = "0x18250B470")]
	public static int JADODMNACMG<TMInput, TMOutput, TMNode>([In] this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> EPDCALNHKAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x250A3F0", Offset = "0x25097F0", VA = "0x18250A3F0")]
	public static JLMPPIICGFM<TMInput> FOMJEHDEBEE<TMInput, TMOutput, TMNode>([In] this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> EPDCALNHKAP, int DIENMHDGFGP)
	{
		return default(JLMPPIICGFM<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x250A3B0", Offset = "0x25097B0", VA = "0x18250A3B0")]
	internal static void NBCAFLMADGB<TMInput, TMOutput, TMNode>(this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> EPDCALNHKAP, JLMPPIICGFM<TMInput> PGFPAAAJLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x250A3B0", Offset = "0x25097B0", VA = "0x18250A3B0")]
	internal static void JMKAIPNFNLH<TMInput, TMOutput, TMNode>(this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> EPDCALNHKAP, JLMPPIICGFM<TMInput> PGFPAAAJLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x250ABE0", Offset = "0x2509FE0", VA = "0x18250ABE0")]
	public static HLOKAJPLCDB<JLMPPIICGFM<TMInput>>.LMFENLOPODE CJLFGNPLLBH<TMInput, TMOutput, TMNode>([In] this PNDCAPNIBAO<TMInput, TMOutput, TMNode> EAODMOEAJOC, JLMPPIICGFM<TMOutput> EPDCALNHKAP)
	{
		return default(HLOKAJPLCDB<JLMPPIICGFM<TMInput>>.LMFENLOPODE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x250ABE0", Offset = "0x2509FE0", VA = "0x18250ABE0")]
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
