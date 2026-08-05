using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GMENJCBONBI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DFEBIBMKFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA9BE3EA8029CB48", Offset = "0x0", VA = "0xA9BE3EC0029CB48", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	LDNMACGBDLI AEFIFKBMNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29CB728029CB50", Offset = "0x0", VA = "0x29CB740029CB50", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	LDNMACGBDLI KNLHEEDKMOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x29CB728A795EB8", Offset = "0x0", VA = "0x29CB740A795EB8", Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	List<string> GKCMOMIKDKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA9BD5CE8029CC1B", Offset = "0x0", VA = "0xA9BD5D00029CC1B", Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x29CC6A8029CC1B", Offset = "0x0", VA = "0x29CC6C0029CC1B", Slot = "4")]
	void NINHAIEMGGB(List<(string, EDOHJDFIDEJ)> IKGCLHEODIM);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x29CC6A8A9BD5EC", Offset = "0x0", VA = "0x29CC6C0A9BD5EC", Slot = "5")]
	string[] AGABHPBOGLN(string EEPFNPOBGCM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA9BD5FA8029CC72", Offset = "0x0", VA = "0xA9BD5FC0029CC72", Slot = "6")]
	bool AAMGGICIFOL(string EEPFNPOBGCM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x29CCC18029CC72", Offset = "0x0", VA = "0x29CCC30029CC72", Slot = "7")]
	string KIPILLHNMAF(string EEPFNPOBGCM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x29CCCE8A9BD5EC", Offset = "0x0", VA = "0x29CCD00A9BD5EC", Slot = "8")]
	EDOHJDFIDEJ AMGDJMLNEHL(string EEPFNPOBGCM);
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
