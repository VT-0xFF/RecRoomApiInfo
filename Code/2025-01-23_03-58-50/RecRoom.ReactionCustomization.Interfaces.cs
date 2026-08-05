using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HNCNMJMELEG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AIGKPPFBGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAC8C796802A7B69", Offset = "0x0", VA = "0xAC8C798002A7B69", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	GCOJJNPJFGN INEDDMGFPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B6D802A7B69", Offset = "0x0", VA = "0x2A7B6F002A7B69", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	GCOJJNPJFGN PPLKCHMPGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B6D8AC8C7A8", Offset = "0x0", VA = "0x2A7B6F0AC8C7A8", Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	List<string> NEPDGMBEJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAC8C796802A7BC0", Offset = "0x0", VA = "0xAC8C798002A7BC0", Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A7BE3802A7BC0", Offset = "0x0", VA = "0x2A7BE5002A7BC0", Slot = "4")]
	void PDBKMNGMKLJ(List<(string, JLDEDNBPGBN.LPLGBBLCAGO)> HJMPBLPFBEC);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A7BE38AA7BC70", Offset = "0x0", VA = "0x2A7BE50AA7BC70", Slot = "5")]
	string[] DDGGMBKDNMJ(string BKNKCNDFGHD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xAC8CEBA802A7C98", Offset = "0x0", VA = "0xAC8CEBC002A7C98", Slot = "6")]
	bool CMBLFALIOOE(string BKNKCNDFGHD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CE7802A7C98", Offset = "0x0", VA = "0x2A7CE9002A7C98", Slot = "7")]
	string ONHBHHOEOKN(string BKNKCNDFGHD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CE78AC8CED8", Offset = "0x0", VA = "0x2A7CE90AC8CED8", Slot = "8")]
	JLDEDNBPGBN.LPLGBBLCAGO MEAECPMGKCG(string BKNKCNDFGHD);
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
