using System;
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
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1CCFC70", Offset = "0x1CCE470", VA = "0x181CCFC70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79CCC0", Offset = "0x79B4C0", VA = "0x18079CCC0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x79CD00", Offset = "0x79B500", VA = "0x18079CD00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct DFNMBGPHNNC<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal static readonly BIAFJNPKHBL<TMNode> DHCLNCCKNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal KKHCNNBPMJB<TMNode> IAKPEPGAHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal DHDAPGCBMBJ<TMNode, BIAFJNPKHBL<TMNode>> IFLBEJKPBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal DHDAPGCBMBJ<TMNode, OJBLBICDDLK<BIAFJNPKHBL<TMNode>>> NCMACKMJKOB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3534530", Offset = "0x3532D30", VA = "0x183534530")]
	internal DFNMBGPHNNC([In] KKHCNNBPMJB<TMNode> NELKNKCIMIB, [In] DHDAPGCBMBJ<TMNode, BIAFJNPKHBL<TMNode>> HAHGPPLIFIO, [In] DHDAPGCBMBJ<TMNode, OJBLBICDDLK<BIAFJNPKHBL<TMNode>>> HKNJLPPIDDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3534370", Offset = "0x3532B70", VA = "0x183534370")]
	public static DFNMBGPHNNC<TMNode> AKKFLOCCMNP()
	{
		return default(DFNMBGPHNNC<TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CFNHABODDLD
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x232AC40", Offset = "0x2329440", VA = "0x18232AC40")]
	public static GMIOPLAMPDN JMOOMJHDBEG<TMNode>([In] this DFNMBGPHNNC<TMNode> PIEBBHMNEOG) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x232A090", Offset = "0x2328890", VA = "0x18232A090")]
	public static DFNMBGPHNNC<TMNode> AEDPLFCAHJC<TMNode>(this GMIOPLAMPDN PIEBBHMNEOG) where TMNode : notnull
	{
		return default(DFNMBGPHNNC<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x232B0A0", Offset = "0x23298A0", VA = "0x18232B0A0")]
	internal static IGMHKEMAAJD ODPEBBNEOJO<TMNode>([In] this OJBLBICDDLK<BIAFJNPKHBL<TMNode>> PIEBBHMNEOG) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x232A9C0", Offset = "0x23291C0", VA = "0x18232A9C0")]
	internal static OJBLBICDDLK<BIAFJNPKHBL<TMNode>> EPFPGHJDCCL<TMNode>(this IGMHKEMAAJD PIEBBHMNEOG) where TMNode : notnull
	{
		return default(OJBLBICDDLK<BIAFJNPKHBL<TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x232B270", Offset = "0x2329A70", VA = "0x18232B270")]
	public static void PIODDHMICMM<TMNode>(this DFNMBGPHNNC<TMNode> PIEBBHMNEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x22C93F0", Offset = "0x22C7BF0", VA = "0x1822C93F0")]
	public static bool ODPBAOJILCN<TMNode>([In] this DFNMBGPHNNC<TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x232A6D0", Offset = "0x2328ED0", VA = "0x18232A6D0")]
	public static BIAFJNPKHBL<TMNode?> CJBBHKJKFDA<TMNode>(this DFNMBGPHNNC<TMNode> PIEBBHMNEOG)
	{
		return default(BIAFJNPKHBL<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x232AFD0", Offset = "0x23297D0", VA = "0x18232AFD0")]
	public static BIAFJNPKHBL<TMNode?> LIBPENKGECB<TMNode>(this DFNMBGPHNNC<TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> DEINPDMGBDC)
	{
		return default(BIAFJNPKHBL<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x232A7C0", Offset = "0x2328FC0", VA = "0x18232A7C0")]
	public static void DABJCHJIOBI<TMNode>(this DFNMBGPHNNC<TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x232A9A0", Offset = "0x23291A0", VA = "0x18232A9A0")]
	public static BIAFJNPKHBL<TMNode?> EKMIKGPLLFI<TMNode>([In] this DFNMBGPHNNC<TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC)
	{
		return default(BIAFJNPKHBL<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x232A5A0", Offset = "0x2328DA0", VA = "0x18232A5A0")]
	public static void BLNFAHADBMF<TMNode>(this DFNMBGPHNNC<TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC, BIAFJNPKHBL<TMNode> GEELOGGEEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x22C89D0", Offset = "0x22C71D0", VA = "0x1822C89D0")]
	public static FHBBDJEOIFM<BIAFJNPKHBL<TMNode?>, OJBLBICDDLK<BIAFJNPKHBL<TMNode?>>.JEGAOCIPMMJ> CNICPALMBDK<TMNode>([In] this DFNMBGPHNNC<TMNode> PIEBBHMNEOG, BIAFJNPKHBL<TMNode> MBMFHFDDILC)
	{
		return default(FHBBDJEOIFM<BIAFJNPKHBL<TMNode>, OJBLBICDDLK<BIAFJNPKHBL<TMNode>>.JEGAOCIPMMJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x84A8F0", Offset = "0x8490F0", VA = "0x18084A8F0")]
	public static KKHCNNBPMJB<TMNode?> OLOJFPFEFKF<TMNode>([In] this DFNMBGPHNNC<TMNode> PIEBBHMNEOG)
	{
		return default(KKHCNNBPMJB<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x22CE770", Offset = "0x22CCF70", VA = "0x1822CE770")]
	public static KKHCNNBPMJB<TMNode?>.OFEOLOHFGNJ LLEMGPCMEFC<TMNode>([In] this DFNMBGPHNNC<TMNode> PIEBBHMNEOG)
	{
		return default(KKHCNNBPMJB<TMNode>.OFEOLOHFGNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x22CE770", Offset = "0x22CCF70", VA = "0x1822CE770")]
	public static LAAJNBMKMHO<BIAFJNPKHBL<TMNode?>, KKHCNNBPMJB<TMNode?>.OFEOLOHFGNJ> OPOLLADKGFK<TMNode>([In] this DFNMBGPHNNC<TMNode> PIEBBHMNEOG)
	{
		return default(LAAJNBMKMHO<BIAFJNPKHBL<TMNode>, KKHCNNBPMJB<TMNode>.OFEOLOHFGNJ>);
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
