using System;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NIIHHPJFPBC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ProgressionEventDTO GCONNPLNLFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4BC802AC4A0", Offset = "0x0", VA = "0x2AC4BE002AC4A0", Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ProgressionEventRecordDTO FOOBMGNAEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2AC4BC876F1ABC", Offset = "0x0", VA = "0x2AC4BE076F1ABC", Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	JODOMLDKPMD PJFBNPMKBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x77CD9E2802AC54C", Offset = "0x0", VA = "0x77CD9E4002AC54C", Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int ELLJIFMEOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2AC550802AC54C", Offset = "0x0", VA = "0x2AC552002AC54C", Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool LOLDEADKCLA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2AC608877CDC08", Offset = "0x0", VA = "0x2AC60A077CDC08", Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action ICABFNMOKLJ;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action PFJFJCCHGKN;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2AC55E877CDA04", Offset = "0x0", VA = "0x2AC560077CDA04", Slot = "8")]
	global::MMBCCHGMCHN<bool> EFPLBFFAJFB();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x76F1ABA802AC57D", Offset = "0x0", VA = "0x76F1ABC002AC57D", Slot = "9")]
	CCBLCAIHLNA GFBDCONMNLC();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2AC608802AC57D", Offset = "0x0", VA = "0x2AC60A002AC57D", Slot = "10")]
	CCBLCAIHLNA HBLCPDAJHKE(int BONKENFLALB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x77CDC26802AC610", Offset = "0x0", VA = "0x77CDC28002AC610", Slot = "12")]
	void PBMJBMEKLBP();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2AC62B802AC610", Offset = "0x0", VA = "0x2AC62D002AC610", Slot = "13")]
	string MJLGNOOPIJM(NJHLDOHDODC IAPDAELLJME);
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
