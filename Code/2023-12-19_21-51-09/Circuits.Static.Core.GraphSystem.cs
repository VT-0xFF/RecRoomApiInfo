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
		[Cpp2IlInjected.Address(RVA = "0x1CCF010", Offset = "0x1CCDC10", VA = "0x181CCF010")]
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
		[Cpp2IlInjected.Address(RVA = "0x366BB00", Offset = "0x366A700", VA = "0x18366BB00", Slot = "4")]
		get
		{
			return default(LHFCDFCDHLN<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x366B9A0", Offset = "0x366A5A0", VA = "0x18366B9A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x366BA30", Offset = "0x366A630", VA = "0x18366BA30")]
	internal HIFJMPHGBEM([In] LGMLHNGDKHH<TMInput, TMOutput, TMNode> EOGNPEFHEDO, [In] FCLGFEFKJAM<TMInput, TMOutput, TMNode> COLFGJKIOPH, bool MEKNBHIJOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x366B860", Offset = "0x366A460", VA = "0x18366B860", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x366B920", Offset = "0x366A520", VA = "0x18366B920", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x366B7E0", Offset = "0x366A3E0", VA = "0x18366B7E0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OPJPGKAIPJD
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x26562B0", Offset = "0x2654EB0", VA = "0x1826562B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x34C7CF0", Offset = "0x34C68F0", VA = "0x1834C7CF0", Slot = "4")]
		get
		{
			return default(LHFCDFCDHLN<TMInput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x34C7BC0", Offset = "0x34C67C0", VA = "0x1834C7BC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x34C7C70", Offset = "0x34C6870", VA = "0x1834C7C70")]
	internal FCLGFEFKJAM([In] AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>.DECDHODHODD HEEEKELABKL, [In] AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>.DECDHODHODD EJNPFJALNEO, [In] IBPJHMDCMIL<TMInput, TMOutput, TMNode> APGEHCGJEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x34C79F0", Offset = "0x34C65F0", VA = "0x1834C79F0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x34C7B50", Offset = "0x34C6750", VA = "0x1834C7B50", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x34C7980", Offset = "0x34C6580", VA = "0x1834C7980", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KIDAJIDKCFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x256D960", Offset = "0x256C560", VA = "0x18256D960")]
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
		[Cpp2IlInjected.Address(RVA = "0x34C7CF0", Offset = "0x34C68F0", VA = "0x1834C7CF0", Slot = "4")]
		get
		{
			return default(LHFCDFCDHLN<TMOutput>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x34C7BC0", Offset = "0x34C67C0", VA = "0x1834C7BC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x34C7C70", Offset = "0x34C6870", VA = "0x1834C7C70")]
	internal LGMLHNGDKHH([In] AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>.DECDHODHODD IEMLKOLEBFL, [In] AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>.DECDHODHODD GFKIAHHDDKI, [In] MPAOAMIADIO<TMInput, TMOutput, TMNode> KOIHGOCMHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x34C79F0", Offset = "0x34C65F0", VA = "0x1834C79F0", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x34C7B50", Offset = "0x34C6750", VA = "0x1834C7B50", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x34C7980", Offset = "0x34C6580", VA = "0x1834C7980", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class LLHBMBGEBAA
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2574AB0", Offset = "0x25736B0", VA = "0x182574AB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x35B75C0", Offset = "0x35B61C0", VA = "0x1835B75C0")]
	internal GGKFLBOMBFE([In] MPAOAMIADIO<TMInput, TMOutput, TMNode> KOIHGOCMHIH, [In] IBPJHMDCMIL<TMInput, TMOutput, TMNode> APGEHCGJEJO, [In] GEPHLJGEKGM<TMInput, TMOutput, TMNode> MCONEMCFFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x35B7310", Offset = "0x35B5F10", VA = "0x1835B7310")]
	public static GGKFLBOMBFE<TMInput?, TMOutput?, TMNode?> OOMHMBNJBCG()
	{
		return default(GGKFLBOMBFE<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class OEDMBCIDLAI
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x26457F0", Offset = "0x26443F0", VA = "0x1826457F0")]
	public static GFKHLJNANDK? OIIEHDKDHEB<TMInput, TMOutput, TMNode>([In] this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2645290", Offset = "0x2643E90", VA = "0x182645290")]
	public static GGKFLBOMBFE<TMInput?, TMOutput?, TMNode?> JFKFFNFOIMD<TMInput, TMOutput, TMNode>(this GFKHLJNANDK HHHLENOMLMP)
	{
		return default(GGKFLBOMBFE<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2644FE0", Offset = "0x2643BE0", VA = "0x182644FE0")]
	public static void HBPPMPIFHCM<TMInput, TMOutput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2644940", Offset = "0x2643540", VA = "0x182644940")]
	public static void AAKCLDEDMOG<TMInput, TMOutput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> AFHFPKGHGNN, LHFCDFCDHLN<TMInput> DMKBMEDCCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2645680", Offset = "0x2644280", VA = "0x182645680")]
	public static void KBAHOEFDKDM<TMInput, TMOutput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> AFHFPKGHGNN, LHFCDFCDHLN<TMInput> DMKBMEDCCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2644DB0", Offset = "0x26439B0", VA = "0x182644DB0")]
	public static bool GBIMCBICHDK<TMInput, TMOutput, TMNode>([In] this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> AFHFPKGHGNN, LHFCDFCDHLN<TMInput> DMKBMEDCCFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2645040", Offset = "0x2643C40", VA = "0x182645040")]
	public static LHFCDFCDHLN<TMNode?> HNIDPICOPCI<TMNode, TMInput, TMOutput>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
		return default(LHFCDFCDHLN<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2645180", Offset = "0x2643D80", VA = "0x182645180")]
	public static void IIKNHNNCAGD<TMInput, TMOutput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> GKCGMEKGHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2645780", Offset = "0x2644380", VA = "0x182645780")]
	public static LHFCDFCDHLN<TMInput?> NADJFGEMDPM<TMInput, TMOutput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> GKCGMEKGHIE)
	{
		return default(LHFCDFCDHLN<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2644F70", Offset = "0x2643B70", VA = "0x182644F70")]
	public static LHFCDFCDHLN<TMOutput?> HBJJGBJJOPH<TMOutput, TMInput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> GKCGMEKGHIE)
	{
		return default(LHFCDFCDHLN<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2644C20", Offset = "0x2643820", VA = "0x182644C20")]
	public static LHFCDFCDHLN<TMInput?> CFCHDKJPPJA<TMInput, TMOutput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> GKCGMEKGHIE, int DCGGFHOCGGH)
	{
		return default(LHFCDFCDHLN<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2645600", Offset = "0x2644200", VA = "0x182645600")]
	public static LHFCDFCDHLN<TMOutput?> KAHDHACGOHP<TMOutput, TMInput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> GKCGMEKGHIE, int DCGGFHOCGGH)
	{
		return default(LHFCDFCDHLN<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2644D10", Offset = "0x2643910", VA = "0x182644D10")]
	public static void FMBJHGOHOCP<TMInput, TMOutput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> GKCGMEKGHIE, int ADHOFOCAKIF, int GAEBBBEPMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x26456E0", Offset = "0x26442E0", VA = "0x1826456E0")]
	public static void MDGMDMDECNA<TMInput, TMOutput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> GKCGMEKGHIE, int ADHOFOCAKIF, int GAEBBBEPMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2644E80", Offset = "0x2643A80", VA = "0x182644E80")]
	public static void GMGJHIIECAI<TMInput, TMOutput, TMNode>(this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMInput> JNGJBGMHDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2644B30", Offset = "0x2643730", VA = "0x182644B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x26459E0", Offset = "0x26445E0", VA = "0x1826459E0")]
	public static AIFOBENAFOG<TMOutput?> PKALFHHDIPE<TMOutput, TMInput, TMNode>([In] this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
		return default(AIFOBENAFOG<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2644C10", Offset = "0x2643810", VA = "0x182644C10")]
	public static AIFOBENAFOG<TMNode?> BMDGFOKLJBL<TMNode, TMInput, TMOutput>([In] this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
		return default(AIFOBENAFOG<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2644CA0", Offset = "0x26438A0", VA = "0x182644CA0")]
	public static FCLGFEFKJAM<TMInput?, TMOutput?, TMNode?> DPAMINDHBLC<TMInput, TMOutput, TMNode>([In] this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(FCLGFEFKJAM<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2644CA0", Offset = "0x26438A0", VA = "0x182644CA0")]
	public static LGMLHNGDKHH<TMInput?, TMOutput?, TMNode?> IFHPEEABOBJ<TMInput, TMOutput, TMNode>([In] this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(LGMLHNGDKHH<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x26450D0", Offset = "0x2643CD0", VA = "0x1826450D0")]
	public static HIFJMPHGBEM<TMInput?, TMOutput?, TMNode?> ICNLFPELLJM<TMInput, TMOutput, TMNode>([In] this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(HIFJMPHGBEM<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x26458D0", Offset = "0x26444D0", VA = "0x1826458D0")]
	public static BDNJECJENLA<LHFCDFCDHLN<TMInput?>, FCLGFEFKJAM<TMInput?, TMOutput?, TMNode?>> ONKIGJAEGIA<TMInput, TMOutput, TMNode>([In] this GGKFLBOMBFE<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(BDNJECJENLA<LHFCDFCDHLN<TMInput>, FCLGFEFKJAM<TMInput, TMOutput, TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x26449A0", Offset = "0x26435A0", VA = "0x1826449A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3588240", Offset = "0x3586E40", VA = "0x183588240")]
	internal MPAOAMIADIO([In] AIFOBENAFOG<TMInput> NLGFHGBNOGB, [In] NGLFKLMDBCE<TMInput, LHFCDFCDHLN<TMNode>> MCONEMCFFOM, [In] NGLFKLMDBCE<TMInput, AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>> APGEHCGJEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3587FD0", Offset = "0x3586BD0", VA = "0x183587FD0")]
	internal static MPAOAMIADIO<TMInput, TMOutput, TMNode> OOMHMBNJBCG()
	{
		return default(MPAOAMIADIO<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class ANFMKHCBKDB
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F940", Offset = "0x2B1E540", VA = "0x182B1F940")]
	internal static FPCHPOIHBOC OIIEHDKDHEB<TMInput, TMOutput, TMNode>([In] this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F1B0", Offset = "0x2B1DDB0", VA = "0x182B1F1B0")]
	internal static MPAOAMIADIO<TMInput, TMOutput, TMNode> JFKFFNFOIMD<TMInput, TMOutput, TMNode>(this FPCHPOIHBOC HHHLENOMLMP)
	{
		return default(MPAOAMIADIO<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2B1EFE0", Offset = "0x2B1DBE0", VA = "0x182B1EFE0")]
	private static AHNNGEIOLFD HHHDJCJCBOD<TMOutput>([In] this AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>> HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2B1F6C0", Offset = "0x2B1E2C0", VA = "0x182B1F6C0")]
	private static AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>> NIPBPKMEIBG<TMOutput>(this AHNNGEIOLFD HHHLENOMLMP)
	{
		return default(AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2529C50", Offset = "0x2528850", VA = "0x182529C50")]
	internal static void HBPPMPIFHCM<TMInput, TMOutput, TMNode>(this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x252A550", Offset = "0x2529150", VA = "0x18252A550")]
	internal static LHFCDFCDHLN<TMInput> OGGICBDPIDD<TMInput, TMOutput, TMNode>(this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> NIICEONAONO)
	{
		return default(LHFCDFCDHLN<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2529DE0", Offset = "0x25289E0", VA = "0x182529DE0")]
	internal static void IJNJJGHDBFD<TMInput, TMOutput, TMNode>(this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMInput> HLINMGJJNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x22D3060", Offset = "0x22D1C60", VA = "0x1822D3060")]
	public static bool ENKHGCDGNNP<TMInput, TMOutput, TMNode>([In] this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMInput> HLINMGJJNHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2529C30", Offset = "0x2528830", VA = "0x182529C30")]
	public static LHFCDFCDHLN<TMNode> CAGOICAGMPO<TMNode, TMInput, TMOutput>([In] this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMInput> HLINMGJJNHD)
	{
		return default(LHFCDFCDHLN<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x23C7790", Offset = "0x23C6390", VA = "0x1823C7790")]
	public static int LEHKCDEJKIF<TMInput, TMOutput, TMNode>([In] this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMInput> HLINMGJJNHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x23C6710", Offset = "0x23C5310", VA = "0x1823C6710")]
	public static LHFCDFCDHLN<TMOutput> AJFHCPJLKMG<TMOutput, TMInput, TMNode>([In] this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMInput> HLINMGJJNHD, int DCGGFHOCGGH)
	{
		return default(LHFCDFCDHLN<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x23C6B60", Offset = "0x23C5760", VA = "0x1823C6B60")]
	internal static void PHMFDMABCBG<TMInput, TMOutput, TMNode>(this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMInput> HLINMGJJNHD, LHFCDFCDHLN<TMOutput> IMGOHMOIADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x23C6B60", Offset = "0x23C5760", VA = "0x1823C6B60")]
	internal static void HIGFECNIAMA<TMInput, TMOutput, TMNode>(this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMInput> HLINMGJJNHD, LHFCDFCDHLN<TMOutput> IMGOHMOIADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x22DDC20", Offset = "0x22DC820", VA = "0x1822DDC20")]
	public static AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>.DECDHODHODD LMBMCPDNFKP<TMOutput, TMInput, TMNode>([In] this MPAOAMIADIO<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMInput> HLINMGJJNHD)
	{
		return default(AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>.DECDHODHODD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x22DDC20", Offset = "0x22DC820", VA = "0x1822DDC20")]
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
	[Cpp2IlInjected.Address(RVA = "0x3588240", Offset = "0x3586E40", VA = "0x183588240")]
	internal GEPHLJGEKGM([In] AIFOBENAFOG<TMNode> NLGFHGBNOGB, [In] NGLFKLMDBCE<TMNode, AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>> KOIHGOCMHIH, [In] NGLFKLMDBCE<TMNode, AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>> APGEHCGJEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3587FD0", Offset = "0x3586BD0", VA = "0x183587FD0")]
	internal static GEPHLJGEKGM<TMInput, TMOutput, TMNode> OOMHMBNJBCG()
	{
		return default(GEPHLJGEKGM<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class EAJCOAOCMOM
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x23C78F0", Offset = "0x23C64F0", VA = "0x1823C78F0")]
	internal static PFGFEFALEDO OIIEHDKDHEB<TMInput, TMOutput, TMNode>([In] this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x23C6EE0", Offset = "0x23C5AE0", VA = "0x1823C6EE0")]
	internal static GEPHLJGEKGM<TMInput, TMOutput, TMNode> JFKFFNFOIMD<TMInput, TMOutput, TMNode>(this PFGFEFALEDO HHHLENOMLMP)
	{
		return default(GEPHLJGEKGM<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x23C75C0", Offset = "0x23C61C0", VA = "0x1823C75C0")]
	private static LCEKMMPAJJD JOMOFIBMNGM<TMInput>([In] this AFOLGPAAIPI<LHFCDFCDHLN<TMInput>> HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x23C6C60", Offset = "0x23C5860", VA = "0x1823C6C60")]
	private static AFOLGPAAIPI<LHFCDFCDHLN<TMInput>> JBKDBNADCMH<TMInput>(this LCEKMMPAJJD HHHLENOMLMP)
	{
		return default(AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x23C73F0", Offset = "0x23C5FF0", VA = "0x1823C73F0")]
	private static JJMIFMFEHFA JMDINJLOJLB<TMOutput>([In] this AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>> HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x23C7CB0", Offset = "0x23C68B0", VA = "0x1823C7CB0")]
	private static AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>> PAAAFGPEKHD<TMOutput>(this JJMIFMFEHFA HHHLENOMLMP)
	{
		return default(AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x23C68A0", Offset = "0x23C54A0", VA = "0x1823C68A0")]
	internal static void HBPPMPIFHCM<TMInput, TMOutput, TMNode>(this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x23C7820", Offset = "0x23C6420", VA = "0x1823C7820")]
	internal static LHFCDFCDHLN<TMNode> OGGICBDPIDD<TMNode, TMInput, TMOutput>(this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, [In] AFOLGPAAIPI<LHFCDFCDHLN<TMInput>> KOIHGOCMHIH, [In] AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>> APGEHCGJEJO)
	{
		return default(LHFCDFCDHLN<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x23C6BA0", Offset = "0x23C57A0", VA = "0x1823C6BA0")]
	internal static void IJNJJGHDBFD<TMInput, TMOutput, TMNode>(this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x22D3060", Offset = "0x22D1C60", VA = "0x1822D3060")]
	public static bool ENKHGCDGNNP<TMInput, TMOutput, TMNode>([In] this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x23C78B0", Offset = "0x23C64B0", VA = "0x1823C78B0")]
	public static int OGOMFBBAEGC<TMInput, TMOutput, TMNode>([In] this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x23C7790", Offset = "0x23C6390", VA = "0x1823C7790")]
	public static int LEHKCDEJKIF<TMInput, TMOutput, TMNode>([In] this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x23C67B0", Offset = "0x23C53B0", VA = "0x1823C67B0")]
	public static LHFCDFCDHLN<TMInput> ECDBGAPFIIK<TMInput, TMOutput, TMNode>([In] this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD, int DCGGFHOCGGH)
	{
		return default(LHFCDFCDHLN<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x23C6710", Offset = "0x23C5310", VA = "0x1823C6710")]
	public static LHFCDFCDHLN<TMOutput> AJFHCPJLKMG<TMOutput, TMInput, TMNode>([In] this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD, int DCGGFHOCGGH)
	{
		return default(LHFCDFCDHLN<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x23C6800", Offset = "0x23C5400", VA = "0x1823C6800")]
	internal static void FENOHPFELJH<TMInput, TMOutput, TMNode>(this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD, LHFCDFCDHLN<TMInput> JNGJBGMHDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x23C6B60", Offset = "0x23C5760", VA = "0x1823C6B60")]
	internal static void PHMFDMABCBG<TMInput, TMOutput, TMNode>(this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD, LHFCDFCDHLN<TMOutput> IMGOHMOIADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x23C6760", Offset = "0x23C5360", VA = "0x1823C6760")]
	internal static void AMDGJDJKKCD<TMInput, TMOutput, TMNode>(this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD, int DCGGFHOCGGH, LHFCDFCDHLN<TMInput> JNGJBGMHDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x23C77D0", Offset = "0x23C63D0", VA = "0x1823C77D0")]
	internal static void OCCOOMDHOJC<TMInput, TMOutput, TMNode>(this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD, int DCGGFHOCGGH, LHFCDFCDHLN<TMOutput> IMGOHMOIADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x23C6800", Offset = "0x23C5400", VA = "0x1823C6800")]
	internal static void GAKOBPMMOPM<TMInput, TMOutput, TMNode>(this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD, LHFCDFCDHLN<TMInput> JNGJBGMHDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x23C6B60", Offset = "0x23C5760", VA = "0x1823C6B60")]
	internal static void HIGFECNIAMA<TMInput, TMOutput, TMNode>(this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD, LHFCDFCDHLN<TMOutput> IMGOHMOIADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x23C6840", Offset = "0x23C5440", VA = "0x1823C6840")]
	public static AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>.DECDHODHODD NDEABDNCEDE<TMInput, TMOutput, TMNode>([In] this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>.DECDHODHODD);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x22DDC20", Offset = "0x22DC820", VA = "0x1822DDC20")]
	public static AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>.DECDHODHODD LMBMCPDNFKP<TMOutput, TMInput, TMNode>([In] this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>.DECDHODHODD);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x23C6840", Offset = "0x23C5440", VA = "0x1823C6840")]
	public static NFIGBEFEAMI<LHFCDFCDHLN<TMInput>, AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>.DECDHODHODD> GPKFEAGMOOH<TMInput, TMOutput, TMNode>([In] this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(NFIGBEFEAMI<LHFCDFCDHLN<TMInput>, AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>.DECDHODHODD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x22DDC20", Offset = "0x22DC820", VA = "0x1822DDC20")]
	public static NFIGBEFEAMI<LHFCDFCDHLN<TMOutput>, AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>.DECDHODHODD> OKNNIDNIGIH<TMOutput, TMInput, TMNode>([In] this GEPHLJGEKGM<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> HLINMGJJNHD)
	{
		return default(NFIGBEFEAMI<LHFCDFCDHLN<TMOutput>, AFOLGPAAIPI<LHFCDFCDHLN<TMOutput>>.DECDHODHODD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x22DD080", Offset = "0x22DBC80", VA = "0x1822DD080")]
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
	[Cpp2IlInjected.Address(RVA = "0x3588240", Offset = "0x3586E40", VA = "0x183588240")]
	internal IBPJHMDCMIL([In] AIFOBENAFOG<TMOutput> NLGFHGBNOGB, [In] NGLFKLMDBCE<TMOutput, LHFCDFCDHLN<TMNode>> MCONEMCFFOM, [In] NGLFKLMDBCE<TMOutput, AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>> KOIHGOCMHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3587FD0", Offset = "0x3586BD0", VA = "0x183587FD0")]
	internal static IBPJHMDCMIL<TMInput, TMOutput, TMNode> OOMHMBNJBCG()
	{
		return default(IBPJHMDCMIL<TMInput, TMOutput, TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class IBNGBGFNDHE
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x252A5F0", Offset = "0x25291F0", VA = "0x18252A5F0")]
	internal static ACFFDFACBHO OIIEHDKDHEB<TMInput, TMOutput, TMNode>([In] this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2529E70", Offset = "0x2528A70", VA = "0x182529E70")]
	internal static IBPJHMDCMIL<TMInput, TMOutput, TMNode> JFKFFNFOIMD<TMInput, TMOutput, TMNode>(this ACFFDFACBHO HHHLENOMLMP)
	{
		return default(IBPJHMDCMIL<TMInput, TMOutput, TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x252A380", Offset = "0x2528F80", VA = "0x18252A380")]
	private static LKOPPNAMIIL MLGJGJCINHD<TMInput>([In] this AFOLGPAAIPI<LHFCDFCDHLN<TMInput>> HHHLENOMLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x25299B0", Offset = "0x25285B0", VA = "0x1825299B0")]
	private static AFOLGPAAIPI<LHFCDFCDHLN<TMInput>> AGOJDINPJPN<TMInput>(this LKOPPNAMIIL HHHLENOMLMP)
	{
		return default(AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2529C50", Offset = "0x2528850", VA = "0x182529C50")]
	internal static void HBPPMPIFHCM<TMInput, TMOutput, TMNode>(this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x252A550", Offset = "0x2529150", VA = "0x18252A550")]
	internal static LHFCDFCDHLN<TMOutput> OGGICBDPIDD<TMOutput, TMInput, TMNode>(this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMNode> NIICEONAONO)
	{
		return default(LHFCDFCDHLN<TMOutput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2529DE0", Offset = "0x25289E0", VA = "0x182529DE0")]
	internal static void IJNJJGHDBFD<TMInput, TMOutput, TMNode>(this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> HLINMGJJNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x22D3060", Offset = "0x22D1C60", VA = "0x1822D3060")]
	public static bool ENKHGCDGNNP<TMInput, TMOutput, TMNode>([In] this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> HLINMGJJNHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2529C30", Offset = "0x2528830", VA = "0x182529C30")]
	public static LHFCDFCDHLN<TMNode> CAGOICAGMPO<TMNode, TMInput, TMOutput>([In] this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> HLINMGJJNHD)
	{
		return default(LHFCDFCDHLN<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x23C7790", Offset = "0x23C6390", VA = "0x1823C7790")]
	public static int OGOMFBBAEGC<TMInput, TMOutput, TMNode>([In] this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> HLINMGJJNHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x23C6710", Offset = "0x23C5310", VA = "0x1823C6710")]
	public static LHFCDFCDHLN<TMInput> ECDBGAPFIIK<TMInput, TMOutput, TMNode>([In] this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> HLINMGJJNHD, int DCGGFHOCGGH)
	{
		return default(LHFCDFCDHLN<TMInput>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x23C6B60", Offset = "0x23C5760", VA = "0x1823C6B60")]
	internal static void FENOHPFELJH<TMInput, TMOutput, TMNode>(this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> HLINMGJJNHD, LHFCDFCDHLN<TMInput> JNGJBGMHDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x23C6B60", Offset = "0x23C5760", VA = "0x1823C6B60")]
	internal static void GAKOBPMMOPM<TMInput, TMOutput, TMNode>(this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> HLINMGJJNHD, LHFCDFCDHLN<TMInput> JNGJBGMHDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x22DDC20", Offset = "0x22DC820", VA = "0x1822DDC20")]
	public static AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>.DECDHODHODD NDEABDNCEDE<TMInput, TMOutput, TMNode>([In] this IBPJHMDCMIL<TMInput, TMOutput, TMNode> HHHLENOMLMP, LHFCDFCDHLN<TMOutput> HLINMGJJNHD)
	{
		return default(AFOLGPAAIPI<LHFCDFCDHLN<TMInput>>.DECDHODHODD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x22DDC20", Offset = "0x22DC820", VA = "0x1822DDC20")]
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
