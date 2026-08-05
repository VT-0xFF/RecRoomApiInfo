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
		[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CCF0A0", Offset = "0x1CCDCA0", VA = "0x181CCF0A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79BDE0", Offset = "0x79A9E0", VA = "0x18079BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79BE20", Offset = "0x79AA20", VA = "0x18079BE20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct HIFJMPHGBEM<TMInput, TMOutput, TMNode> : IEnumerator<LHFCDFCDHLN<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private LGMLHNGDKHH<TMInput, TMOutput, TMNode> MNLMMKNFAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private FCLGFEFKJAM<TMInput, TMOutput, TMNode> HDHHHJFAJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool PFDEADHMMED;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly LHFCDFCDHLN<TMNode> FLKMMGJNGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x366BB90", Offset = "0x366A790", VA = "0x18366BB90", Slot = "4")]
		get
		{
			return default(LHFCDFCDHLN<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x366BA30", Offset = "0x366A630", VA = "0x18366BA30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x366BAC0", Offset = "0x366A6C0", VA = "0x18366BAC0")]
	internal HIFJMPHGBEM([In] LGMLHNGDKHH<TMInput, TMOutput, TMNode> EOGNPEFHEDO, [In] FCLGFEFKJAM<TMInput, TMOutput, TMNode> COLFGJKIOPH, bool MEKNBHIJOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x366B8F0", Offset = "0x366A4F0", VA = "0x18366B8F0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x366B9B0", Offset = "0x366A5B0", VA = "0x18366B9B0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x366B870", Offset = "0x366A470", VA = "0x18366B870", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OPJPGKAIPJD
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2656340", Offset = "0x2654F40", VA = "0x182656340")]
	public static HIFJMPHGBEM<TMInput, TMOutput, TMNode> OOMHMBNJBCG<TMInput, TMOutput, TMNode>([In] GGKFLBOMBFE<TMInput, TMOutput, TMNode> FFFJFIONJKC, LHFCDFCDHLN<TMNode> GKCGMEKGHIE)
	{
		return default(HIFJMPHGBEM<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct FCLGFEFKJAM<TMInput, TMOutput, TMNode> : IEnumerator<LHFCDFCDHLN<TMInput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>.DECDHODHODD GFMJPGKGHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>.DECDHODHODD ICCNEBGCHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly IBPJHMDCMIL<TMInput, TMOutput, TMNode> NGKMFAKIKDB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LHFCDFCDHLN<TMInput> FLKMMGJNGAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x34C7D80", Offset = "0x34C6980", VA = "0x1834C7D80", Slot = "4")]
		get
		{
			return default(LHFCDFCDHLN<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x34C7C50", Offset = "0x34C6850", VA = "0x1834C7C50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x34C7D00", Offset = "0x34C6900", VA = "0x1834C7D00")]
	internal FCLGFEFKJAM([In] AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>.DECDHODHODD HEEEKELABKL, [In] AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>.DECDHODHODD EJNPFJALNEO, [In] IBPJHMDCMIL<TMInput, TMOutput, TMNode> APGEHCGJEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x34C7A80", Offset = "0x34C6680", VA = "0x1834C7A80", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x34C7BE0", Offset = "0x34C67E0", VA = "0x1834C7BE0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x34C7A10", Offset = "0x34C6610", VA = "0x1834C7A10", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KIDAJIDKCFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x256D9F0", Offset = "0x256C5F0", VA = "0x18256D9F0")]
	public static FCLGFEFKJAM<TMInput, TMOutput, TMNode> OOMHMBNJBCG<TMInput, TMOutput, TMNode>([In] GGKFLBOMBFE<TMInput, TMOutput, TMNode> FFFJFIONJKC, LHFCDFCDHLN<TMNode> GKCGMEKGHIE)
	{
		return default(FCLGFEFKJAM<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct LGMLHNGDKHH<TMInput, TMOutput, TMNode> : IEnumerator<LHFCDFCDHLN<TMOutput>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>.DECDHODHODD FLGLALMDODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>.DECDHODHODD PNPKHCMMLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly MPAOAMIADIO<TMInput, TMOutput, TMNode> PAOLPAKDICC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LHFCDFCDHLN<TMOutput> FLKMMGJNGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x34C7D80", Offset = "0x34C6980", VA = "0x1834C7D80", Slot = "4")]
		get
		{
			return default(LHFCDFCDHLN<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x34C7C50", Offset = "0x34C6850", VA = "0x1834C7C50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x34C7D00", Offset = "0x34C6900", VA = "0x1834C7D00")]
	internal LGMLHNGDKHH([In] AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>.DECDHODHODD IEMLKOLEBFL, [In] AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>.DECDHODHODD GFKIAHHDDKI, [In] MPAOAMIADIO<TMInput, TMOutput, TMNode> KOIHGOCMHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x34C7A80", Offset = "0x34C6680", VA = "0x1834C7A80", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x34C7BE0", Offset = "0x34C67E0", VA = "0x1834C7BE0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x34C7A10", Offset = "0x34C6610", VA = "0x1834C7A10", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class LLHBMBGEBAA
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2574B40", Offset = "0x2573740", VA = "0x182574B40")]
	public static LGMLHNGDKHH<TMInput, TMOutput, TMNode> OOMHMBNJBCG<TMInput, TMOutput, TMNode>([In] GGKFLBOMBFE<TMInput, TMOutput, TMNode> FFFJFIONJKC, LHFCDFCDHLN<TMNode> GKCGMEKGHIE)
	{
		return default(LGMLHNGDKHH<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct GGKFLBOMBFE<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public MPAOAMIADIO<TMInput, TMOutput, TMNode> OIEDMILFMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public IBPJHMDCMIL<TMInput, TMOutput, TMNode> BKGEMLIHMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public GEPHLJGEKGM<TMInput, TMOutput, TMNode> NPDMKDMLNBA;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x35B7650", Offset = "0x35B6250", VA = "0x1835B7650")]
	internal GGKFLBOMBFE([In] MPAOAMIADIO<TMInput, TMOutput, TMNode> KOIHGOCMHIH, [In] IBPJHMDCMIL<TMInput, TMOutput, TMNode> APGEHCGJEJO, [In] GEPHLJGEKGM<TMInput, TMOutput, TMNode> MCONEMCFFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x35B73A0", Offset = "0x35B5FA0", VA = "0x1835B73A0")]
	public static GGKFLBOMBFE<TMInput?, TMOutput?, TMNode?> OOMHMBNJBCG()
	{
		return default(GGKFLBOMBFE<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class OEDMBCIDLAI
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2645880", Offset = "0x2644480", VA = "0x182645880")]
	public static GFKHLJNANDK? OIIEHDKDHEB<TMInput, TMOutput, TMNode>([In] this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2645320", Offset = "0x2643F20", VA = "0x182645320")]
	public static GGKFLBOMBFE<TMInput?, TMOutput?, TMNode?> JFKFFNFOIMD<TMInput, TMOutput, TMNode>(this GFKHLJNANDK HHHLENOMLMP)
	{
		return default(GGKFLBOMBFE<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2645070", Offset = "0x2643C70", VA = "0x182645070")]
	public static void HBPPMPIFHCM<TMInput, TMOutput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x26449D0", Offset = "0x26435D0", VA = "0x1826449D0")]
	public static void AAKCLDEDMOG<TMInput, TMOutput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> AFHFPKGHGNN, LHFCDFCDHLN<TMInput> DMKBMEDCCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2645710", Offset = "0x2644310", VA = "0x182645710")]
	public static void KBAHOEFDKDM<TMInput, TMOutput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> AFHFPKGHGNN, LHFCDFCDHLN<TMInput> DMKBMEDCCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2644E40", Offset = "0x2643A40", VA = "0x182644E40")]
	public static bool GBIMCBICHDK<TMInput, TMOutput, TMNode>([In] this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> AFHFPKGHGNN, LHFCDFCDHLN<TMInput> DMKBMEDCCFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x26450D0", Offset = "0x2643CD0", VA = "0x1826450D0")]
	public static LHFCDFCDHLN<TMNode?> HNIDPICOPCI<TMNode, TMInput, TMOutput>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
		return default(LHFCDFCDHLN<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2645210", Offset = "0x2643E10", VA = "0x182645210")]
	public static void IIKNHNNCAGD<TMInput, TMOutput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> GKCGMEKGHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2645810", Offset = "0x2644410", VA = "0x182645810")]
	public static LHFCDFCDHLN<TMInput?> NADJFGEMDPM<TMInput, TMOutput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> GKCGMEKGHIE)
	{
		return default(LHFCDFCDHLN<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2645000", Offset = "0x2643C00", VA = "0x182645000")]
	public static LHFCDFCDHLN<TMOutput?> HBJJGBJJOPH<TMOutput, TMInput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> GKCGMEKGHIE)
	{
		return default(LHFCDFCDHLN<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2644CB0", Offset = "0x26438B0", VA = "0x182644CB0")]
	public static LHFCDFCDHLN<TMInput?> CFCHDKJPPJA<TMInput, TMOutput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> GKCGMEKGHIE, int DCGGFHOCGGH)
	{
		return default(LHFCDFCDHLN<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2645690", Offset = "0x2644290", VA = "0x182645690")]
	public static LHFCDFCDHLN<TMOutput?> KAHDHACGOHP<TMOutput, TMInput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> GKCGMEKGHIE, int DCGGFHOCGGH)
	{
		return default(LHFCDFCDHLN<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2644DA0", Offset = "0x26439A0", VA = "0x182644DA0")]
	public static void FMBJHGOHOCP<TMInput, TMOutput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> GKCGMEKGHIE, int ADHOFOCAKIF, int GAEBBBEPMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2645770", Offset = "0x2644370", VA = "0x182645770")]
	public static void MDGMDMDECNA<TMInput, TMOutput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> GKCGMEKGHIE, int ADHOFOCAKIF, int GAEBBBEPMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2644F10", Offset = "0x2643B10", VA = "0x182644F10")]
	public static void GMGJHIIECAI<TMInput, TMOutput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMInput> JNGJBGMHDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2644BC0", Offset = "0x26437C0", VA = "0x182644BC0")]
	public static void BIFLCGNHPKH<TMInput, TMOutput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> IMGOHMOIADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x848D40", Offset = "0x847940", VA = "0x180848D40")]
	public static AIFOBENAFOG<TMInput?> CMIJGMDNOHE<TMInput, TMOutput, TMNode>([In] this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
		return default(AIFOBENAFOG<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2645A70", Offset = "0x2644670", VA = "0x182645A70")]
	public static AIFOBENAFOG<TMOutput?> PKALFHHDIPE<TMOutput, TMInput, TMNode>([In] this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
		return default(AIFOBENAFOG<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2644CA0", Offset = "0x26438A0", VA = "0x182644CA0")]
	public static AIFOBENAFOG<TMNode?> BMDGFOKLJBL<TMNode, TMInput, TMOutput>([In] this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
		return default(AIFOBENAFOG<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2644D30", Offset = "0x2643930", VA = "0x182644D30")]
	public static FCLGFEFKJAM<TMInput?, TMOutput?, TMNode?> DPAMINDHBLC<TMInput, TMOutput, TMNode>([In] this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(FCLGFEFKJAM<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2644D30", Offset = "0x2643930", VA = "0x182644D30")]
	public static LGMLHNGDKHH<TMInput?, TMOutput?, TMNode?> IFHPEEABOBJ<TMInput, TMOutput, TMNode>([In] this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(LGMLHNGDKHH<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2645160", Offset = "0x2643D60", VA = "0x182645160")]
	public static HIFJMPHGBEM<TMInput?, TMOutput?, TMNode?> ICNLFPELLJM<TMInput, TMOutput, TMNode>([In] this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(HIFJMPHGBEM<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2645960", Offset = "0x2644560", VA = "0x182645960")]
	public static BDNJECJENLA<LHFCDFCDHLN<TMInput?>, FCLGFEFKJAM<TMInput?, TMOutput?, TMNode?>> ONKIGJAEGIA<TMInput, TMOutput, TMNode>([In] this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(BDNJECJENLA<LHFCDFCDHLN<TMInput>, FCLGFEFKJAM<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2644A30", Offset = "0x2643630", VA = "0x182644A30")]
	public static BDNJECJENLA<LHFCDFCDHLN<TMNode?>, HIFJMPHGBEM<TMInput?, TMOutput?, TMNode?>> BEKNHOAFJLL<TMNode, TMInput, TMOutput>([In] this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(BDNJECJENLA<LHFCDFCDHLN<TMNode>, HIFJMPHGBEM<TMInput, TMOutput, TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct MPAOAMIADIO<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal AIFOBENAFOG<TMInput> AMJFCLDMANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal NGLFKLMDBCE<TMInput, LHFCDFCDHLN<TMNode>> GAIFLAKHNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal NGLFKLMDBCE<TMInput, AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>> NGKMFAKIKDB;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x35882D0", Offset = "0x3586ED0", VA = "0x1835882D0")]
	internal MPAOAMIADIO([In] AIFOBENAFOG<TMInput> NLGFHGBNOGB, [In] NGLFKLMDBCE<TMInput, LHFCDFCDHLN<TMNode>> MCONEMCFFOM, [In] NGLFKLMDBCE<TMInput, AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>> APGEHCGJEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3588060", Offset = "0x3586C60", VA = "0x183588060")]
	internal static MPAOAMIADIO<TMInput, TMOutput, TMNode> OOMHMBNJBCG()
	{
		return default(MPAOAMIADIO<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class ANFMKHCBKDB
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F9D0", Offset = "0x2B1E5D0", VA = "0x182B1F9D0")]
	internal static FPCHPOIHBOC OIIEHDKDHEB<TMInput, TMOutput, TMNode>([In] this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F240", Offset = "0x2B1DE40", VA = "0x182B1F240")]
	internal static MPAOAMIADIO<TMInput, TMOutput, TMNode> JFKFFNFOIMD<TMInput, TMOutput, TMNode>(this FPCHPOIHBOC HHHLENOMLMP)
	{
		return default(MPAOAMIADIO<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F070", Offset = "0x2B1DC70", VA = "0x182B1F070")]
	private static AHNNGEIOLFD HHHDJCJCBOD<TMOutput>([In] this AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>> HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F750", Offset = "0x2B1E350", VA = "0x182B1F750")]
	private static AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>> NIPBPKMEIBG<TMOutput>(this AHNNGEIOLFD HHHLENOMLMP)
	{
		return default(AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2529CE0", Offset = "0x25288E0", VA = "0x182529CE0")]
	internal static void HBPPMPIFHCM<TMInput, TMOutput, TMNode>(this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x252A5E0", Offset = "0x25291E0", VA = "0x18252A5E0")]
	internal static LHFCDFCDHLN<TMInput> OGGICBDPIDD<TMInput, TMOutput, TMNode>(this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> NIICEONAONO)
	{
		return default(LHFCDFCDHLN<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2529E70", Offset = "0x2528A70", VA = "0x182529E70")]
	internal static void IJNJJGHDBFD<TMInput, TMOutput, TMNode>(this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMInput> HLINMGJJNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x22D30F0", Offset = "0x22D1CF0", VA = "0x1822D30F0")]
	public static bool ENKHGCDGNNP<TMInput, TMOutput, TMNode>([In] this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMInput> HLINMGJJNHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2529CC0", Offset = "0x25288C0", VA = "0x182529CC0")]
	public static LHFCDFCDHLN<TMNode> CAGOICAGMPO<TMNode, TMInput, TMOutput>([In] this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMInput> HLINMGJJNHD)
	{
		return default(LHFCDFCDHLN<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x23C7820", Offset = "0x23C6420", VA = "0x1823C7820")]
	public static int LEHKCDEJKIF<TMInput, TMOutput, TMNode>([In] this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMInput> HLINMGJJNHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x23C67A0", Offset = "0x23C53A0", VA = "0x1823C67A0")]
	public static LHFCDFCDHLN<TMOutput> AJFHCPJLKMG<TMOutput, TMInput, TMNode>([In] this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMInput> HLINMGJJNHD, int DCGGFHOCGGH)
	{
		return default(LHFCDFCDHLN<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x23C6BF0", Offset = "0x23C57F0", VA = "0x1823C6BF0")]
	internal static void PHMFDMABCBG<TMInput, TMOutput, TMNode>(this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMInput> HLINMGJJNHD, LHFCDFCDHLN<TMOutput> IMGOHMOIADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x23C6BF0", Offset = "0x23C57F0", VA = "0x1823C6BF0")]
	internal static void HIGFECNIAMA<TMInput, TMOutput, TMNode>(this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMInput> HLINMGJJNHD, LHFCDFCDHLN<TMOutput> IMGOHMOIADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x22DDCB0", Offset = "0x22DC8B0", VA = "0x1822DDCB0")]
	public static AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>.DECDHODHODD LMBMCPDNFKP<TMOutput, TMInput, TMNode>([In] this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMInput> HLINMGJJNHD)
	{
		return default(AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>.DECDHODHODD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x22DDCB0", Offset = "0x22DC8B0", VA = "0x1822DDCB0")]
	public static NFIGBEFEAMI<LHFCDFCDHLN<TMOutput>, AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>.DECDHODHODD> OKNNIDNIGIH<TMOutput, TMInput, TMNode>([In] this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMInput> HLINMGJJNHD)
	{
		return default(NFIGBEFEAMI<LHFCDFCDHLN<TMOutput>, AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>.DECDHODHODD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct GEPHLJGEKGM<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal AIFOBENAFOG<TMNode> AMJFCLDMANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal NGLFKLMDBCE<TMNode, AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>> PAOLPAKDICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal NGLFKLMDBCE<TMNode, AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>> NGKMFAKIKDB;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x35882D0", Offset = "0x3586ED0", VA = "0x1835882D0")]
	internal GEPHLJGEKGM([In] AIFOBENAFOG<TMNode> NLGFHGBNOGB, [In] NGLFKLMDBCE<TMNode, AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>> KOIHGOCMHIH, [In] NGLFKLMDBCE<TMNode, AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>> APGEHCGJEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3588060", Offset = "0x3586C60", VA = "0x183588060")]
	internal static GEPHLJGEKGM<TMInput, TMOutput, TMNode> OOMHMBNJBCG()
	{
		return default(GEPHLJGEKGM<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class EAJCOAOCMOM
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x23C7980", Offset = "0x23C6580", VA = "0x1823C7980")]
	internal static PFGFEFALEDO OIIEHDKDHEB<TMInput, TMOutput, TMNode>([In] this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x23C6F70", Offset = "0x23C5B70", VA = "0x1823C6F70")]
	internal static GEPHLJGEKGM<TMInput, TMOutput, TMNode> JFKFFNFOIMD<TMInput, TMOutput, TMNode>(this PFGFEFALEDO HHHLENOMLMP)
	{
		return default(GEPHLJGEKGM<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x23C7650", Offset = "0x23C6250", VA = "0x1823C7650")]
	private static LCEKMMPAJJD JOMOFIBMNGM<TMInput>([In] this AFOLGPAAIPI<LHFCDFCDHLN<TMInput>> HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x23C6CF0", Offset = "0x23C58F0", VA = "0x1823C6CF0")]
	private static AFOLGPAAIPI<LHFCDFCDHLN<TMInput>> JBKDBNADCMH<TMInput>(this LCEKMMPAJJD HHHLENOMLMP)
	{
		return default(AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x23C7480", Offset = "0x23C6080", VA = "0x1823C7480")]
	private static JJMIFMFEHFA JMDINJLOJLB<TMOutput>([In] this AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>> HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x23C7D40", Offset = "0x23C6940", VA = "0x1823C7D40")]
	private static AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>> PAAAFGPEKHD<TMOutput>(this JJMIFMFEHFA HHHLENOMLMP)
	{
		return default(AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x23C6930", Offset = "0x23C5530", VA = "0x1823C6930")]
	internal static void HBPPMPIFHCM<TMInput, TMOutput, TMNode>(this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x23C78B0", Offset = "0x23C64B0", VA = "0x1823C78B0")]
	internal static LHFCDFCDHLN<TMNode> OGGICBDPIDD<TMNode, TMInput, TMOutput>(this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, [In] AFOLGPAAIPI<LHFCDFCDHLN<TMInput>> KOIHGOCMHIH, [In] AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>> APGEHCGJEJO)
	{
		return default(LHFCDFCDHLN<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x23C6C30", Offset = "0x23C5830", VA = "0x1823C6C30")]
	internal static void IJNJJGHDBFD<TMInput, TMOutput, TMNode>(this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x22D30F0", Offset = "0x22D1CF0", VA = "0x1822D30F0")]
	public static bool ENKHGCDGNNP<TMInput, TMOutput, TMNode>([In] this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x23C7940", Offset = "0x23C6540", VA = "0x1823C7940")]
	public static int OGOMFBBAEGC<TMInput, TMOutput, TMNode>([In] this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x23C7820", Offset = "0x23C6420", VA = "0x1823C7820")]
	public static int LEHKCDEJKIF<TMInput, TMOutput, TMNode>([In] this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x23C6840", Offset = "0x23C5440", VA = "0x1823C6840")]
	public static LHFCDFCDHLN<TMInput> ECDBGAPFIIK<TMInput, TMOutput, TMNode>([In] this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD, int DCGGFHOCGGH)
	{
		return default(LHFCDFCDHLN<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x23C67A0", Offset = "0x23C53A0", VA = "0x1823C67A0")]
	public static LHFCDFCDHLN<TMOutput> AJFHCPJLKMG<TMOutput, TMInput, TMNode>([In] this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD, int DCGGFHOCGGH)
	{
		return default(LHFCDFCDHLN<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x23C6890", Offset = "0x23C5490", VA = "0x1823C6890")]
	internal static void FENOHPFELJH<TMInput, TMOutput, TMNode>(this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD, LHFCDFCDHLN<TMInput> JNGJBGMHDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x23C6BF0", Offset = "0x23C57F0", VA = "0x1823C6BF0")]
	internal static void PHMFDMABCBG<TMInput, TMOutput, TMNode>(this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD, LHFCDFCDHLN<TMOutput> IMGOHMOIADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x23C67F0", Offset = "0x23C53F0", VA = "0x1823C67F0")]
	internal static void AMDGJDJKKCD<TMInput, TMOutput, TMNode>(this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD, int DCGGFHOCGGH, LHFCDFCDHLN<TMInput> JNGJBGMHDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x23C7860", Offset = "0x23C6460", VA = "0x1823C7860")]
	internal static void OCCOOMDHOJC<TMInput, TMOutput, TMNode>(this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD, int DCGGFHOCGGH, LHFCDFCDHLN<TMOutput> IMGOHMOIADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x23C6890", Offset = "0x23C5490", VA = "0x1823C6890")]
	internal static void GAKOBPMMOPM<TMInput, TMOutput, TMNode>(this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD, LHFCDFCDHLN<TMInput> JNGJBGMHDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x23C6BF0", Offset = "0x23C57F0", VA = "0x1823C6BF0")]
	internal static void HIGFECNIAMA<TMInput, TMOutput, TMNode>(this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD, LHFCDFCDHLN<TMOutput> IMGOHMOIADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x23C68D0", Offset = "0x23C54D0", VA = "0x1823C68D0")]
	public static AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>.DECDHODHODD NDEABDNCEDE<TMInput, TMOutput, TMNode>([In] this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>.DECDHODHODD);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x22DDCB0", Offset = "0x22DC8B0", VA = "0x1822DDCB0")]
	public static AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>.DECDHODHODD LMBMCPDNFKP<TMOutput, TMInput, TMNode>([In] this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>.DECDHODHODD);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x23C68D0", Offset = "0x23C54D0", VA = "0x1823C68D0")]
	public static NFIGBEFEAMI<LHFCDFCDHLN<TMInput>, AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>.DECDHODHODD> GPKFEAGMOOH<TMInput, TMOutput, TMNode>([In] this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(NFIGBEFEAMI<LHFCDFCDHLN<TMInput>, AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>.DECDHODHODD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x22DDCB0", Offset = "0x22DC8B0", VA = "0x1822DDCB0")]
	public static NFIGBEFEAMI<LHFCDFCDHLN<TMOutput>, AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>.DECDHODHODD> OKNNIDNIGIH<TMOutput, TMInput, TMNode>([In] this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(NFIGBEFEAMI<LHFCDFCDHLN<TMOutput>, AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>.DECDHODHODD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x22DD110", Offset = "0x22DBD10", VA = "0x1822DD110")]
	public static BDNJECJENLA<LHFCDFCDHLN<TMNode>, AIFOBENAFOG<TMNode>.BBNDNGJAMCI> EJEMAJCNMLA<TMNode, TMInput, TMOutput>([In] this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
		return default(BDNJECJENLA<LHFCDFCDHLN<TMNode>, AIFOBENAFOG<TMNode>.BBNDNGJAMCI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct IBPJHMDCMIL<TMInput, TMOutput, TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal AIFOBENAFOG<TMOutput> AMJFCLDMANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal NGLFKLMDBCE<TMOutput, LHFCDFCDHLN<TMNode>> GAIFLAKHNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal NGLFKLMDBCE<TMOutput, AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>> PAOLPAKDICC;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x35882D0", Offset = "0x3586ED0", VA = "0x1835882D0")]
	internal IBPJHMDCMIL([In] AIFOBENAFOG<TMOutput> NLGFHGBNOGB, [In] NGLFKLMDBCE<TMOutput, LHFCDFCDHLN<TMNode>> MCONEMCFFOM, [In] NGLFKLMDBCE<TMOutput, AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>> KOIHGOCMHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3588060", Offset = "0x3586C60", VA = "0x183588060")]
	internal static IBPJHMDCMIL<TMInput, TMOutput, TMNode> OOMHMBNJBCG()
	{
		return default(IBPJHMDCMIL<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class IBNGBGFNDHE
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x252A680", Offset = "0x2529280", VA = "0x18252A680")]
	internal static ACFFDFACBHO OIIEHDKDHEB<TMInput, TMOutput, TMNode>([In] this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2529F00", Offset = "0x2528B00", VA = "0x182529F00")]
	internal static IBPJHMDCMIL<TMInput, TMOutput, TMNode> JFKFFNFOIMD<TMInput, TMOutput, TMNode>(this ACFFDFACBHO HHHLENOMLMP)
	{
		return default(IBPJHMDCMIL<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x252A410", Offset = "0x2529010", VA = "0x18252A410")]
	private static LKOPPNAMIIL MLGJGJCINHD<TMInput>([In] this AFOLGPAAIPI<LHFCDFCDHLN<TMInput>> HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2529A40", Offset = "0x2528640", VA = "0x182529A40")]
	private static AFOLGPAAIPI<LHFCDFCDHLN<TMInput>> AGOJDINPJPN<TMInput>(this LKOPPNAMIIL HHHLENOMLMP)
	{
		return default(AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2529CE0", Offset = "0x25288E0", VA = "0x182529CE0")]
	internal static void HBPPMPIFHCM<TMInput, TMOutput, TMNode>(this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x252A5E0", Offset = "0x25291E0", VA = "0x18252A5E0")]
	internal static LHFCDFCDHLN<TMOutput> OGGICBDPIDD<TMOutput, TMInput, TMNode>(this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> NIICEONAONO)
	{
		return default(LHFCDFCDHLN<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2529E70", Offset = "0x2528A70", VA = "0x182529E70")]
	internal static void IJNJJGHDBFD<TMInput, TMOutput, TMNode>(this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> HLINMGJJNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x22D30F0", Offset = "0x22D1CF0", VA = "0x1822D30F0")]
	public static bool ENKHGCDGNNP<TMInput, TMOutput, TMNode>([In] this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> HLINMGJJNHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2529CC0", Offset = "0x25288C0", VA = "0x182529CC0")]
	public static LHFCDFCDHLN<TMNode> CAGOICAGMPO<TMNode, TMInput, TMOutput>([In] this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> HLINMGJJNHD)
	{
		return default(LHFCDFCDHLN<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x23C7820", Offset = "0x23C6420", VA = "0x1823C7820")]
	public static int OGOMFBBAEGC<TMInput, TMOutput, TMNode>([In] this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> HLINMGJJNHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x23C67A0", Offset = "0x23C53A0", VA = "0x1823C67A0")]
	public static LHFCDFCDHLN<TMInput> ECDBGAPFIIK<TMInput, TMOutput, TMNode>([In] this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> HLINMGJJNHD, int DCGGFHOCGGH)
	{
		return default(LHFCDFCDHLN<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x23C6BF0", Offset = "0x23C57F0", VA = "0x1823C6BF0")]
	internal static void FENOHPFELJH<TMInput, TMOutput, TMNode>(this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> HLINMGJJNHD, LHFCDFCDHLN<TMInput> JNGJBGMHDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x23C6BF0", Offset = "0x23C57F0", VA = "0x1823C6BF0")]
	internal static void GAKOBPMMOPM<TMInput, TMOutput, TMNode>(this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> HLINMGJJNHD, LHFCDFCDHLN<TMInput> JNGJBGMHDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x22DDCB0", Offset = "0x22DC8B0", VA = "0x1822DDCB0")]
	public static AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>.DECDHODHODD NDEABDNCEDE<TMInput, TMOutput, TMNode>([In] this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> HLINMGJJNHD)
	{
		return default(AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>.DECDHODHODD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x22DDCB0", Offset = "0x22DC8B0", VA = "0x1822DDCB0")]
	public static NFIGBEFEAMI<LHFCDFCDHLN<TMInput>, AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>.DECDHODHODD> GPKFEAGMOOH<TMInput, TMOutput, TMNode>([In] this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> HLINMGJJNHD)
	{
		return default(NFIGBEFEAMI<LHFCDFCDHLN<TMInput>, AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>.DECDHODHODD>);
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
