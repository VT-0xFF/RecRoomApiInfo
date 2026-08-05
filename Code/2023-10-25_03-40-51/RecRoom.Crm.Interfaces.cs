using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MDEIMLPOKAO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x90AD3668022D990", Offset = "0x0", VA = "0x90AD3680022D990", Slot = "0")]
	void FELBKPCPAPI(string DMBFFDLBLMA, string EPCIKNGLIBA, bool MADBEOCGDND);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x22D9DF8022D990", Offset = "0x0", VA = "0x22D9E10022D990", Slot = "1")]
	void MCFCKFGMDGJ();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x22D9EE890AD358", Offset = "0x0", VA = "0x22D9F0090AD358", Slot = "2")]
	void FMBOFMDKNNJ();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8F185DA8022DA15", Offset = "0x0", VA = "0x8F185DC0022DA15", Slot = "3")]
	void FMKMOFCLCGA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x22DABA8022DA15", Offset = "0x0", VA = "0x22DABC0022DA15", Slot = "4")]
	void JPKPDMLINGE(string MADDJAPMOOD, [Optional] string OHHCPBIFAEK);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BPMCJMAGEEL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JBLAMLCLIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x22DABA890AE31C", Offset = "0x0", VA = "0x22DABC090AE31C", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LIONPANEDMK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool KGOGNACNMMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x90AE3368022DB0D", Offset = "0x0", VA = "0x90AE3380022DB0D", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<KMFGGKFNDCB> KGFPFJKIICI;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x90AE3368022DB64", Offset = "0x0", VA = "0x90AE3380022DB64", Slot = "3")]
	Task HCKCHEHGBKI();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x22DB928022DB70", Offset = "0x0", VA = "0x22DB940022DB70", Slot = "4")]
	void LJDFGIJMKMD();
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
