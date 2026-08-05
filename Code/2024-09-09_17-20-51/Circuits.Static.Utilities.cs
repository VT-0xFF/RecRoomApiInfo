using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class OIPOIPBOBBM<TData> : ILCEMBFLKNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string LCPAEDDGIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData EIPGALGMOJD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "7")]
	public override string OIFECEDJIAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4904CA0", Offset = "0x49036A0", VA = "0x184904CA0")]
	internal OIPOIPBOBBM(string BBDGOIMNDJI, [In] TData LNCKNHNHHDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GABDDOGGFPB
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x21A8470", Offset = "0x21A6E70", VA = "0x1821A8470")]
	public static OIPOIPBOBBM<AJBBHDJGBPP> OOAFHJGKFEK(string BBDGOIMNDJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2ACCAF0", Offset = "0x2ACB4F0", VA = "0x182ACCAF0")]
	public static OIPOIPBOBBM<TData> OOAFHJGKFEK<TData>(string BBDGOIMNDJI, [In] TData LNCKNHNHHDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ADEFNIJONPP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3421A90", Offset = "0x3420490", VA = "0x183421A90")]
	public static CDOLGFBAJII<TOk, IDHCEFLHBPO> DOGIINLJFKP<TOk>([In] this CDOLGFBAJII<TOk, IDHCEFLHBPO> NKCEKILMAAM, string BBDGOIMNDJI)
	{
		return default(CDOLGFBAJII<TOk, IDHCEFLHBPO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class ILCEMBFLKNK : PKNKGFKCKHA, IDHCEFLHBPO, NEIFONLMJBM
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2169A30", Offset = "0x2168430", VA = "0x182169A30")]
	protected ILCEMBFLKNK()
	{
	}
}
namespace Cpp2IlInjected;

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
