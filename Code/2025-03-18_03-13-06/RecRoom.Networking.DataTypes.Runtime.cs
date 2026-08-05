using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface AAHKIAMBKJC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JMJNPFBFJBH();

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CAJDBKKBGKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KNALDFPMLBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x76D8C30", Offset = "0x76D7E30", VA = "0x1876D8C30")]
	public static void NOJIHLFABJK(this IList<AAHKIAMBKJC> KGCPCICFPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x76D8DE0", Offset = "0x76D7FE0", VA = "0x1876D8DE0")]
	public static void OAAJJPJNNAO(this IList<AAHKIAMBKJC> KGCPCICFPMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GJGNFGDHFCI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int BJJFFAIKOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool DFILHJALDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IDictionary<object, object> IJMGGEOLICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string DOJNEPAKMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int JGCFDFLGFMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OHDFHCLFEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LDKHAKHICKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly string ONDNKNOBKON;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	public LDKHAKHICKG([Optional] string ONDNKNOBKON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x76D8F90", Offset = "0x76D8190", VA = "0x1876D8F90", Slot = "3")]
	public override string ToString()
	{
		return null;
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
