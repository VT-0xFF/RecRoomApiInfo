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
		[Cpp2IlInjected.Address(RVA = "0x29F67B8029F5C7", Offset = "0x0", VA = "0x29F67D0029F5C7", Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ProgressionEventRecordDTO ALICBEGBLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29F67B8746D264", Offset = "0x0", VA = "0x29F67D0746D264", Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DNGEPBCHOHN MGLIPLAKKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x746D2828029F6C6", Offset = "0x0", VA = "0x746D2840029F6C6", Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int BEIIJNGOJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x29F6CA8029F6C6", Offset = "0x0", VA = "0x29F6CC0029F6C6", Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool OFEMEAILHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x29F747874699F0", Offset = "0x0", VA = "0x29F749074699F0", Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action LPOKHPHDGCG;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action HHNOKABDKKI;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x29F6CA8746D294", Offset = "0x0", VA = "0x29F6CC0746D294", Slot = "8")]
	global::DGCAEBAFOOK<bool> IOJLLGFGJNN();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x746D2828029F715", Offset = "0x0", VA = "0x746D2840029F715", Slot = "9")]
	NPIGAOPELEF GDABPBLHHDI();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x29F7478029F720", Offset = "0x0", VA = "0x29F7490029F720", Slot = "10")]
	NPIGAOPELEF LKPBDNCCIHJ(int LBDHKABJEEL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x746C4D68029F80A", Offset = "0x0", VA = "0x746C4D80029F80A", Slot = "12")]
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
