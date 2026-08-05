using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface ACAJIDHPJGL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA96B76280299B16", Offset = "0x0", VA = "0xA96B76400299B16", Slot = "0")]
	void CONLPGFGJGK(string OEHBAJJHPGL, string PKOHAJHFAAN, bool BPJFIFFHAAN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x299B1A80299B16", Offset = "0x0", VA = "0x299B1C00299B16", Slot = "1")]
	void ECCHDIJAJLP();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x299B1A8A96B774", Offset = "0x0", VA = "0x299B1C0A96B774", Slot = "2")]
	void JLPKENGHOON();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA96B76280299B6D", Offset = "0x0", VA = "0xA96B76400299B6D", Slot = "3")]
	void EBJFIGCAIDE();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x299B9380299B70", Offset = "0x0", VA = "0x299B9500299B70", Slot = "4")]
	void OEKBBNFNNNK(string KBAALDIICEH, [Optional] string FABFEMDJCLM);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IDMDPIEBLHL
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface HLLMDEEIOJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DNPKIALDANG PAKPEBCBNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x299B938A908A70", Offset = "0x0", VA = "0x299B950A908A70", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FCJBGKIIOHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA96D5E680299C4A", Offset = "0x0", VA = "0xA96D5E800299C4A", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<BGLEMMFICPM> GJEOBHDBENO;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA96D61280299CA1", Offset = "0x0", VA = "0xA96D61400299CA1", Slot = "4")]
	Task NOCOEJHJFAP();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x299CF080299CA1", Offset = "0x0", VA = "0x299CF200299CA1", Slot = "5")]
	void PGGELGPJGKM();
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
