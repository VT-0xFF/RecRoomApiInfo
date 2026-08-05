using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CIJBFKPLGIC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x22DE748022DE50", Offset = "0x0", VA = "0x22DE760022DE50", Slot = "0")]
	void OKGDKGFPGGP(string MFGDKICGEIO, string OOGPGKNONIC, bool KAHKAEIIHEH);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x22DE7E88EF8890", Offset = "0x0", VA = "0x22DE8008EF8890", Slot = "1")]
	void GNMCNKHINCM();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8EF9B4A8022DEB8", Offset = "0x0", VA = "0x8EF9B4C0022DEB8", Slot = "2")]
	void MKCNGLNFEIF();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x22DEE48022DEC0", Offset = "0x0", VA = "0x22DEE60022DEC0", Slot = "3")]
	void JMMOJNPMNFK();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x22DEFE88EF8890", Offset = "0x0", VA = "0x22DF0008EF8890", Slot = "4")]
	void ELHPJHIDMDI(string CNGNGPEJHIK, [Optional] string EPAEFPAPLMI);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LEONCCEGHCF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NGMCIMAJAPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8EF9EEA8022DF30", Offset = "0x0", VA = "0x8EF9EEC0022DF30", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EILGBEHJDIE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LPPMIHFOCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x22DF648022DF40", Offset = "0x0", VA = "0x22DF660022DF40", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<EJJFFIBEMNG> LNOOMADICEB;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x22DFCC8022DFA0", Offset = "0x0", VA = "0x22DFCE0022DFA0", Slot = "3")]
	Task OOCIGOIJKNJ();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x22DFCE88EF8890", Offset = "0x0", VA = "0x22DFD008EF8890", Slot = "4")]
	void AOMGIBAKPFH();
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
