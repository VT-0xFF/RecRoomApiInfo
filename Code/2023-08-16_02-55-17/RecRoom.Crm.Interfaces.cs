using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MDOGMDNANFL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x24CC5388A3E680", Offset = "0x0", VA = "0x24CC5508A3E680", Slot = "0")]
	void DHNKIDHPHBH(string FMECAHPOMJC, string PCMAOEAEPAJ, bool HOCMEAFAPFA);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8A3E69E8024CC9E", Offset = "0x0", VA = "0x8A3E6A00024CC9E", Slot = "1")]
	void NCILMKKCPLN();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x24CCA28024CC9E", Offset = "0x0", VA = "0x24CCA40024CC9E", Slot = "2")]
	void AHNGAIKPACE();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x24CCA288A3E6B0", Offset = "0x0", VA = "0x24CCA408A3E6B0", Slot = "3")]
	void AKPENFDGHBF();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8A3E69E8024CCED", Offset = "0x0", VA = "0x8A3E6A00024CCED", Slot = "4")]
	void OHCGHMLPDCJ(string OFEEHFFCCPI, [Optional] string OEJCGKKILAC);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NFAFLJHOGNF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ABIBAONKJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x24CD158024CCF0", Offset = "0x0", VA = "0x24CD170024CCF0", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x24CD15889B12F8", Offset = "0x0", VA = "0x24CD17089B12F8", Slot = "1")]
	Task NOMMDPMHJAB();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8A3E85A8024CDC8", Offset = "0x0", VA = "0x8A3E85C0024CDC8", Slot = "2")]
	void FNKHNDBLOJL();
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
