using System;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PBCIJMALKDG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ProgressionEventDTO IPBFCMPJDIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2A315E875DC4F8", Offset = "0x0", VA = "0x2A3160075DC4F8", Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ProgressionEventRecordDTO FANLLKMOLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x75DC4F6802A31E6", Offset = "0x0", VA = "0x75DC4F8002A31E6", Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IFPCMIDKKKB BFKGAAJDKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2A3239802A31F0", Offset = "0x0", VA = "0x2A323B002A31F0", Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int ABMBEOENHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2A323E875DC37C", Offset = "0x0", VA = "0x2A3240075DC37C", Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MBJGDPGNDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x75DC37A802A331B", Offset = "0x0", VA = "0x75DC37C002A331B", Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action EFFCHMNBDHK;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action ALKLEDKMLBG;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x75DC4F6802A3287", Offset = "0x0", VA = "0x75DC4F8002A3287", Slot = "8")]
	global::GANDAICPPHN<bool> BOBKJECGOMO();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2A32CC802A3290", Offset = "0x0", VA = "0x2A32CE002A3290", Slot = "9")]
	CKHAEIDHOPE GJALKGHEBII();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2A32CE875DC37C", Offset = "0x0", VA = "0x2A32D0075DC37C", Slot = "10")]
	CKHAEIDHOPE ENPLNOKLBOE(int OAPJCAEJNKI);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2A33AD802A3320", Offset = "0x0", VA = "0x2A33AF002A3320", Slot = "12")]
	void HMLFIMJGGBE();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2A33AE875DC4F8", Offset = "0x0", VA = "0x2A33B0075DC4F8", Slot = "13")]
	string BHGHKGONMMJ(CMFDHIJCDJI ALCDNHIEBIE);
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
