using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LGFKKIIEMLN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x90ABBB28022A7CD", Offset = "0x0", VA = "0x90ABBB40022A7CD", Slot = "0")]
	void FDNKKCNBOKJ(string FDAGAJKMFMK, string LGACMMDMCGN, bool APFIIIDDCHD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x22A7D18022A7CD", Offset = "0x0", VA = "0x22A7D30022A7CD", Slot = "1")]
	void FLMLEOOINDB();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x22A7D1890ABBC4", Offset = "0x0", VA = "0x22A7D3090ABBC4", Slot = "2")]
	void CEHKINDBDCI();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x90ABBB28022A824", Offset = "0x0", VA = "0x90ABBB40022A824", Slot = "3")]
	void JJAPJBPIMCG();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x22A8538022A830", Offset = "0x0", VA = "0x22A8550022A830", Slot = "4")]
	void CEMKOOKEHKO(string PBBBEOIALCM, [Optional] string CJGGIPDOIGM);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CHJLDGBKJAP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PAFAKFNBPDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x22A85388FC9F84", Offset = "0x0", VA = "0x22A85508FC9F84", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BKLGFLPNBOH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool POACMLNKFPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x90AD2B68022A8FE", Offset = "0x0", VA = "0x90AD2B80022A8FE", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<OLHLONJEKOJ> KBAKEEJEFCO;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x90AD2E28022A955", Offset = "0x0", VA = "0x90AD2E40022A955", Slot = "3")]
	Task FGBNJEBGKMH();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x22A9A48022A955", Offset = "0x0", VA = "0x22A9A60022A955", Slot = "4")]
	void OAFECOOGBFN();
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
