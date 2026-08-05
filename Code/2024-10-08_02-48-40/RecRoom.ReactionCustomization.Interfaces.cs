using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DEMDKIFCAJB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NCGGHALNBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2973C68A804728", Offset = "0x0", VA = "0x2973C80A804728", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	OAACCCGABIO AGKAJMNDCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA80474280297419", Offset = "0x0", VA = "0xA80474400297419", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	OAACCCGABIO PHMDKALKEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x29741D80297419", Offset = "0x0", VA = "0x29741F00297419", Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	List<string> HLBNAJGJPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x29741D8A804754", Offset = "0x0", VA = "0x29741F0A804754", Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA80474280297470", Offset = "0x0", VA = "0xA80474400297470", Slot = "4")]
	void MDCMMKCCHAB(List<(string, GCHEHPBJEEK)> HBIGPGDEOIM);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x29749380297470", Offset = "0x0", VA = "0x29749500297470", Slot = "5")]
	string[] DACOFIHBONL(string MFODLCJJHOC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2974938A5D9E4C", Offset = "0x0", VA = "0x2974950A5D9E4C", Slot = "6")]
	bool OGFNECGHKIC(string MFODLCJJHOC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xA80482680297558", Offset = "0x0", VA = "0xA80482800297558", Slot = "7")]
	string FIAKGMCFEAI(string MFODLCJJHOC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2975A780297558", Offset = "0x0", VA = "0x2975A900297558", Slot = "8")]
	GCHEHPBJEEK INHKBOICNEI(string MFODLCJJHOC);
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
