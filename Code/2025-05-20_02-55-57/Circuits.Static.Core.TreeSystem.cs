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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x27E4AA0", Offset = "0x27E3CA0", VA = "0x1827E4AA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B7B0", Offset = "0xA1A9B0", VA = "0x180A1B7B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct DEJMJGKEDNC<TMNode> : IEnumerator<JFIBBLJIDCN<TMNode>>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly JFIBBLJIDCN<TMNode> HMOMEHDLJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly KGAPBMDBEOB<TMNode, JFIBBLJIDCN<TMNode>> GCACBCLLOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private JFIBBLJIDCN<TMNode> MCPCLGLPBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private bool MBPFHAPPOOH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public JFIBBLJIDCN<TMNode> HJBNOIBEMOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0", Slot = "4")]
		get
		{
			return default(JFIBBLJIDCN<TMNode>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6A1FAD0", Offset = "0x6A1ECD0", VA = "0x186A1FAD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A1FB40", Offset = "0x6A1ED40", VA = "0x186A1FB40")]
	internal DEJMJGKEDNC(JFIBBLJIDCN<TMNode> CAECICLJFEI, [In] KGAPBMDBEOB<TMNode, JFIBBLJIDCN<TMNode>> HINDHCKKJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F860", Offset = "0x6A1EA60", VA = "0x186A1F860", Slot = "6")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A1FAC0", Offset = "0x6A1ECC0", VA = "0x186A1FAC0", Slot = "8")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct BLKLGIEPFMI<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal static readonly JFIBBLJIDCN<TMNode> EPONKKKGMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal DHEEBEEFOLH<TMNode> LBLPIHNCAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal KGAPBMDBEOB<TMNode, JFIBBLJIDCN<TMNode>> GCACBCLLOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal KGAPBMDBEOB<TMNode, PAKIJLEMGBA<JFIBBLJIDCN<TMNode>>> FJPOABICJKF;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x27E1020", Offset = "0x27E0220", VA = "0x1827E1020")]
	internal BLKLGIEPFMI([In] DHEEBEEFOLH<TMNode> GOFHHJFDBCC, [In] KGAPBMDBEOB<TMNode, JFIBBLJIDCN<TMNode>> HINDHCKKJMJ, [In] KGAPBMDBEOB<TMNode, PAKIJLEMGBA<JFIBBLJIDCN<TMNode>>> MGLEGFEFPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x605DBB0", Offset = "0x605CDB0", VA = "0x18605DBB0")]
	public static BLKLGIEPFMI<TMNode> OIKMHICCLEP()
	{
		return default(BLKLGIEPFMI<TMNode>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class KHOJIFONPCE
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x38AC170", Offset = "0x38AB370", VA = "0x1838AC170")]
	public static MKEJLNPMEPL CEBCPPBDNIB<TMNode>([In] this BLKLGIEPFMI<TMNode> CEENCLMGJAM) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x38ACE80", Offset = "0x38AC080", VA = "0x1838ACE80")]
	internal static ACHAAAFIBKM IJCDPNNOBNF<TMNode>([In] this PAKIJLEMGBA<JFIBBLJIDCN<TMNode>> CEENCLMGJAM) where TMNode : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x38AC580", Offset = "0x38AB780", VA = "0x1838AC580")]
	internal static PAKIJLEMGBA<JFIBBLJIDCN<TMNode>> DMKJHNBKBOO<TMNode>(this ACHAAAFIBKM CEENCLMGJAM) where TMNode : notnull
	{
		return default(PAKIJLEMGBA<JFIBBLJIDCN<TMNode>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x38AD190", Offset = "0x38AC390", VA = "0x1838AD190")]
	public static void NHLEMPKJEGJ<TMNode>(this BLKLGIEPFMI<TMNode> CEENCLMGJAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x38AC160", Offset = "0x38AB360", VA = "0x1838AC160")]
	public static bool BFOGLOCPFFB<TMNode>([In] this BLKLGIEPFMI<TMNode> CEENCLMGJAM, JFIBBLJIDCN<TMNode> MKHHKDJKLDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x38AD180", Offset = "0x38AC380", VA = "0x1838AD180")]
	public static int NBFANKODBGP<TMNode>([In] this BLKLGIEPFMI<TMNode> CEENCLMGJAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x38AD600", Offset = "0x38AC800", VA = "0x1838AD600")]
	public static JFIBBLJIDCN<TMNode?> OPFHKGILNAI<TMNode>(this BLKLGIEPFMI<TMNode> CEENCLMGJAM)
	{
		return default(JFIBBLJIDCN<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x38ACBD0", Offset = "0x38ABDD0", VA = "0x1838ACBD0")]
	public static JFIBBLJIDCN<TMNode?> ELAPKFLIDGG<TMNode>(this BLKLGIEPFMI<TMNode> CEENCLMGJAM, JFIBBLJIDCN<TMNode> NJHDJGHEICO)
	{
		return default(JFIBBLJIDCN<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x38AC830", Offset = "0x38ABA30", VA = "0x1838AC830")]
	public static void EFCGIOJACBM<TMNode>(this BLKLGIEPFMI<TMNode> CEENCLMGJAM, JFIBBLJIDCN<TMNode> MKHHKDJKLDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x38AD0C0", Offset = "0x38AC2C0", VA = "0x1838AD0C0")]
	public static bool MFLKPIINKAB<TMNode>([In] this BLKLGIEPFMI<TMNode> CEENCLMGJAM, JFIBBLJIDCN<TMNode> MKHHKDJKLDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x38AC550", Offset = "0x38AB750", VA = "0x1838AC550")]
	public static JFIBBLJIDCN<TMNode?> DICAHIEPFHK<TMNode>([In] this BLKLGIEPFMI<TMNode> CEENCLMGJAM, JFIBBLJIDCN<TMNode> MKHHKDJKLDN)
	{
		return default(JFIBBLJIDCN<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x38ACCE0", Offset = "0x38ABEE0", VA = "0x1838ACCE0")]
	public static JFIBBLJIDCN<TMNode?>? GCALODCMNDA<TMNode>([In] this BLKLGIEPFMI<TMNode> CEENCLMGJAM, JFIBBLJIDCN<TMNode> MKHHKDJKLDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x38AD380", Offset = "0x38AC580", VA = "0x1838AD380")]
	public static void NNGADDPCJDO<TMNode>(this BLKLGIEPFMI<TMNode> CEENCLMGJAM, JFIBBLJIDCN<TMNode> MKHHKDJKLDN, JFIBBLJIDCN<TMNode> AMCLMEHBLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x38AD700", Offset = "0x38AC900", VA = "0x1838AD700")]
	public static JKJCKGDOPOJ<JFIBBLJIDCN<TMNode?>, PAKIJLEMGBA<JFIBBLJIDCN<TMNode?>>.KDONGFBHLCE> PABDPGDPOGF<TMNode>([In] this BLKLGIEPFMI<TMNode> CEENCLMGJAM, JFIBBLJIDCN<TMNode> MKHHKDJKLDN)
	{
		return default(JKJCKGDOPOJ<JFIBBLJIDCN<TMNode>, PAKIJLEMGBA<JFIBBLJIDCN<TMNode>>.KDONGFBHLCE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
	public static DHEEBEEFOLH<TMNode?> AHNHHHJMGFK<TMNode>([In] this BLKLGIEPFMI<TMNode> CEENCLMGJAM)
	{
		return default(DHEEBEEFOLH<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x38AD080", Offset = "0x38AC280", VA = "0x1838AD080")]
	public static DHEEBEEFOLH<TMNode?>.ENAECCMOOGC MAJHBAEJHEK<TMNode>([In] this BLKLGIEPFMI<TMNode> CEENCLMGJAM)
	{
		return default(DHEEBEEFOLH<TMNode>.ENAECCMOOGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x38ACB90", Offset = "0x38ABD90", VA = "0x1838ACB90")]
	public static MAIDBPOBJJB<JFIBBLJIDCN<TMNode?>, DHEEBEEFOLH<TMNode?>.ENAECCMOOGC> EIHMOKBKBFE<TMNode>([In] this BLKLGIEPFMI<TMNode> CEENCLMGJAM)
	{
		return default(MAIDBPOBJJB<JFIBBLJIDCN<TMNode>, DHEEBEEFOLH<TMNode>.ENAECCMOOGC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x38AD530", Offset = "0x38AC730", VA = "0x1838AD530")]
	public static bool OMOFALCMBIH<TMNode>([In] this BLKLGIEPFMI<TMNode> CEENCLMGJAM, JFIBBLJIDCN<TMNode> GCEDHPINDAM, JFIBBLJIDCN<TMNode> BEEGJLCIAJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x38ACDD0", Offset = "0x38ABFD0", VA = "0x1838ACDD0")]
	public static MAIDBPOBJJB<JFIBBLJIDCN<TMNode?>, DEJMJGKEDNC<TMNode?>> HMLMFEMFBNF<TMNode>([In] this BLKLGIEPFMI<TMNode> CEENCLMGJAM, JFIBBLJIDCN<TMNode> GCEDHPINDAM)
	{
		return default(MAIDBPOBJJB<JFIBBLJIDCN<TMNode>, DEJMJGKEDNC<TMNode>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class LCGKBOBMBNF
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x38BA8C0", Offset = "0x38B9AC0", VA = "0x1838BA8C0")]
	public static BLKLGIEPFMI<TMNode> JKAINKAKBPB<TMNode>(this MKEJLNPMEPL CEENCLMGJAM) where TMNode : notnull
	{
		return default(BLKLGIEPFMI<TMNode>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x27E48B0", Offset = "0x27E3AB0", VA = "0x1827E48B0")]
	public static void EFCGIOJACBM(this MKEJLNPMEPL CEENCLMGJAM, int MKHHKDJKLDN)
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
