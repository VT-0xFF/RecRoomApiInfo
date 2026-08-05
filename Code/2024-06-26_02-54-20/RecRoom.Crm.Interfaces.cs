using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FFNFOHDICEL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x27E3158027E2C6", Offset = "0x0", VA = "0x27E3170027E2C6", Slot = "0")]
	void EEDALNKFAIA(string GKHEGGGNFAP, string PFLHLCMECDI, bool EFIJCEPCPOA);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x27E3158A36C018", Offset = "0x0", VA = "0x27E3170A36C018", Slot = "1")]
	void JPELCBHMAPD();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA36C0268027E31D", Offset = "0x0", VA = "0xA36C0280027E31D", Slot = "2")]
	void FAKIPLHCIND();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x27E36C8027E31D", Offset = "0x0", VA = "0x27E36E0027E31D", Slot = "3")]
	void KNCPIBONNCD();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x27E36E8A36C018", Offset = "0x0", VA = "0x27E3700A36C018", Slot = "4")]
	void JEJLLDCGGGB(string OHPNDCFMKAD, [Optional] string MJHMKAJFEND);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CPGHKFMFPCM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PGEAPCOBJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA3452E68027E397", Offset = "0x0", VA = "0xA3452E80027E397", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OPGMAMJPMJO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool CMNKAOGIEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x27E4658027E397", Offset = "0x0", VA = "0x27E4670027E397", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<JKPGBCENFEM> CLPKFDNEBPO;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x27E4BC8027E4B8", Offset = "0x0", VA = "0x27E4BE0027E4B8", Slot = "3")]
	Task BGGINNGCCML();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x27E4BC8A36C828", Offset = "0x0", VA = "0x27E4BE0A36C828", Slot = "4")]
	void FDHFDDAAOOD();
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
