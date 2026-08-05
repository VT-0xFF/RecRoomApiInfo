using System;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CCNDMEAJLEO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ProgressionEventDTO KCDCGBNOBFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x75D226E802AF68A", Offset = "0x0", VA = "0x75D2270002AF68A", Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ProgressionEventRecordDTO OECIBGMAOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2AF698802AF690", Offset = "0x0", VA = "0x2AF69A002AF690", Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	CLADDBHCOHB HDALJGOHCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2AF69E875D2270", Offset = "0x0", VA = "0x2AF6A0075D2270", Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int ICKNDILAJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x75D226E802AF6AA", Offset = "0x0", VA = "0x75D2270002AF6AA", Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool DIOCEIBEEPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6D8802AF6D0", Offset = "0x0", VA = "0x2AF6DA002AF6D0", Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PHHAEFBEDKL;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action NBKFOAOAHPC;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2AF6B8802AF6B0", Offset = "0x0", VA = "0x2AF6BA002AF6B0", Slot = "8")]
	global::CGDFFALNLAC<bool> GOOHGHKAHMC();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2AF6BE875D2270", Offset = "0x0", VA = "0x2AF6C0075D2270", Slot = "9")]
	FKDPJJAEIFK GPEKBHCJHKN();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x75D226E802AF6CA", Offset = "0x0", VA = "0x75D2270002AF6CA", Slot = "10")]
	FKDPJJAEIFK ACNBCFMMHCE(int DLLGCDNMAPP);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2AF6DE875D2270", Offset = "0x0", VA = "0x2AF6E0075D2270", Slot = "12")]
	void HNNCHLJOMFL();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x75D226E802AF6EA", Offset = "0x0", VA = "0x75D2270002AF6EA", Slot = "13")]
	string OBGHIHELDMF(DKBOECOKODI KKLELJOBBLF);
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
