using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public delegate void NNPGLOAGMMA(HEIIJIHIAKK GPMEIOIEDNN, Entity NBIJCGHBCCI, EntityManager FNBDEMCEOPA);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ILCNCEAHGGK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(HEIIJIHIAKK, OPOFEEJKEHN, NNPGLOAGMMA)> GHBPFCDDBCF(CNOLGAFBLHG PCNDCGBMEJH);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface HHLKFPHIIHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OPOFEEJKEHN LDJOOEHHAGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	OPOFEEJKEHN OGILJAMNEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	OPOFEEJKEHN BOLDNKJIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	OPOFEEJKEHN FPOBJIHOLNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	OPOFEEJKEHN LAGDIGCBPGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	OPOFEEJKEHN NNMMLOOPHJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	OPOFEEJKEHN OODHDGIBPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CNOLGAFBLHG
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	HHLKFPHIIHJ LBDKOCLHBFE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(JPMNNMNBHIP, HEIIJIHIAKK)> GGPHKFEJFLB();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class DLBCMONKJJF : BFBIAJNEBGJ
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public DLBCMONKJJF()
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
