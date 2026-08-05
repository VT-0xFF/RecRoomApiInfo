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
	[Cpp2IlInjected.Address(RVA = "0x28168480281660", Offset = "0x0", VA = "0x28168600281660", Slot = "0")]
	void EEDALNKFAIA(string GKHEGGGNFAP, string PFLHLCMECDI, bool EFIJCEPCPOA);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2816AE8A193584", Offset = "0x0", VA = "0x2816B00A193584", Slot = "1")]
	void JPELCBHMAPD();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA194BE6802816DE", Offset = "0x0", VA = "0xA194BE8002816DE", Slot = "2")]
	void FAKIPLHCIND();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x28171C802816E0", Offset = "0x0", VA = "0x28171E002816E0", Slot = "3")]
	void KNCPIBONNCD();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28171E8A19AFA0", Offset = "0x0", VA = "0x2817200A19AFA0", Slot = "4")]
	void JEJLLDCGGGB(string OHPNDCFMKAD, [Optional] string MJHMKAJFEND);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CPGHKFMFPCM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PGEAPCOBJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA19468280281784", Offset = "0x0", VA = "0xA19468400281784", Slot = "0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2817BE80281790", Offset = "0x0", VA = "0x2817C000281790", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<JKPGBCENFEM> CLPKFDNEBPO;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x28182C80281800", Offset = "0x0", VA = "0x28182E00281800", Slot = "3")]
	Task BGGINNGCCML();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x28182E8A194BE8", Offset = "0x0", VA = "0x2818300A194BE8", Slot = "4")]
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
