using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GLFMBHNAMCG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JDHDIFBIKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x903DE86FF0590", Offset = "0x0", VA = "0x903E006FF0590", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F59D728009067F", Offset = "0x0", VA = "0x6F59D740009067F", Slot = "1")]
	void KGNJFDLDFKJ(string KFCJDHCECCC);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x907FF80090680", Offset = "0x0", VA = "0x9080100090680", Slot = "2")]
	void MKGBJEJPLEO();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x9082E86F546F0", Offset = "0x0", VA = "0x9083006F546F0", Slot = "3")]
	void OPFPOGAMHCH(string NJKILBPPEMD);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F5466A80090858", Offset = "0x0", VA = "0x6F5466C00090858", Slot = "4")]
	string HKLOFOFHDJC(object ANFJLMLDELH);
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
