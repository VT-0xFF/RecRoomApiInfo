using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class JDEIMIFLBKB : DKMGLLPPCLP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool PNOJHBNFHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x522EC0", Offset = "0x521CC0", VA = "0x180522EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	private JDEIMIFLBKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4BC11B0", Offset = "0x4BBFFB0", VA = "0x184BC11B0")]
	public static JDEIMIFLBKB PEPJCOIMNOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "4")]
	public void EJCIKGJGJPD(Func<string> CLDEJGBBMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "5")]
	public void CNFFHBNCHIH()
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
