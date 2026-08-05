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
	[Cpp2IlInjected.Address(RVA = "0x27D7648A32C3C0", Offset = "0x0", VA = "0x27D7660A32C3C0", Slot = "0")]
	void JGIDGFOLONK(string CGEOMIEDEJO, string FNICFLBPPJM, bool HGGCADKNAIK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA32C3DA8027D7B7", Offset = "0x0", VA = "0xA32C3DC0027D7B7", Slot = "1")]
	void LBJHEIAPECP();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x27D7BB8027D7B7", Offset = "0x0", VA = "0x27D7BD0027D7B7", Slot = "2")]
	void NINDNKHBBIM();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x27D7BB8A32C3EC", Offset = "0x0", VA = "0x27D7BD0A32C3EC", Slot = "3")]
	void OGJIPIIHEPE();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA32C3DA8027D80E", Offset = "0x0", VA = "0xA32C3DC0027D80E", Slot = "4")]
	void INCKEFBENII(string DEHMFLPGGBN, [Optional] string IOFLOHGLLDL);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ACHEPBEPPLK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CLGJEDBGKNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x27D8338027D810", Offset = "0x0", VA = "0x27D8350027D810", Slot = "0")]
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
		[Cpp2IlInjected.Address(RVA = "0x27D8338A2C9380", Offset = "0x0", VA = "0x27D8350A2C9380", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<MBFJHNOBBIP> LDKPPADABMI;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x27D9378A32C81C", Offset = "0x0", VA = "0x27D9390A32C81C", Slot = "3")]
	Task HMCGAKKBHMB();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA32C82A8027D93F", Offset = "0x0", VA = "0xA32C82C0027D93F", Slot = "4")]
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
