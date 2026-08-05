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
	[Cpp2IlInjected.Address(RVA = "0x27DA378A32D99C", Offset = "0x0", VA = "0x27DA390A32D99C", Slot = "0")]
	void JGIDGFOLONK(string CGEOMIEDEJO, string FNICFLBPPJM, bool HGGCADKNAIK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA32D9AA8027DA3F", Offset = "0x0", VA = "0xA32D9AC0027DA3F", Slot = "1")]
	void LBJHEIAPECP();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x27DA8E8027DA3F", Offset = "0x0", VA = "0x27DA900027DA3F", Slot = "2")]
	void NINDNKHBBIM();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x27DA8E8A32D99C", Offset = "0x0", VA = "0x27DA900A32D99C", Slot = "3")]
	void OGJIPIIHEPE();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA119EE68027DAB5", Offset = "0x0", VA = "0xA119EE80027DAB5", Slot = "4")]
	void INCKEFBENII(string DEHMFLPGGBN, [Optional] string IOFLOHGLLDL);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ACHEPBEPPLK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CLGJEDBGKNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x27DB5C8027DAB5", Offset = "0x0", VA = "0x27DB5E0027DAB5", Slot = "0")]
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
		[Cpp2IlInjected.Address(RVA = "0x27DB5C8A32CD20", Offset = "0x0", VA = "0x27DB5E0A32CD20", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<MBFJHNOBBIP> LDKPPADABMI;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x27DBB38A32CD4C", Offset = "0x0", VA = "0x27DBB50A32CD4C", Slot = "3")]
	Task HMCGAKKBHMB();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA32CD3A8027DC06", Offset = "0x0", VA = "0xA32CD3C0027DC06", Slot = "4")]
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
