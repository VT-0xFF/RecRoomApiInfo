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
		[Cpp2IlInjected.Address(RVA = "0x29E2AE8029E240", Offset = "0x0", VA = "0x29E2B00029E240", Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ProgressionEventRecordDTO ALICBEGBLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29E2AE873267A4", Offset = "0x0", VA = "0x29E2B0073267A4", Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DNGEPBCHOHN MGLIPLAKKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x73219328029E30F", Offset = "0x0", VA = "0x73219340029E30F", Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int BEIIJNGOJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x29E39C8029E310", Offset = "0x0", VA = "0x29E39E0029E310", Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool OFEMEAILHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x29E49B87322B14", Offset = "0x0", VA = "0x29E49D07322B14", Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action LPOKHPHDGCG;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action HHNOKABDKKI;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x29E39E87320BFC", Offset = "0x0", VA = "0x29E3A007320BFC", Slot = "8")]
	global::DGCAEBAFOOK<bool> IOJLLGFGJNN();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x731B61A8029E3F8", Offset = "0x0", VA = "0x731B61C0029E3F8", Slot = "9")]
	NPIGAOPELEF GDABPBLHHDI();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x29E49B8029E490", Offset = "0x0", VA = "0x29E49D0029E490", Slot = "10")]
	NPIGAOPELEF LKPBDNCCIHJ(int LBDHKABJEEL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7456DAE8029E4E1", Offset = "0x0", VA = "0x7456DB00029E4E1", Slot = "12")]
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
