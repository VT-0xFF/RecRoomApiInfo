using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HCGNENBJEMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FOLDLMBMPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA676EA68028F9A9", Offset = "0x0", VA = "0xA676EA80028F9A9", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	DBHLBOFDKDO MDKLBMCEEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28FA648028F9B0", Offset = "0x0", VA = "0x28FA660028F9B0", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DBHLBOFDKDO AFBGGMHLFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x28FA6E8A67B84C", Offset = "0x0", VA = "0x28FA700A67B84C", Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	List<string> FFEGLPIJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA6797728028FB04", Offset = "0x0", VA = "0xA6797740028FB04", Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28FB978028FB10", Offset = "0x0", VA = "0x28FB990028FB10", Slot = "4")]
	void NPEKIDIPGMJ(List<(string, GLFIAOJIINM.PDFEAIHGAJJ)> DNKDJJPEGDB);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x28FB9E8A676EA8", Offset = "0x0", VA = "0x28FBA00A676EA8", Slot = "5")]
	string[] ONBNFMDEDND(string FMKJKEGMGME);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA677F4A8028FC32", Offset = "0x0", VA = "0xA677F4C0028FC32", Slot = "6")]
	bool OIDKHCLLANM(string FMKJKEGMGME);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x28FCC78028FC40", Offset = "0x0", VA = "0x28FCC90028FC40", Slot = "7")]
	string CBNDGCEOGJC(string FMKJKEGMGME);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x28FCCE8A676EA8", Offset = "0x0", VA = "0x28FCD00A676EA8", Slot = "8")]
	GLFIAOJIINM.PDFEAIHGAJJ NFFMAGOJFLE(string FMKJKEGMGME);
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
