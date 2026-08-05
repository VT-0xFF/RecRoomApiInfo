using System;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EMAEHBHJIKL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ProgressionEventDTO AEJNABIFDLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29CDBE87319C50", Offset = "0x0", VA = "0x29CDC007319C50", Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ProgressionEventRecordDTO ALICBEGBLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x731AD228029CE51", Offset = "0x0", VA = "0x731AD240029CE51", Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DNGEPBCHOHN MGLIPLAKKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x29CEBC8029CE60", Offset = "0x0", VA = "0x29CEBE0029CE60", Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int BEIIJNGOJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x29CEBE87319C58", Offset = "0x0", VA = "0x29CEC007319C58", Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool OFEMEAILHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7319C568029CFDE", Offset = "0x0", VA = "0x7319C580029CFDE", Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action LPOKHPHDGCG;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action HHNOKABDKKI;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7319C4E8029CEDB", Offset = "0x0", VA = "0x7319C500029CEDB", Slot = "8")]
	global::DGCAEBAFOOK<bool> IOJLLGFGJNN();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x29CF6F8029CEE0", Offset = "0x0", VA = "0x29CF710029CEE0", Slot = "9")]
	NPIGAOPELEF GDABPBLHHDI();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x29CF7E8731AD24", Offset = "0x0", VA = "0x29CF800731AD24", Slot = "10")]
	NPIGAOPELEF LKPBDNCCIHJ(int LBDHKABJEEL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x29CFF98029CFE0", Offset = "0x0", VA = "0x29CFFB0029CFE0", Slot = "12")]
	void AAPBOIHCEIL();
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
