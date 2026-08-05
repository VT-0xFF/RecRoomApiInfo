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
		[Cpp2IlInjected.Address(RVA = "0x2A3C22802A3B90", Offset = "0x0", VA = "0x2A3C24002A3B90", Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ProgressionEventRecordDTO MDFKPOHHPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2A3C2E875DE5A0", Offset = "0x0", VA = "0x2A3C30075DE5A0", Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	MHLBHCCEHGD ODBJPEIGCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x75DE59E802A3C80", Offset = "0x0", VA = "0x75DE5A0002A3C80", Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int NLDMHEPMOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2A3CF1802A3C80", Offset = "0x0", VA = "0x2A3CF3002A3C80", Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KPJINLBHHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2A42AD875E6F30", Offset = "0x0", VA = "0x2A42AF075E6F30", Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action EPNFIEKCEJH;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action BJNPNLOPBOC;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2A40CE875DE5A0", Offset = "0x0", VA = "0x2A40D0075DE5A0", Slot = "8")]
	global::DIHJKCFGFNO<bool> BABEHPKIJEA();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x75DE9F6802A4187", Offset = "0x0", VA = "0x75DE9F8002A4187", Slot = "9")]
	IGOPHNBFNOE BMOEIMDFFHB();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2A42AD802A4250", Offset = "0x0", VA = "0x2A42AF002A4250", Slot = "10")]
	IGOPHNBFNOE CAKLCJCAALL(int BLGIMANEJMP);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x772F116802A438A", Offset = "0x0", VA = "0x772F118002A438A", Slot = "12")]
	void DMEENEIONCA();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2A439D802A438A", Offset = "0x0", VA = "0x2A439F002A438A", Slot = "13")]
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
