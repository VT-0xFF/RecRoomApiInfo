using System;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JCILEDGJJHH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ProgressionEventDTO NGBMPAMMHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B901E875DE6BC", Offset = "0x0", VA = "0x2B9020075DE6BC", Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ProgressionEventRecordDTO MDFKPOHHPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x75DFB6E802B9075", Offset = "0x0", VA = "0x75DFB70002B9075", Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	MHLBHCCEHGD ODBJPEIGCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B90E4802B9080", Offset = "0x0", VA = "0x2B90E6002B9080", Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int NLDMHEPMOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B90EE875E0034", Offset = "0x0", VA = "0x2B90F0075E0034", Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KPJINLBHHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x75DE7AA802B920C", Offset = "0x0", VA = "0x75DE7AC002B920C", Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action EPNFIEKCEJH;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action BJNPNLOPBOC;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x75EB25A802B9159", Offset = "0x0", VA = "0x75EB25C002B9159", Slot = "8")]
	global::DIHJKCFGFNO<bool> BABEHPKIJEA();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2B91C5802B9160", Offset = "0x0", VA = "0x2B91C7002B9160", Slot = "9")]
	IGOPHNBFNOE BMOEIMDFFHB();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2B91CE875DE7AC", Offset = "0x0", VA = "0x2B91D0075DE7AC", Slot = "10")]
	IGOPHNBFNOE CAKLCJCAALL(int BLGIMANEJMP);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2B9274802B9210", Offset = "0x0", VA = "0x2B9276002B9210", Slot = "12")]
	void DMEENEIONCA();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2B927E875EC04C", Offset = "0x0", VA = "0x2B9280075EC04C", Slot = "13")]
	string LGBIHGLNEAG(BBOCJMPBDCI GJKOCJCKFPI);
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
