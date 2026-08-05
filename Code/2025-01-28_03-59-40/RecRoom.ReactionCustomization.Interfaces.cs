using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface OKMHMOLGLIO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FCLLELCHFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xADC920E802C7679", Offset = "0x0", VA = "0xADC9210002C7679", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	AEJLNDNFINA KBOFLHMMLIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2C7707802C7680", Offset = "0x0", VA = "0x2C7709002C7680", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	AEJLNDNFINA BBHLKPDBDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2C770E8ADC9210", Offset = "0x0", VA = "0x2C77100ADC9210", Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	List<string> AJGNMEAPLII
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xADC920E802C7799", Offset = "0x0", VA = "0xADC9210002C7799", Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2C7830802C77A0", Offset = "0x0", VA = "0x2C7832002C77A0", Slot = "4")]
	void OGHGBHEBPBL(List<(string, ICKLLJAMGLG.DDFKMHJCEFL)> AFNPHBHBFCH);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2C783E8ADCA294", Offset = "0x0", VA = "0x2C78400ADCA294", Slot = "5")]
	string[] BGBDCIPDIBK(string CDJEADKFKCJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xADC7186802C78C1", Offset = "0x0", VA = "0xADC7188002C78C1", Slot = "6")]
	bool ICAFIGNGFCO(string CDJEADKFKCJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2C794F802C78D0", Offset = "0x0", VA = "0x2C7951002C78D0", Slot = "7")]
	string EIMOGDAGCOL(string CDJEADKFKCJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2C795E8ADC7188", Offset = "0x0", VA = "0x2C79600ADC7188", Slot = "8")]
	ICKLLJAMGLG.DDFKMHJCEFL OPCNHCMKCFP(string CDJEADKFKCJ);
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
