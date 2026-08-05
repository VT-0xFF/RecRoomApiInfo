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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1E58F20", Offset = "0x1E58120", VA = "0x181E58F20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DF880", Offset = "0x7DEA80", VA = "0x1807DF880")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8C0", Offset = "0x7DEAC0", VA = "0x1807DF8C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JOBEACPABJJ<TMInput, TMOutput, TMNode> : IEnumerator<EIPPGFCFCGI<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private FKCDPHJMFIF<TMInput, TMOutput, TMNode> EGHNPIGEEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private EOMGEBJBIHA<TMInput, TMOutput, TMNode> AAKFEENBOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool IHMFDADPKBO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly EIPPGFCFCGI<TMNode> DCJELCPGFEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3C33AC0", Offset = "0x3C32CC0", VA = "0x183C33AC0", Slot = "4")]
		get
		{
			return default(EIPPGFCFCGI<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3C33970", Offset = "0x3C32B70", VA = "0x183C33970", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3C339F0", Offset = "0x3C32BF0", VA = "0x183C339F0")]
	internal JOBEACPABJJ([In] FKCDPHJMFIF<TMInput, TMOutput, TMNode> BLICMPHDCHA, [In] EOMGEBJBIHA<TMInput, TMOutput, TMNode> CKDJGNAIJKL, bool JGHLMADPNEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3C33830", Offset = "0x3C32A30", VA = "0x183C33830", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3C338F0", Offset = "0x3C32AF0", VA = "0x183C338F0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3C337C0", Offset = "0x3C329C0", VA = "0x183C337C0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KAHBBKOEOPI
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2974900", Offset = "0x2973B00", VA = "0x182974900")]
	public static JOBEACPABJJ<TMInput, TMOutput, TMNode> MIJABIECKKD<TMInput, TMOutput, TMNode>([In] LKJAOCMKMPC<TMInput, TMOutput, TMNode> CFJAGNGILDN, EIPPGFCFCGI<TMNode> EPGOCEDJKAG)
	{
		return default(JOBEACPABJJ<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct EOMGEBJBIHA<TMInput, TMOutput, TMNode> : IEnumerator<EIPPGFCFCGI<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>>.BAFEGDGPEGK EFBFPLHHFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private FNBPBCOGKJO<EIPPGFCFCGI<TMInput>>.BAFEGDGPEGK INAOJKLKDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly LOGLODBOHBJ<TMInput, TMOutput, TMNode> GPMMCBNBKGP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EIPPGFCFCGI<TMInput> DCJELCPGFEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x34A6CD0", Offset = "0x34A5ED0", VA = "0x1834A6CD0", Slot = "4")]
		get
		{
			return default(EIPPGFCFCGI<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x34A6BB0", Offset = "0x34A5DB0", VA = "0x1834A6BB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x34A6C50", Offset = "0x34A5E50", VA = "0x1834A6C50")]
	internal EOMGEBJBIHA([In] FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>>.BAFEGDGPEGK BNHKCGBGOPB, [In] FNBPBCOGKJO<EIPPGFCFCGI<TMInput>>.BAFEGDGPEGK HNNFCNGDDLK, [In] LOGLODBOHBJ<TMInput, TMOutput, TMNode> DNLOJHNFNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x34A69F0", Offset = "0x34A5BF0", VA = "0x1834A69F0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x34A6B40", Offset = "0x34A5D40", VA = "0x1834A6B40", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x34A6980", Offset = "0x34A5B80", VA = "0x1834A6980", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MACEDEDNCMM
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2999F00", Offset = "0x2999100", VA = "0x182999F00")]
	public static EOMGEBJBIHA<TMInput, TMOutput, TMNode> MIJABIECKKD<TMInput, TMOutput, TMNode>([In] LKJAOCMKMPC<TMInput, TMOutput, TMNode> CFJAGNGILDN, EIPPGFCFCGI<TMNode> EPGOCEDJKAG)
	{
		return default(EOMGEBJBIHA<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct FKCDPHJMFIF<TMInput, TMOutput, TMNode> : IEnumerator<EIPPGFCFCGI<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private FNBPBCOGKJO<EIPPGFCFCGI<TMInput>>.BAFEGDGPEGK HGGFMENJDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>>.BAFEGDGPEGK NOJKGMILIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly CNFMHFAJENG<TMInput, TMOutput, TMNode> KIFPJMLAMMH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public EIPPGFCFCGI<TMOutput> DCJELCPGFEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x34A6CD0", Offset = "0x34A5ED0", VA = "0x1834A6CD0", Slot = "4")]
		get
		{
			return default(EIPPGFCFCGI<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x34A6BB0", Offset = "0x34A5DB0", VA = "0x1834A6BB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x34A6C50", Offset = "0x34A5E50", VA = "0x1834A6C50")]
	internal FKCDPHJMFIF([In] FNBPBCOGKJO<EIPPGFCFCGI<TMInput>>.BAFEGDGPEGK BHJDHCNFEAK, [In] FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>>.BAFEGDGPEGK CPHMOGCKIJM, [In] CNFMHFAJENG<TMInput, TMOutput, TMNode> AOMGHNALNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x34A69F0", Offset = "0x34A5BF0", VA = "0x1834A69F0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x34A6B40", Offset = "0x34A5D40", VA = "0x1834A6B40", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x34A6980", Offset = "0x34A5B80", VA = "0x1834A6980", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GHEAOANAKGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x28E8030", Offset = "0x28E7230", VA = "0x1828E8030")]
	public static FKCDPHJMFIF<TMInput, TMOutput, TMNode> MIJABIECKKD<TMInput, TMOutput, TMNode>([In] LKJAOCMKMPC<TMInput, TMOutput, TMNode> CFJAGNGILDN, EIPPGFCFCGI<TMNode> EPGOCEDJKAG)
	{
		return default(FKCDPHJMFIF<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct LKJAOCMKMPC<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public CNFMHFAJENG<TMInput, TMOutput, TMNode> FCJPDPFIEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public LOGLODBOHBJ<TMInput, TMOutput, TMNode> GJCGBIBILJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public ELMGGAIHNFM<TMInput, TMOutput, TMNode> LCAHJPLIHOP;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3D78170", Offset = "0x3D77370", VA = "0x183D78170")]
	internal LKJAOCMKMPC([In] CNFMHFAJENG<TMInput, TMOutput, TMNode> AOMGHNALNKP, [In] LOGLODBOHBJ<TMInput, TMOutput, TMNode> DNLOJHNFNEH, [In] ELMGGAIHNFM<TMInput, TMOutput, TMNode> FHHLKCLFIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3D77ED0", Offset = "0x3D770D0", VA = "0x183D77ED0")]
	public static LKJAOCMKMPC<TMInput?, TMOutput?, TMNode?> MIJABIECKKD()
	{
		return default(LKJAOCMKMPC<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BHCFGGBDCCD
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x26A85D0", Offset = "0x26A77D0", VA = "0x1826A85D0")]
	public static ICAKAMDADJP? OHDBDPJBHPM<TMInput, TMOutput, TMNode>([In] this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x26A7F90", Offset = "0x26A7190", VA = "0x1826A7F90")]
	public static LKJAOCMKMPC<TMInput?, TMOutput?, TMNode?> LKMADFBDLGL<TMInput, TMOutput, TMNode>(this ICAKAMDADJP KNKOEEEKHDK)
	{
		return default(LKJAOCMKMPC<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x26A7C20", Offset = "0x26A6E20", VA = "0x1826A7C20")]
	public static void HDPILJBHDHI<TMInput, TMOutput, TMNode>(this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x26A74D0", Offset = "0x26A66D0", VA = "0x1826A74D0")]
	public static void AOIBKGGPEIC<TMInput, TMOutput, TMNode>(this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMOutput> CKFEAOMNMAL, EIPPGFCFCGI<TMInput> GCDCBLIMMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x26A8440", Offset = "0x26A7640", VA = "0x1826A8440")]
	public static void NHBNDNEIICI<TMInput, TMOutput, TMNode>(this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMOutput> CKFEAOMNMAL, EIPPGFCFCGI<TMInput> GCDCBLIMMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x26A84A0", Offset = "0x26A76A0", VA = "0x1826A84A0")]
	public static int NPJOGCDJLLP<TMInput, TMOutput, TMNode>([In] this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x26A7620", Offset = "0x26A6820", VA = "0x1826A7620")]
	public static bool CCBPFMNBFDJ<TMInput, TMOutput, TMNode>([In] this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMOutput> CKFEAOMNMAL, EIPPGFCFCGI<TMInput> GCDCBLIMMCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x26A86B0", Offset = "0x26A78B0", VA = "0x1826A86B0")]
	public static bool PFMJDMALIGE<TMInput, TMOutput, TMNode>([In] this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMOutput> GPLIIIGJNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x26A7DE0", Offset = "0x26A6FE0", VA = "0x1826A7DE0")]
	public static bool JCPNEOLLLIJ<TMInput, TMOutput, TMNode>([In] this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMInput> GPLIIIGJNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x26A83B0", Offset = "0x26A75B0", VA = "0x1826A83B0")]
	public static EIPPGFCFCGI<TMNode?> MOBFPIIMFLP<TMNode, TMInput, TMOutput>(this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK)
	{
		return default(EIPPGFCFCGI<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x26A76F0", Offset = "0x26A68F0", VA = "0x1826A76F0")]
	public static void CEGPMIOOEKM<TMInput, TMOutput, TMNode>(this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> EPGOCEDJKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x26A7C80", Offset = "0x26A6E80", VA = "0x1826A7C80")]
	public static EIPPGFCFCGI<TMInput?> HOOJFKFPKHH<TMInput, TMOutput, TMNode>(this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> EPGOCEDJKAG)
	{
		return default(EIPPGFCFCGI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x26A7530", Offset = "0x26A6730", VA = "0x1826A7530")]
	public static EIPPGFCFCGI<TMOutput?> BCCGLLMCKOC<TMOutput, TMInput, TMNode>(this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> EPGOCEDJKAG)
	{
		return default(EIPPGFCFCGI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x26A7BA0", Offset = "0x26A6DA0", VA = "0x1826A7BA0")]
	public static EIPPGFCFCGI<TMInput?> GKNFFKACCKH<TMInput, TMOutput, TMNode>(this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> EPGOCEDJKAG, int HMFNCGHECPG)
	{
		return default(EIPPGFCFCGI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x26A75A0", Offset = "0x26A67A0", VA = "0x1826A75A0")]
	public static EIPPGFCFCGI<TMOutput?> BLADNENPGGC<TMOutput, TMInput, TMNode>(this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> EPGOCEDJKAG, int HMFNCGHECPG)
	{
		return default(EIPPGFCFCGI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x26A7B00", Offset = "0x26A6D00", VA = "0x1826A7B00")]
	public static void DLGCEBEBCEO<TMInput, TMOutput, TMNode>(this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> EPGOCEDJKAG, int CKFCGKJLDOF, int HAOIODLBMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x26A7800", Offset = "0x26A6A00", VA = "0x1826A7800")]
	public static void CIOKPADHNHG<TMInput, TMOutput, TMNode>(this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> EPGOCEDJKAG, int CKFCGKJLDOF, int HAOIODLBMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x26A7CF0", Offset = "0x26A6EF0", VA = "0x1826A7CF0")]
	public static void IJIOFOGHPIF<TMInput, TMOutput, TMNode>(this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMInput> LFBBIJDDIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x26A79B0", Offset = "0x26A6BB0", VA = "0x1826A79B0")]
	public static void CNBHDJBDMGO<TMInput, TMOutput, TMNode>(this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMOutput> JECBHFPMAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
	public static IPKGKGPLLPP<TMInput?> KFAGNMIEINC<TMInput, TMOutput, TMNode>([In] this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK)
	{
		return default(IPKGKGPLLPP<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1E84BD0", Offset = "0x1E83DD0", VA = "0x181E84BD0")]
	public static IPKGKGPLLPP<TMOutput?> FNMJFOGAOGH<TMOutput, TMInput, TMNode>([In] this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK)
	{
		return default(IPKGKGPLLPP<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1E84120", Offset = "0x1E83320", VA = "0x181E84120")]
	public static IPKGKGPLLPP<TMNode?> IJLCLPFJEPD<TMNode, TMInput, TMOutput>([In] this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK)
	{
		return default(IPKGKGPLLPP<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x26A7A90", Offset = "0x26A6C90", VA = "0x1826A7A90")]
	public static EOMGEBJBIHA<TMInput?, TMOutput?, TMNode?> KAKJCKAGFIP<TMInput, TMOutput, TMNode>([In] this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> JNIKIHKLGAD)
	{
		return default(EOMGEBJBIHA<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x26A7A90", Offset = "0x26A6C90", VA = "0x1826A7A90")]
	public static FKCDPHJMFIF<TMInput?, TMOutput?, TMNode?> DCCKHCPMPNF<TMInput, TMOutput, TMNode>([In] this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> JNIKIHKLGAD)
	{
		return default(FKCDPHJMFIF<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x26A8300", Offset = "0x26A7500", VA = "0x1826A8300")]
	public static JOBEACPABJJ<TMInput?, TMOutput?, TMNode?> MCEAHFCDHGE<TMInput, TMOutput, TMNode>([In] this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> JNIKIHKLGAD)
	{
		return default(JOBEACPABJJ<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x26A78A0", Offset = "0x26A6AA0", VA = "0x1826A78A0")]
	public static KDEJKKKPGJL<EIPPGFCFCGI<TMInput?>, EOMGEBJBIHA<TMInput?, TMOutput?, TMNode?>> CKLKDFCJAGD<TMInput, TMOutput, TMNode>([In] this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> JNIKIHKLGAD)
	{
		return default(KDEJKKKPGJL<EIPPGFCFCGI<TMInput>, EOMGEBJBIHA<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x26A7E00", Offset = "0x26A7000", VA = "0x1826A7E00")]
	public static KDEJKKKPGJL<EIPPGFCFCGI<TMNode?>, JOBEACPABJJ<TMInput?, TMOutput?, TMNode?>> LDANKIGFAJA<TMNode, TMInput, TMOutput>([In] this LKJAOCMKMPC<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> JNIKIHKLGAD)
	{
		return default(KDEJKKKPGJL<EIPPGFCFCGI<TMNode>, JOBEACPABJJ<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct CNFMHFAJENG<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal IPKGKGPLLPP<TMInput> DIAAHANLGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal FMGHEKECDOM<TMInput, EIPPGFCFCGI<TMNode>> JALOBPPDGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal FMGHEKECDOM<TMInput, FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>>> GPMMCBNBKGP;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x348D8A0", Offset = "0x348CAA0", VA = "0x18348D8A0")]
	internal CNFMHFAJENG([In] IPKGKGPLLPP<TMInput> DJCOKOPMKGA, [In] FMGHEKECDOM<TMInput, EIPPGFCFCGI<TMNode>> FHHLKCLFIBM, [In] FMGHEKECDOM<TMInput, FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>>> DNLOJHNFNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x348D6F0", Offset = "0x348C8F0", VA = "0x18348D6F0")]
	internal static CNFMHFAJENG<TMInput, TMOutput, TMNode> MIJABIECKKD()
	{
		return default(CNFMHFAJENG<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GIOOFABNJMH
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x28E9730", Offset = "0x28E8930", VA = "0x1828E9730")]
	internal static KDEOPOCBNMP OHDBDPJBHPM<TMInput, TMOutput, TMNode>([In] this CNFMHFAJENG<TMInput, TMOutput, TMNode> KNKOEEEKHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x28E9190", Offset = "0x28E8390", VA = "0x1828E9190")]
	internal static CNFMHFAJENG<TMInput, TMOutput, TMNode> LKMADFBDLGL<TMInput, TMOutput, TMNode>(this KDEOPOCBNMP KNKOEEEKHDK)
	{
		return default(CNFMHFAJENG<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x28E8FC0", Offset = "0x28E81C0", VA = "0x1828E8FC0")]
	private static LOLEMILFGJA IPEBEHBHGGJ<TMOutput>([In] this FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>> KNKOEEEKHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x28E8BA0", Offset = "0x28E7DA0", VA = "0x1828E8BA0")]
	private static FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>> FCOBIEJEPON<TMOutput>(this LOLEMILFGJA KNKOEEEKHDK)
	{
		return default(FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x28E8E10", Offset = "0x28E8010", VA = "0x1828E8E10")]
	internal static void HDPILJBHDHI<TMInput, TMOutput, TMNode>(this CNFMHFAJENG<TMInput, TMOutput, TMNode> KNKOEEEKHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x28E9690", Offset = "0x28E8890", VA = "0x1828E9690")]
	internal static EIPPGFCFCGI<TMInput> OGCLLEGKFLL<TMInput, TMOutput, TMNode>(this CNFMHFAJENG<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> CLKPBALPCKM)
	{
		return default(EIPPGFCFCGI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x28E8B10", Offset = "0x28E7D10", VA = "0x1828E8B10")]
	internal static void EJBBKCPFFPM<TMInput, TMOutput, TMNode>(this CNFMHFAJENG<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMInput> JNIKIHKLGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x26A6EE0", Offset = "0x26A60E0", VA = "0x1826A6EE0")]
	public static bool FJFIJPOJCAC<TMInput, TMOutput, TMNode>([In] this CNFMHFAJENG<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMInput> JNIKIHKLGAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2579160", Offset = "0x2578360", VA = "0x182579160")]
	public static int DMNDCOCNPMP<TMInput, TMOutput, TMNode>([In] this CNFMHFAJENG<TMInput, TMOutput, TMNode> KNKOEEEKHDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x28E8FA0", Offset = "0x28E81A0", VA = "0x1828E8FA0")]
	public static EIPPGFCFCGI<TMNode> IHGABDKJOJE<TMNode, TMInput, TMOutput>([In] this CNFMHFAJENG<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMInput> JNIKIHKLGAD)
	{
		return default(EIPPGFCFCGI<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x277D3A0", Offset = "0x277C5A0", VA = "0x18277D3A0")]
	public static int ANNIDMBOCDO<TMInput, TMOutput, TMNode>([In] this CNFMHFAJENG<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMInput> JNIKIHKLGAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x277E1C0", Offset = "0x277D3C0", VA = "0x18277E1C0")]
	public static EIPPGFCFCGI<TMOutput> LLLIKCJHMNA<TMOutput, TMInput, TMNode>([In] this CNFMHFAJENG<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMInput> JNIKIHKLGAD, int HMFNCGHECPG)
	{
		return default(EIPPGFCFCGI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x277DC20", Offset = "0x277CE20", VA = "0x18277DC20")]
	internal static void KEPIOEKHNFH<TMInput, TMOutput, TMNode>(this CNFMHFAJENG<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMInput> JNIKIHKLGAD, EIPPGFCFCGI<TMOutput> JECBHFPMAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x277DC20", Offset = "0x277CE20", VA = "0x18277DC20")]
	internal static void HOLDFKFPNPK<TMInput, TMOutput, TMNode>(this CNFMHFAJENG<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMInput> JNIKIHKLGAD, EIPPGFCFCGI<TMOutput> JECBHFPMAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2763760", Offset = "0x2762960", VA = "0x182763760")]
	public static FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>>.BAFEGDGPEGK IDAIKIACPAF<TMOutput, TMInput, TMNode>([In] this CNFMHFAJENG<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMInput> JNIKIHKLGAD)
	{
		return default(FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>>.BAFEGDGPEGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2763760", Offset = "0x2762960", VA = "0x182763760")]
	public static KHINJKLEGHI<EIPPGFCFCGI<TMOutput>, FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>>.BAFEGDGPEGK> DENMNEMAHBI<TMOutput, TMInput, TMNode>([In] this CNFMHFAJENG<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMInput> JNIKIHKLGAD)
	{
		return default(KHINJKLEGHI<EIPPGFCFCGI<TMOutput>, FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>>.BAFEGDGPEGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x27207A0", Offset = "0x271F9A0", VA = "0x1827207A0")]
	public static KDEJKKKPGJL<EIPPGFCFCGI<TMInput>, IPKGKGPLLPP<TMInput>.OKBNDEICCIN> LKDIAEGFMFF<TMInput, TMOutput, TMNode>([In] this CNFMHFAJENG<TMInput, TMOutput, TMNode> KNKOEEEKHDK)
	{
		return default(KDEJKKKPGJL<EIPPGFCFCGI<TMInput>, IPKGKGPLLPP<TMInput>.OKBNDEICCIN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct ELMGGAIHNFM<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal IPKGKGPLLPP<TMNode> DIAAHANLGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal FMGHEKECDOM<TMNode, FNBPBCOGKJO<EIPPGFCFCGI<TMInput>>> KIFPJMLAMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal FMGHEKECDOM<TMNode, FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>>> GPMMCBNBKGP;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x348D8A0", Offset = "0x348CAA0", VA = "0x18348D8A0")]
	internal ELMGGAIHNFM([In] IPKGKGPLLPP<TMNode> DJCOKOPMKGA, [In] FMGHEKECDOM<TMNode, FNBPBCOGKJO<EIPPGFCFCGI<TMInput>>> AOMGHNALNKP, [In] FMGHEKECDOM<TMNode, FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>>> DNLOJHNFNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x348D6F0", Offset = "0x348C8F0", VA = "0x18348D6F0")]
	internal static ELMGGAIHNFM<TMInput, TMOutput, TMNode> MIJABIECKKD()
	{
		return default(ELMGGAIHNFM<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class ENGFHFGHJAO
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x277E470", Offset = "0x277D670", VA = "0x18277E470")]
	internal static NBDOKHBKGJP OHDBDPJBHPM<TMInput, TMOutput, TMNode>([In] this ELMGGAIHNFM<TMInput, TMOutput, TMNode> KNKOEEEKHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x277DCC0", Offset = "0x277CEC0", VA = "0x18277DCC0")]
	internal static ELMGGAIHNFM<TMInput, TMOutput, TMNode> LKMADFBDLGL<TMInput, TMOutput, TMNode>(this NBDOKHBKGJP KNKOEEEKHDK)
	{
		return default(ELMGGAIHNFM<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x277D460", Offset = "0x277C660", VA = "0x18277D460")]
	private static AGJGMOOEGBM CFNAFHMMBDM<TMInput>([In] this FNBPBCOGKJO<EIPPGFCFCGI<TMInput>> KNKOEEEKHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x277E900", Offset = "0x277DB00", VA = "0x18277E900")]
	private static FNBPBCOGKJO<EIPPGFCFCGI<TMInput>> PLFBIAPPHDK<TMInput>(this AGJGMOOEGBM KNKOEEEKHDK)
	{
		return default(FNBPBCOGKJO<EIPPGFCFCGI<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x277E210", Offset = "0x277D410", VA = "0x18277E210")]
	private static BFEEPPAIJHJ MLAOPPPDKEJ<TMOutput>([In] this FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>> KNKOEEEKHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x277D630", Offset = "0x277C830", VA = "0x18277D630")]
	private static FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>> EIHEPACFPIJ<TMOutput>(this BFEEPPAIJHJ KNKOEEEKHDK)
	{
		return default(FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x277D960", Offset = "0x277CB60", VA = "0x18277D960")]
	internal static void HDPILJBHDHI<TMInput, TMOutput, TMNode>(this ELMGGAIHNFM<TMInput, TMOutput, TMNode> KNKOEEEKHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x277E3E0", Offset = "0x277D5E0", VA = "0x18277E3E0")]
	internal static EIPPGFCFCGI<TMNode> OGCLLEGKFLL<TMNode, TMInput, TMOutput>(this ELMGGAIHNFM<TMInput, TMOutput, TMNode> KNKOEEEKHDK, [In] FNBPBCOGKJO<EIPPGFCFCGI<TMInput>> AOMGHNALNKP, [In] FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>> DNLOJHNFNEH)
	{
		return default(EIPPGFCFCGI<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x277D8A0", Offset = "0x277CAA0", VA = "0x18277D8A0")]
	internal static void EJBBKCPFFPM<TMInput, TMOutput, TMNode>(this ELMGGAIHNFM<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> JNIKIHKLGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x26A6EE0", Offset = "0x26A60E0", VA = "0x1826A6EE0")]
	public static bool FJFIJPOJCAC<TMInput, TMOutput, TMNode>([In] this ELMGGAIHNFM<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> JNIKIHKLGAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2579160", Offset = "0x2578360", VA = "0x182579160")]
	public static int DMNDCOCNPMP<TMInput, TMOutput, TMNode>([In] this ELMGGAIHNFM<TMInput, TMOutput, TMNode> KNKOEEEKHDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x277D420", Offset = "0x277C620", VA = "0x18277D420")]
	public static int BLBADCABCED<TMInput, TMOutput, TMNode>([In] this ELMGGAIHNFM<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> JNIKIHKLGAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x277D3A0", Offset = "0x277C5A0", VA = "0x18277D3A0")]
	public static int ANNIDMBOCDO<TMInput, TMOutput, TMNode>([In] this ELMGGAIHNFM<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> JNIKIHKLGAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x277E8B0", Offset = "0x277DAB0", VA = "0x18277E8B0")]
	public static EIPPGFCFCGI<TMInput> PHFMEOENMDM<TMInput, TMOutput, TMNode>([In] this ELMGGAIHNFM<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> JNIKIHKLGAD, int HMFNCGHECPG)
	{
		return default(EIPPGFCFCGI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x277E1C0", Offset = "0x277D3C0", VA = "0x18277E1C0")]
	public static EIPPGFCFCGI<TMOutput> LLLIKCJHMNA<TMOutput, TMInput, TMNode>([In] this ELMGGAIHNFM<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> JNIKIHKLGAD, int HMFNCGHECPG)
	{
		return default(EIPPGFCFCGI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x277D3E0", Offset = "0x277C5E0", VA = "0x18277D3E0")]
	internal static void DOKODMMBJKL<TMInput, TMOutput, TMNode>(this ELMGGAIHNFM<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> JNIKIHKLGAD, EIPPGFCFCGI<TMInput> LFBBIJDDIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x277DC20", Offset = "0x277CE20", VA = "0x18277DC20")]
	internal static void KEPIOEKHNFH<TMInput, TMOutput, TMNode>(this ELMGGAIHNFM<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> JNIKIHKLGAD, EIPPGFCFCGI<TMOutput> JECBHFPMAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x277E810", Offset = "0x277DA10", VA = "0x18277E810")]
	internal static void OKFNBCPJLDM<TMInput, TMOutput, TMNode>(this ELMGGAIHNFM<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> JNIKIHKLGAD, int HMFNCGHECPG, EIPPGFCFCGI<TMInput> LFBBIJDDIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x277E860", Offset = "0x277DA60", VA = "0x18277E860")]
	internal static void PFFDPFOPHDG<TMInput, TMOutput, TMNode>(this ELMGGAIHNFM<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> JNIKIHKLGAD, int HMFNCGHECPG, EIPPGFCFCGI<TMOutput> JECBHFPMAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x277D3E0", Offset = "0x277C5E0", VA = "0x18277D3E0")]
	internal static void BKCMEBOEMKK<TMInput, TMOutput, TMNode>(this ELMGGAIHNFM<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> JNIKIHKLGAD, EIPPGFCFCGI<TMInput> LFBBIJDDIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x277DC20", Offset = "0x277CE20", VA = "0x18277DC20")]
	internal static void HOLDFKFPNPK<TMInput, TMOutput, TMNode>(this ELMGGAIHNFM<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> JNIKIHKLGAD, EIPPGFCFCGI<TMOutput> JECBHFPMAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x277DC60", Offset = "0x277CE60", VA = "0x18277DC60")]
	public static FNBPBCOGKJO<EIPPGFCFCGI<TMInput>>.BAFEGDGPEGK KLAGLOIMECB<TMInput, TMOutput, TMNode>([In] this ELMGGAIHNFM<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> JNIKIHKLGAD)
	{
		return default(FNBPBCOGKJO<EIPPGFCFCGI<TMInput>>.BAFEGDGPEGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2763760", Offset = "0x2762960", VA = "0x182763760")]
	public static FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>>.BAFEGDGPEGK IDAIKIACPAF<TMOutput, TMInput, TMNode>([In] this ELMGGAIHNFM<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> JNIKIHKLGAD)
	{
		return default(FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>>.BAFEGDGPEGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x277DC60", Offset = "0x277CE60", VA = "0x18277DC60")]
	public static KHINJKLEGHI<EIPPGFCFCGI<TMInput>, FNBPBCOGKJO<EIPPGFCFCGI<TMInput>>.BAFEGDGPEGK> MPDFBIKEEGD<TMInput, TMOutput, TMNode>([In] this ELMGGAIHNFM<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> JNIKIHKLGAD)
	{
		return default(KHINJKLEGHI<EIPPGFCFCGI<TMInput>, FNBPBCOGKJO<EIPPGFCFCGI<TMInput>>.BAFEGDGPEGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2763760", Offset = "0x2762960", VA = "0x182763760")]
	public static KHINJKLEGHI<EIPPGFCFCGI<TMOutput>, FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>>.BAFEGDGPEGK> DENMNEMAHBI<TMOutput, TMInput, TMNode>([In] this ELMGGAIHNFM<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> JNIKIHKLGAD)
	{
		return default(KHINJKLEGHI<EIPPGFCFCGI<TMOutput>, FNBPBCOGKJO<EIPPGFCFCGI<TMOutput>>.BAFEGDGPEGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x27207A0", Offset = "0x271F9A0", VA = "0x1827207A0")]
	public static KDEJKKKPGJL<EIPPGFCFCGI<TMNode>, IPKGKGPLLPP<TMNode>.OKBNDEICCIN> LKDIAEGFMFF<TMNode, TMInput, TMOutput>([In] this ELMGGAIHNFM<TMInput, TMOutput, TMNode> KNKOEEEKHDK)
	{
		return default(KDEJKKKPGJL<EIPPGFCFCGI<TMNode>, IPKGKGPLLPP<TMNode>.OKBNDEICCIN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LOGLODBOHBJ<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal IPKGKGPLLPP<TMOutput> DIAAHANLGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal FMGHEKECDOM<TMOutput, EIPPGFCFCGI<TMNode>> JALOBPPDGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal FMGHEKECDOM<TMOutput, FNBPBCOGKJO<EIPPGFCFCGI<TMInput>>> KIFPJMLAMMH;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x348D8A0", Offset = "0x348CAA0", VA = "0x18348D8A0")]
	internal LOGLODBOHBJ([In] IPKGKGPLLPP<TMOutput> DJCOKOPMKGA, [In] FMGHEKECDOM<TMOutput, EIPPGFCFCGI<TMNode>> FHHLKCLFIBM, [In] FMGHEKECDOM<TMOutput, FNBPBCOGKJO<EIPPGFCFCGI<TMInput>>> AOMGHNALNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x348D6F0", Offset = "0x348C8F0", VA = "0x18348D6F0")]
	internal static LOGLODBOHBJ<TMInput, TMOutput, TMNode> MIJABIECKKD()
	{
		return default(LOGLODBOHBJ<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class LFBELEDHDEC
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x29833E0", Offset = "0x29825E0", VA = "0x1829833E0")]
	internal static CIOONHJDKNC OHDBDPJBHPM<TMInput, TMOutput, TMNode>([In] this LOGLODBOHBJ<TMInput, TMOutput, TMNode> KNKOEEEKHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2982C70", Offset = "0x2981E70", VA = "0x182982C70")]
	internal static LOGLODBOHBJ<TMInput, TMOutput, TMNode> LKMADFBDLGL<TMInput, TMOutput, TMNode>(this CIOONHJDKNC KNKOEEEKHDK)
	{
		return default(LOGLODBOHBJ<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2982AA0", Offset = "0x2981CA0", VA = "0x182982AA0")]
	private static OALFJMJAJMP LHKDALDBANH<TMInput>([In] this FNBPBCOGKJO<EIPPGFCFCGI<TMInput>> KNKOEEEKHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2983170", Offset = "0x2982370", VA = "0x182983170")]
	private static FNBPBCOGKJO<EIPPGFCFCGI<TMInput>> MFPNONKBANA<TMInput>(this OALFJMJAJMP KNKOEEEKHDK)
	{
		return default(FNBPBCOGKJO<EIPPGFCFCGI<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x28E8E10", Offset = "0x28E8010", VA = "0x1828E8E10")]
	internal static void HDPILJBHDHI<TMInput, TMOutput, TMNode>(this LOGLODBOHBJ<TMInput, TMOutput, TMNode> KNKOEEEKHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x28E9690", Offset = "0x28E8890", VA = "0x1828E9690")]
	internal static EIPPGFCFCGI<TMOutput> OGCLLEGKFLL<TMOutput, TMInput, TMNode>(this LOGLODBOHBJ<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMNode> CLKPBALPCKM)
	{
		return default(EIPPGFCFCGI<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x28E8B10", Offset = "0x28E7D10", VA = "0x1828E8B10")]
	internal static void EJBBKCPFFPM<TMInput, TMOutput, TMNode>(this LOGLODBOHBJ<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMOutput> JNIKIHKLGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x26A6EE0", Offset = "0x26A60E0", VA = "0x1826A6EE0")]
	public static bool FJFIJPOJCAC<TMInput, TMOutput, TMNode>([In] this LOGLODBOHBJ<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMOutput> JNIKIHKLGAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2579160", Offset = "0x2578360", VA = "0x182579160")]
	public static int DMNDCOCNPMP<TMInput, TMOutput, TMNode>([In] this LOGLODBOHBJ<TMInput, TMOutput, TMNode> KNKOEEEKHDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x28E8FA0", Offset = "0x28E81A0", VA = "0x1828E8FA0")]
	public static EIPPGFCFCGI<TMNode> IHGABDKJOJE<TMNode, TMInput, TMOutput>([In] this LOGLODBOHBJ<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMOutput> JNIKIHKLGAD)
	{
		return default(EIPPGFCFCGI<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x277D3A0", Offset = "0x277C5A0", VA = "0x18277D3A0")]
	public static int BLBADCABCED<TMInput, TMOutput, TMNode>([In] this LOGLODBOHBJ<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMOutput> JNIKIHKLGAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x277E1C0", Offset = "0x277D3C0", VA = "0x18277E1C0")]
	public static EIPPGFCFCGI<TMInput> PHFMEOENMDM<TMInput, TMOutput, TMNode>([In] this LOGLODBOHBJ<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMOutput> JNIKIHKLGAD, int HMFNCGHECPG)
	{
		return default(EIPPGFCFCGI<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x277DC20", Offset = "0x277CE20", VA = "0x18277DC20")]
	internal static void DOKODMMBJKL<TMInput, TMOutput, TMNode>(this LOGLODBOHBJ<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMOutput> JNIKIHKLGAD, EIPPGFCFCGI<TMInput> LFBBIJDDIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x277DC20", Offset = "0x277CE20", VA = "0x18277DC20")]
	internal static void BKCMEBOEMKK<TMInput, TMOutput, TMNode>(this LOGLODBOHBJ<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMOutput> JNIKIHKLGAD, EIPPGFCFCGI<TMInput> LFBBIJDDIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2763760", Offset = "0x2762960", VA = "0x182763760")]
	public static FNBPBCOGKJO<EIPPGFCFCGI<TMInput>>.BAFEGDGPEGK KLAGLOIMECB<TMInput, TMOutput, TMNode>([In] this LOGLODBOHBJ<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMOutput> JNIKIHKLGAD)
	{
		return default(FNBPBCOGKJO<EIPPGFCFCGI<TMInput>>.BAFEGDGPEGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2763760", Offset = "0x2762960", VA = "0x182763760")]
	public static KHINJKLEGHI<EIPPGFCFCGI<TMInput>, FNBPBCOGKJO<EIPPGFCFCGI<TMInput>>.BAFEGDGPEGK> MPDFBIKEEGD<TMInput, TMOutput, TMNode>([In] this LOGLODBOHBJ<TMInput, TMOutput, TMNode> KNKOEEEKHDK, EIPPGFCFCGI<TMOutput> JNIKIHKLGAD)
	{
		return default(KHINJKLEGHI<EIPPGFCFCGI<TMInput>, FNBPBCOGKJO<EIPPGFCFCGI<TMInput>>.BAFEGDGPEGK>);
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
