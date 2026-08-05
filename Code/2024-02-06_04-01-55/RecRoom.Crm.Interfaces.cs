using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HBCEGLKCICL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2453208024531C", Offset = "0x0", VA = "0x2453220024531C", Slot = "0")]
	void AIIGGBOFCAH(string DLIGBKIJHFE, string BDCKOGPFJKK, bool KJMPAADMBPD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x245320896BE0D8", Offset = "0x0", VA = "0x245322096BE0D8", Slot = "1")]
	void OMDEKCNIFKN();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x96BE0C680245373", Offset = "0x0", VA = "0x96BE0C800245373", Slot = "2")]
	void FFFGOEFMCNG();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2453A380245380", Offset = "0x0", VA = "0x2453A500245380", Slot = "3")]
	void MPIKPAENMPB();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2453A3895D5E7C", Offset = "0x0", VA = "0x2453A5095D5E7C", Slot = "4")]
	void OMEDCJANCOC(string GJFLGBMDDAH, [Optional] string KMGEIHFEAGE);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AANLAINKEMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EFOKCEHNJOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x96BC2EA8024544E", Offset = "0x0", VA = "0x96BC2EC0024544E", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MDPCPMPIOPP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool BAJLECGFENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x24549D8024544E", Offset = "0x0", VA = "0x24549F0024544E", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<HFAAALNJDJI> NFNGIACPBLG;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2454F4802454A5", Offset = "0x0", VA = "0x2454F6002454A5", Slot = "3")]
	Task OBMDJKKOMOC();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2454FE896BC308", Offset = "0x0", VA = "0x245500096BC308", Slot = "4")]
	void CJNCIGMNEAB();
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
