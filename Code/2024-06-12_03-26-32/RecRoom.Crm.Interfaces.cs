using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JPDAGJGCBHO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2790E3802790C0", Offset = "0x0", VA = "0x2790E5002790C0", Slot = "0")]
	void IDNFICBMICE(string LAPIFBEKHKL, string IHPHJBJBGEC, bool JLJJPHBFOIB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2790E38A182E04", Offset = "0x0", VA = "0x2790E50A182E04", Slot = "1")]
	void MKPAFKDELLP();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA39949E80279190", Offset = "0x0", VA = "0xA3994A000279190", Slot = "2")]
	void LHEKJGOCIFK();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2791DF80279190", Offset = "0x0", VA = "0x2791E100279190", Slot = "3")]
	void FLDHAOOAMME();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2791DF8A3994BC", Offset = "0x0", VA = "0x2791E10A3994BC", Slot = "4")]
	void NLHEFOBKDDH(string IPMENEKMMEJ, [Optional] string MGPMNEEKHBE);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CIKBFLKNEOL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GGMOFNDCKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA3994CA802791E7", Offset = "0x0", VA = "0xA3994CC002791E7", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OCPBDCCNDEI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool KEOPFOMHHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x279236802791E7", Offset = "0x0", VA = "0x279238002791E7", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<MDPBCKFDELG> HJPPBENFPJL;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x27932680279265", Offset = "0x0", VA = "0x27932800279265", Slot = "3")]
	Task EHHLDMLDHNI();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2793268A3999E0", Offset = "0x0", VA = "0x2793280A3999E0", Slot = "4")]
	void CJMFGDFICPO();
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
