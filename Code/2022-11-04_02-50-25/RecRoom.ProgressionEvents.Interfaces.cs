using System;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EALFGGNOILB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ProgressionEventDTO BFCKNFKCFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x750685E802A4F8D", Offset = "0x0", VA = "0x7506860002A4F8D", Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ProgressionEventRecordDTO KEIDMIDHLNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FF7802A4FB0", Offset = "0x0", VA = "0x2A4FF9002A4FB0", Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	HKIFIIMMEPK DFFODKAKHFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2A4FFE87507934", Offset = "0x0", VA = "0x2A500007507934", Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int NEBLBKKGMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7507932802A5049", Offset = "0x0", VA = "0x7507934002A5049", Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool GHFCCBJHGPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2A518A802A5110", Offset = "0x0", VA = "0x2A518C002A5110", Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action CCFLODLELLN;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action DFJFLOJDOKH;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2A509C802A5050", Offset = "0x0", VA = "0x2A509E002A5050", Slot = "8")]
	global::BHPNOFOGFAO<bool> KIDFJDNHEGG();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2A509E87506ED4", Offset = "0x0", VA = "0x2A50A007506ED4", Slot = "9")]
	EEBBFEJKFOP BJIBKFHGLPB();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7506ED2802A50EE", Offset = "0x0", VA = "0x7506ED4002A50EE", Slot = "10")]
	EEBBFEJKFOP DGMNCMCINOH(int KPGLGLNLGHN);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2A518E87508C00", Offset = "0x0", VA = "0x2A519007508C00", Slot = "12")]
	void CGFNGKJEPDC();
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
