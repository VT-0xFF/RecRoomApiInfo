using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface OFCIOGNNICH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x231ACA80231A7B", Offset = "0x0", VA = "0x231ACC00231A7B", Slot = "0")]
	void IGFAMDIDFLN(string IKALEKKPFLN, string PDMLBIFIFLB, bool CIKKAHGLAPI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x231ACE892FABF4", Offset = "0x0", VA = "0x231AD0092FABF4", Slot = "1")]
	void KIIAELFNKAO();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9164DB280231AF5", Offset = "0x0", VA = "0x9164DB400231AF5", Slot = "2")]
	void IBBJHPFPCDN();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x231B9280231AF5", Offset = "0x0", VA = "0x231B9400231AF5", Slot = "3")]
	void PCMFCEONBDE();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x231B92892FA418", Offset = "0x0", VA = "0x231B94092FA418", Slot = "4")]
	void KNGLDOKAPEN(string PKHFLMMJJIG, [Optional] string FJBAGNPGJPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CKHMFGAMFCM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PJOMEBHBHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x92FA43280231BE5", Offset = "0x0", VA = "0x92FA43400231BE5", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CCEIJCFFABO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FCKNHNLNOIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x231BE980231BE5", Offset = "0x0", VA = "0x231BEB00231BE5", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<GDJBCMMFHEN> LBEGCAJCMCH;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x231C6380231C40", Offset = "0x0", VA = "0x231C6500231C40", Slot = "3")]
	Task EMCBFDNIFOC();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x231C6389218A94", Offset = "0x0", VA = "0x231C6509218A94", Slot = "4")]
	void OFPJBAGGFGF();
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
