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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B7AD10", Offset = "0x2B79710", VA = "0x182B7AD10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct IEPFIFLOMKA<TMNode> : IEnumerator<HOHDPLDONAJ<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HOHDPLDONAJ<TMNode> LIGIGNNHDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly LGCELBLJKFI<TMNode, HOHDPLDONAJ<TMNode>> FHLPAILGDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private HOHDPLDONAJ<TMNode> AFBJNAKBDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool BALOBLGPOOA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HOHDPLDONAJ<TMNode> IGCJDJEKHNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20", Slot = "4")]
		get
		{
			return default(HOHDPLDONAJ<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x52DBAC0", Offset = "0x52DA4C0", VA = "0x1852DBAC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x52DBB40", Offset = "0x52DA540", VA = "0x1852DBB40")]
	internal IEPFIFLOMKA(HOHDPLDONAJ<TMNode> NPCHJIPLCII, [In] LGCELBLJKFI<TMNode, HOHDPLDONAJ<TMNode>> INPLEBDDOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x52DB860", Offset = "0x52DA260", VA = "0x1852DB860", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x52DBAB0", Offset = "0x52DA4B0", VA = "0x1852DBAB0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct CJBJJFDOKOE<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal static readonly HOHDPLDONAJ<TMNode> KEGAFBNBAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal MBIENDFFGHC<TMNode> KPCNEADOIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal LGCELBLJKFI<TMNode, HOHDPLDONAJ<TMNode>> FHLPAILGDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal LGCELBLJKFI<TMNode, DBIBICKBIIJ<HOHDPLDONAJ<TMNode>>> LMBLBPBCGNI;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2B74EA0", Offset = "0x2B738A0", VA = "0x182B74EA0")]
	internal CJBJJFDOKOE([In] MBIENDFFGHC<TMNode> LHGAGJBLMIO, [In] LGCELBLJKFI<TMNode, HOHDPLDONAJ<TMNode>> INPLEBDDOIB, [In] LGCELBLJKFI<TMNode, DBIBICKBIIJ<HOHDPLDONAJ<TMNode>>> GJKKECFLMJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6CE5660", Offset = "0x6CE4060", VA = "0x186CE5660")]
	public static CJBJJFDOKOE<TMNode> KDBDJPAJKDJ()
	{
		return default(CJBJJFDOKOE<TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class OOFPKFGMPLH
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3F5AAA0", Offset = "0x3F594A0", VA = "0x183F5AAA0")]
	public static BJGFEMJPCEG GCGCKFHBJPB<TMNode>([In] this CJBJJFDOKOE<TMNode> DKGBCFDLMOI) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3F5A6E0", Offset = "0x3F590E0", VA = "0x183F5A6E0")]
	internal static AKNNHPLFFEF FCAPJIIJAMO<TMNode>([In] this DBIBICKBIIJ<HOHDPLDONAJ<TMNode>> DKGBCFDLMOI) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3F5AE50", Offset = "0x3F59850", VA = "0x183F5AE50")]
	internal static DBIBICKBIIJ<HOHDPLDONAJ<TMNode>> KFFGKDDLLLP<TMNode>(this AKNNHPLFFEF DKGBCFDLMOI) where TMNode : notnull
	{
		return default(DBIBICKBIIJ<HOHDPLDONAJ<TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3F5B3D0", Offset = "0x3F59DD0", VA = "0x183F5B3D0")]
	public static void PIIFCIMJIKL<TMNode>(this CJBJJFDOKOE<TMNode> DKGBCFDLMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3F5AE40", Offset = "0x3F59840", VA = "0x183F5AE40")]
	public static bool JBKJHIIAKGB<TMNode>([In] this CJBJJFDOKOE<TMNode> DKGBCFDLMOI, HOHDPLDONAJ<TMNode> NMAIBBDGPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3F5AE30", Offset = "0x3F59830", VA = "0x183F5AE30")]
	public static int GFGCJDNPPIK<TMNode>([In] this CJBJJFDOKOE<TMNode> DKGBCFDLMOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3F5A8B0", Offset = "0x3F592B0", VA = "0x183F5A8B0")]
	public static HOHDPLDONAJ<TMNode?> FFNJINDGFGA<TMNode>(this CJBJJFDOKOE<TMNode> DKGBCFDLMOI)
	{
		return default(HOHDPLDONAJ<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3F5A610", Offset = "0x3F59010", VA = "0x183F5A610")]
	public static HOHDPLDONAJ<TMNode?> CNPDEFPGCCC<TMNode>(this CJBJJFDOKOE<TMNode> DKGBCFDLMOI, HOHDPLDONAJ<TMNode> AEMEEJKFKNN)
	{
		return default(HOHDPLDONAJ<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3F5B0B0", Offset = "0x3F59AB0", VA = "0x183F5B0B0")]
	public static void KKMANOPBDMJ<TMNode>(this CJBJJFDOKOE<TMNode> DKGBCFDLMOI, HOHDPLDONAJ<TMNode> NMAIBBDGPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3F5A580", Offset = "0x3F58F80", VA = "0x183F5A580")]
	public static bool CDGODCGHBAH<TMNode>([In] this CJBJJFDOKOE<TMNode> DKGBCFDLMOI, HOHDPLDONAJ<TMNode> NMAIBBDGPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3F0AC50", Offset = "0x3F09650", VA = "0x183F0AC50")]
	public static HOHDPLDONAJ<TMNode?> GICCPKEANJD<TMNode>([In] this CJBJJFDOKOE<TMNode> DKGBCFDLMOI, HOHDPLDONAJ<TMNode> NMAIBBDGPCD)
	{
		return default(HOHDPLDONAJ<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3F5B310", Offset = "0x3F59D10", VA = "0x183F5B310")]
	public static HOHDPLDONAJ<TMNode?>? ONDOMDDMAME<TMNode>([In] this CJBJJFDOKOE<TMNode> DKGBCFDLMOI, HOHDPLDONAJ<TMNode> NMAIBBDGPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3F5A450", Offset = "0x3F58E50", VA = "0x183F5A450")]
	public static void CBLBLJAMJCE<TMNode>(this CJBJJFDOKOE<TMNode> DKGBCFDLMOI, HOHDPLDONAJ<TMNode> NMAIBBDGPCD, HOHDPLDONAJ<TMNode> BPIHCBPFOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3F5AA40", Offset = "0x3F59440", VA = "0x183F5AA40")]
	public static PBLIJBPBDIB<HOHDPLDONAJ<TMNode?>, DBIBICKBIIJ<HOHDPLDONAJ<TMNode?>>.PNODPBCKBCC> FMDGPNCDJBH<TMNode>([In] this CJBJJFDOKOE<TMNode> DKGBCFDLMOI, HOHDPLDONAJ<TMNode> NMAIBBDGPCD)
	{
		return default(PBLIJBPBDIB<HOHDPLDONAJ<TMNode>, DBIBICKBIIJ<HOHDPLDONAJ<TMNode>>.PNODPBCKBCC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xE2F470", Offset = "0xE2DE70", VA = "0x180E2F470")]
	public static MBIENDFFGHC<TMNode?> NNNCEGFBOKD<TMNode>([In] this CJBJJFDOKOE<TMNode> DKGBCFDLMOI)
	{
		return default(MBIENDFFGHC<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3F0AAF0", Offset = "0x3F094F0", VA = "0x183F0AAF0")]
	public static MBIENDFFGHC<TMNode?>.GNPIGPGHIJH FIIFAFDLDFC<TMNode>([In] this CJBJJFDOKOE<TMNode> DKGBCFDLMOI)
	{
		return default(MBIENDFFGHC<TMNode>.GNPIGPGHIJH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3F0AC70", Offset = "0x3F09670", VA = "0x183F0AC70")]
	public static DPBDBKAMFJF<HOHDPLDONAJ<TMNode?>, MBIENDFFGHC<TMNode?>.GNPIGPGHIJH> ALMCMAJICHA<TMNode>([In] this CJBJJFDOKOE<TMNode> DKGBCFDLMOI)
	{
		return default(DPBDBKAMFJF<HOHDPLDONAJ<TMNode>, MBIENDFFGHC<TMNode>.GNPIGPGHIJH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3F5A9A0", Offset = "0x3F593A0", VA = "0x183F5A9A0")]
	public static bool FLCDLGFIEPI<TMNode>([In] this CJBJJFDOKOE<TMNode> DKGBCFDLMOI, HOHDPLDONAJ<TMNode> MNHKIMAOFNO, HOHDPLDONAJ<TMNode> KMBKKMFGMEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3F5A3C0", Offset = "0x3F58DC0", VA = "0x183F5A3C0")]
	public static DPBDBKAMFJF<HOHDPLDONAJ<TMNode?>, IEPFIFLOMKA<TMNode?>> AMIDANEBJMO<TMNode>([In] this CJBJJFDOKOE<TMNode> DKGBCFDLMOI, HOHDPLDONAJ<TMNode> MNHKIMAOFNO)
	{
		return default(DPBDBKAMFJF<HOHDPLDONAJ<TMNode>, IEPFIFLOMKA<TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class MPNCFDBMDEM
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3EA9FD0", Offset = "0x3EA89D0", VA = "0x183EA9FD0")]
	public static CJBJJFDOKOE<TMNode> LEOAOCFGODA<TMNode>(this BJGFEMJPCEG DKGBCFDLMOI) where TMNode : notnull
	{
		return default(CJBJJFDOKOE<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2B7AB20", Offset = "0x2B79520", VA = "0x182B7AB20")]
	public static void KKMANOPBDMJ(this BJGFEMJPCEG DKGBCFDLMOI, int NMAIBBDGPCD)
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
