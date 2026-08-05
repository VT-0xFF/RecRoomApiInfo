using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class DCLLKAFGLHN<TData> : FDKFIPGCOGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string PJHOPJJKDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData IGFBHOELDIM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
	public override string ILHCPMBLOJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x56E7D70", Offset = "0x56E6570", VA = "0x1856E7D70")]
	internal DCLLKAFGLHN(string CLBGCJICGJG, [In] TData MLKNGAFFKGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JDHOCNPGHDI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1F95040", Offset = "0x1F93840", VA = "0x181F95040")]
	public static DCLLKAFGLHN<KNDENJDHONE> OJFFIHPLODM(string CLBGCJICGJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x289C620", Offset = "0x289AE20", VA = "0x18289C620")]
	public static DCLLKAFGLHN<TData> OJFFIHPLODM<TData>(string CLBGCJICGJG, [In] TData MLKNGAFFKGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IGONEBCNBEO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2ACA890", Offset = "0x2AC9090", VA = "0x182ACA890")]
	public static MEKCEIEFNPI<TOk, MNGIPKBLGNG> KCHMHAGAIND<TOk>([In] this MEKCEIEFNPI<TOk, MNGIPKBLGNG> EGJINJKGIAK, string CLBGCJICGJG)
	{
		return default(MEKCEIEFNPI<TOk, MNGIPKBLGNG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class FDKFIPGCOGB : PLHOCJDFICM, MNGIPKBLGNG, DCIBOGBGGHI
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1F5AAE0", Offset = "0x1F592E0", VA = "0x181F5AAE0")]
	protected FDKFIPGCOGB()
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
