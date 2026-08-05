using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LOMEDCEMODJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA13B5868027E8B2", Offset = "0x0", VA = "0xA13B5880027E8B2", Slot = "0")]
	void JGIDGFOLONK(string CGEOMIEDEJO, string FNICFLBPPJM, bool HGGCADKNAIK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x27E9508027E8C0", Offset = "0x0", VA = "0x27E9520027E8C0", Slot = "1")]
	void LBJHEIAPECP();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x27E95E8A13B588", Offset = "0x0", VA = "0x27E9600A13B588", Slot = "2")]
	void NINDNKHBBIM();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA13A8BE8027E9F0", Offset = "0x0", VA = "0xA13A8C00027E9F0", Slot = "3")]
	void OGJIPIIHEPE();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x27EA8E8027E9F0", Offset = "0x0", VA = "0x27EA900027E9F0", Slot = "4")]
	void INCKEFBENII(string DEHMFLPGGBN, [Optional] string IOFLOHGLLDL);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ACHEPBEPPLK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CLGJEDBGKNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x27EA8E8A13A890", Offset = "0x0", VA = "0x27EA900A13A890", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AJHBAHIOEGF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool KOCFCILJIAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA13996E8027EB19", Offset = "0x0", VA = "0xA1399700027EB19", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<MBFJHNOBBIP> LDKPPADABMI;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA13996E8027EC49", Offset = "0x0", VA = "0xA1399700027EC49", Slot = "3")]
	Task HMCGAKKBHMB();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x27ECE28027EC50", Offset = "0x0", VA = "0x27ECE40027EC50", Slot = "4")]
	void MJPMKPPBJPO();
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
