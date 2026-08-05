using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class EINDLJHLLMP : PPJALDODFBH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool OHOHLFAEKFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x523EC0", Offset = "0x522EC0", VA = "0x180523EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
	private EINDLJHLLMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4C001B0", Offset = "0x4BFF1B0", VA = "0x184C001B0")]
	public static EINDLJHLLMP BHANGEOFHDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "4")]
	public void MNEKEJFDBEK(Func<string> PABPMLLKDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "5")]
	public void AJELLMPPAKG()
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
