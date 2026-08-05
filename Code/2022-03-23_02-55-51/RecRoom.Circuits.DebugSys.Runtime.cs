using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class NGHEKOOEIEE : LPDMLDHMCNP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool OLKFPFILDHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x521EC0", Offset = "0x5206C0", VA = "0x180521EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	private NGHEKOOEIEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4B1E5E0", Offset = "0x4B1CDE0", VA = "0x184B1E5E0")]
	public static NGHEKOOEIEE PKKPJKMPPCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "4")]
	public void FFJDPMPDDNG(Func<string> CBFODBDAPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "5")]
	public void JNLMMOHMMHC()
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
