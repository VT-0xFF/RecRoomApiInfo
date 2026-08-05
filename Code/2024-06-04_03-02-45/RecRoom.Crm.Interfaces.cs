using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NKCFPKCGFHK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x276874802767C5", Offset = "0x0", VA = "0x276876002767C5", Slot = "0")]
	void JBMHGGCCJHE(string IAHGNHCBIEK, string JMDEBMGPKNH, bool HNCJLFMFCEP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2768748A2C7604", Offset = "0x0", VA = "0x2768760A2C7604", Slot = "1")]
	void MDCOEFMADFM();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA2C761E802768C7", Offset = "0x0", VA = "0xA2C7620002768C7", Slot = "2")]
	void OICGEMBCPNO();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2768CB802768C7", Offset = "0x0", VA = "0x2768CD002768C7", Slot = "3")]
	void ELKPMELGBOO();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2768CB8A2C7630", Offset = "0x0", VA = "0x2768CD0A2C7630", Slot = "4")]
	void HMPJABNIPCH(string MPDFLFFJIHG, [Optional] string MCNHDBEBENI);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BMCCKCANODM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NELNLMNHJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA2C761E8027691E", Offset = "0x0", VA = "0xA2C76200027691E", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface HHAJHDMIDEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool JGKBHINJFGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x27694280276920", Offset = "0x0", VA = "0x27694400276920", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<NMKBBLLNCJN> JFLKKPJHJHF;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x276A3A802769EB", Offset = "0x0", VA = "0x276A3C002769EB", Slot = "3")]
	Task DIHNAABPOCM();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x276A3A8A2C7C00", Offset = "0x0", VA = "0x276A3C0A2C7C00", Slot = "4")]
	void NJEEDNGOJJI();
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
