using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class LFKLGPEJPNI<TData> : GGEPPPFEGHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string KKGDNEGJOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData CNDFKFGJPCE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "7")]
	public override string GMMLNCMCCAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x33CB390", Offset = "0x33CA790", VA = "0x1833CB390")]
	internal LFKLGPEJPNI(string BALNMHDNCIN, in TData HIDEHJGLNHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KJOBPHLJJLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xCD65F0", Offset = "0xCD59F0", VA = "0x180CD65F0")]
	public static global::LFKLGPEJPNI<JAPIHNFIDBB> GILBACJLDCL(string BALNMHDNCIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x169AEB0", Offset = "0x169A2B0", VA = "0x18169AEB0")]
	public static global::LFKLGPEJPNI<TData> GILBACJLDCL<TData>(string BALNMHDNCIN, in TData HIDEHJGLNHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public abstract class GGEPPPFEGHD : KFANFMGGLGP, KIHHJLOCPGF, PAMMHIBIBOL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xCD65E0", Offset = "0xCD59E0", VA = "0x180CD65E0")]
	protected GGEPPPFEGHD()
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
