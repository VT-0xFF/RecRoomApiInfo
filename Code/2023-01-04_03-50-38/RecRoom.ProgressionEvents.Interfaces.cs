using System;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MPMGMKFFKCK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ProgressionEventDTO PBHIAAIFHMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2A75CE875EC074", Offset = "0x0", VA = "0x2A75D0075EC074", Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ProgressionEventRecordDTO LLBAJMGBBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x75EAF9E802A75EB", Offset = "0x0", VA = "0x75EAFA0002A75EB", Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	PGHBCEDHIEO COLOLPABBNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2A767F802A75F0", Offset = "0x0", VA = "0x2A7681002A75F0", Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int MNOKOALHAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2A768E875EC074", Offset = "0x0", VA = "0x2A7690075EC074", Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool OBDCDBCPAHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x75EC072802A7791", Offset = "0x0", VA = "0x75EC074002A7791", Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NIOGBAJAKHP;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action LABONFFMHIP;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x75EAF9E802A76AB", Offset = "0x0", VA = "0x75EAFA0002A76AB", Slot = "8")]
	global::JENPMPFICOP<bool> JDENAIKECAK();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2A76FC802A76B0", Offset = "0x0", VA = "0x2A76FE002A76B0", Slot = "9")]
	JLFOFKFALKJ JJKKEINLJPP();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2A76FE875EAFA8", Offset = "0x0", VA = "0x2A7700075EAFA8", Slot = "10")]
	JLFOFKFALKJ JKMKFAJNAGI(int LGBLLHIECHI);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2A77FA802A77A0", Offset = "0x0", VA = "0x2A77FC002A77A0", Slot = "12")]
	void BPFEBLKIGMC();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2A77FE875EAFA8", Offset = "0x0", VA = "0x2A7800075EAFA8", Slot = "13")]
	string ONIKGIOBABL(KGCDPFLKCDB AMFKHBPHJML);
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
