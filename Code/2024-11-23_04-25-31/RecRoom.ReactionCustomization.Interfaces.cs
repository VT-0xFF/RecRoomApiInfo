using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface OEOPBDCMDMH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LJDJIOKCOOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA9C754E802A5206", Offset = "0x0", VA = "0xA9C7550002A5206", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	APNHDGDPKOI MGKBLJKKACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A5233802A5210", Offset = "0x0", VA = "0x2A5235002A5210", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	APNHDGDPKOI CKDPKLLHLEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2A52338A962018", Offset = "0x0", VA = "0x2A52350A962018", Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	List<string> MKGDHLFFCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA9C7FB2802A52EE", Offset = "0x0", VA = "0xA9C7FB4002A52EE", Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A533D802A52EE", Offset = "0x0", VA = "0x2A533F002A52EE", Slot = "4")]
	void JAEBNEPCIKK(List<(string, BJFNKBANEEA.MPKJOBKELDF)> FIMABINLIKD);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A533D8A9C7FD0", Offset = "0x0", VA = "0x2A533F0A9C7FD0", Slot = "5")]
	string[] PNCAMBLLLPI(string CDKMJEAHJPJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA9C7FDE802A5345", Offset = "0x0", VA = "0xA9C7FE0002A5345", Slot = "6")]
	bool HCHLLDHCKKE(string CDKMJEAHJPJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2A5394802A5345", Offset = "0x0", VA = "0x2A5396002A5345", Slot = "7")]
	string JNHNKANIGJN(string CDKMJEAHJPJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2A539E8A9C7FD0", Offset = "0x0", VA = "0x2A53A00A9C7FD0", Slot = "8")]
	BJFNKBANEEA.MPKJOBKELDF FJIHEEHBDGN(string CDKMJEAHJPJ);
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
