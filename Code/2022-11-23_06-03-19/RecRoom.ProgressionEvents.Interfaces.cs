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
		[Cpp2IlInjected.Address(RVA = "0x28778E873AD168", Offset = "0x0", VA = "0x287790073AD168", Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ProgressionEventRecordDTO OECIBGMAOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x73AD166802877CE", Offset = "0x0", VA = "0x73AD168002877CE", Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	CLADDBHCOHB HDALJGOHCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2877FA802877D0", Offset = "0x0", VA = "0x2877FC002877D0", Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int ICKNDILAJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2877FE873AD168", Offset = "0x0", VA = "0x287800073AD168", Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool DIOCEIBEEPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x73AD166802878BB", Offset = "0x0", VA = "0x73AD168002878BB", Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PHHAEFBEDKL;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action NBKFOAOAHPC;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x73AD1668028783E", Offset = "0x0", VA = "0x73AD1680028783E", Slot = "8")]
	global::CGDFFALNLAC<bool> GOOHGHKAHMC();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x28786A80287840", Offset = "0x0", VA = "0x28786C00287840", Slot = "9")]
	FKDPJJAEIFK GPEKBHCJHKN();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x28786E873AD168", Offset = "0x0", VA = "0x287870073AD168", Slot = "10")]
	FKDPJJAEIFK ACNBCFMMHCE(int DLLGCDNMAPP);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2878FC802878C0", Offset = "0x0", VA = "0x2878FE002878C0", Slot = "12")]
	void HNNCHLJOMFL();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2878FE873AD168", Offset = "0x0", VA = "0x287900073AD168", Slot = "13")]
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
