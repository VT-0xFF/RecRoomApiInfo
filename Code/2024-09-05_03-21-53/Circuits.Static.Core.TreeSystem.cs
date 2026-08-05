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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
		[Cpp2IlInjected.Address(RVA = "0x20CD560", Offset = "0x20CBF60", VA = "0x1820CD560")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC90", Offset = "0x8AD690", VA = "0x1808AEC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AECD0", Offset = "0x8AD6D0", VA = "0x1808AECD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct IHDMDKFDHPO<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal static readonly MLGFJIHMDCD<TMNode> OLGDMNKJILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal HOLEDOMPNHA<TMNode> KHKFNOJNOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal IJMILKHKGPD<TMNode, MLGFJIHMDCD<TMNode>> FPCNIOMBCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal IJMILKHKGPD<TMNode, CBGFCAOFHCN<MLGFJIHMDCD<TMNode>>> DLJADOIMGCD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x20C5F20", Offset = "0x20C4920", VA = "0x1820C5F20")]
	internal IHDMDKFDHPO([In] HOLEDOMPNHA<TMNode> NPKDLCGEAOH, [In] IJMILKHKGPD<TMNode, MLGFJIHMDCD<TMNode>> AHMMFNNKPMO, [In] IJMILKHKGPD<TMNode, CBGFCAOFHCN<MLGFJIHMDCD<TMNode>>> ILODEJKNGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x400E3A0", Offset = "0x400CDA0", VA = "0x18400E3A0")]
	public static IHDMDKFDHPO<TMNode> MMKGNMBHOIH()
	{
		return default(IHDMDKFDHPO<TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class AAPOCIAKGFF
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3345490", Offset = "0x3343E90", VA = "0x183345490")]
	public static JOOGLOHMMHN LKLOMDOAOHF<TMNode>([In] this IHDMDKFDHPO<TMNode> PECHDAFMNOO) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3344C70", Offset = "0x3343670", VA = "0x183344C70")]
	public static IHDMDKFDHPO<TMNode> ILDFGHALABA<TMNode>(this JOOGLOHMMHN PECHDAFMNOO) where TMNode : notnull
	{
		return default(IHDMDKFDHPO<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x33446C0", Offset = "0x33430C0", VA = "0x1833446C0")]
	internal static DOJEBFCEPMA BDIMPHNPCCP<TMNode>([In] this CBGFCAOFHCN<MLGFJIHMDCD<TMNode>> PECHDAFMNOO) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3345C00", Offset = "0x3344600", VA = "0x183345C00")]
	internal static CBGFCAOFHCN<MLGFJIHMDCD<TMNode>> OKKCJOPJJGE<TMNode>(this DOJEBFCEPMA PECHDAFMNOO) where TMNode : notnull
	{
		return default(CBGFCAOFHCN<MLGFJIHMDCD<TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x33448C0", Offset = "0x33432C0", VA = "0x1833448C0")]
	public static void EPGEGEJNIJO<TMNode>(this IHDMDKFDHPO<TMNode> PECHDAFMNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2A10550", Offset = "0x2A0EF50", VA = "0x182A10550")]
	public static bool KAMLGAEHELA<TMNode>([In] this IHDMDKFDHPO<TMNode> PECHDAFMNOO, MLGFJIHMDCD<TMNode> KFBALBFDDFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2A104F0", Offset = "0x2A0EEF0", VA = "0x182A104F0")]
	public static int CJNNJCICCCJ<TMNode>([In] this IHDMDKFDHPO<TMNode> PECHDAFMNOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3345390", Offset = "0x3343D90", VA = "0x183345390")]
	public static MLGFJIHMDCD<TMNode?> KNAGLHBAIAB<TMNode>(this IHDMDKFDHPO<TMNode> PECHDAFMNOO)
	{
		return default(MLGFJIHMDCD<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x33451F0", Offset = "0x3343BF0", VA = "0x1833451F0")]
	public static MLGFJIHMDCD<TMNode?> JANNCBNDJAG<TMNode>(this IHDMDKFDHPO<TMNode> PECHDAFMNOO, MLGFJIHMDCD<TMNode> DLPGBMPJIIG)
	{
		return default(MLGFJIHMDCD<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3345890", Offset = "0x3344290", VA = "0x183345890")]
	public static void NNFNKLLBHJI<TMNode>(this IHDMDKFDHPO<TMNode> PECHDAFMNOO, MLGFJIHMDCD<TMNode> KFBALBFDDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2AFC540", Offset = "0x2AFAF40", VA = "0x182AFC540")]
	public static MLGFJIHMDCD<TMNode?> JEODACCEEOI<TMNode>([In] this IHDMDKFDHPO<TMNode> PECHDAFMNOO, MLGFJIHMDCD<TMNode> KFBALBFDDFF)
	{
		return default(MLGFJIHMDCD<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3344AC0", Offset = "0x33434C0", VA = "0x183344AC0")]
	public static void GAIJNLMIMGF<TMNode>(this IHDMDKFDHPO<TMNode> PECHDAFMNOO, MLGFJIHMDCD<TMNode> KFBALBFDDFF, MLGFJIHMDCD<TMNode> HOPADELEDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3345300", Offset = "0x3343D00", VA = "0x183345300")]
	public static HJDAACCJIHA<MLGFJIHMDCD<TMNode?>, CBGFCAOFHCN<MLGFJIHMDCD<TMNode?>>.MLCMGAMGIAB> JDHOHBGFMPC<TMNode>([In] this IHDMDKFDHPO<TMNode> PECHDAFMNOO, MLGFJIHMDCD<TMNode> KFBALBFDDFF)
	{
		return default(HJDAACCJIHA<MLGFJIHMDCD<TMNode>, CBGFCAOFHCN<MLGFJIHMDCD<TMNode>>.MLCMGAMGIAB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA34E90", Offset = "0xA33890", VA = "0x180A34E90")]
	public static HOLEDOMPNHA<TMNode?> EANPNCMHHEO<TMNode>([In] this IHDMDKFDHPO<TMNode> PECHDAFMNOO)
	{
		return default(HOLEDOMPNHA<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2A29200", Offset = "0x2A27C00", VA = "0x182A29200")]
	public static HOLEDOMPNHA<TMNode?>.JLPCBNPANKJ BPGPEIEKEPK<TMNode>([In] this IHDMDKFDHPO<TMNode> PECHDAFMNOO)
	{
		return default(HOLEDOMPNHA<TMNode>.JLPCBNPANKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2A29200", Offset = "0x2A27C00", VA = "0x182A29200")]
	public static CDOCMFNFDNB<MLGFJIHMDCD<TMNode?>, HOLEDOMPNHA<TMNode?>.JLPCBNPANKJ> KOBOLBCBKNN<TMNode>([In] this IHDMDKFDHPO<TMNode> PECHDAFMNOO)
	{
		return default(CDOCMFNFDNB<MLGFJIHMDCD<TMNode>, HOLEDOMPNHA<TMNode>.JLPCBNPANKJ>);
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
