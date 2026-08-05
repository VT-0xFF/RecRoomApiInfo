using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface AECBPDJKBBO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LNNGIFMHNDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x29AAD38A908A70", Offset = "0x0", VA = "0x29AAD50A908A70", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	BDDIJCFMLKF FFJDOMBIEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA96CE268029AB86", Offset = "0x0", VA = "0xA96CE280029AB86", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	BDDIJCFMLKF MBHIOLNKFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x29ABD58029AB86", Offset = "0x0", VA = "0x29ABD70029AB86", Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	List<string> LDHKDFDFMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x29ABD58A96CE44", Offset = "0x0", VA = "0x29ABD70A96CE44", Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA96CE528029ABDD", Offset = "0x0", VA = "0xA96CE540029ABDD", Slot = "4")]
	void FKDKCMIMMHH(List<(string, NLICMHACDLN)> EOKNHIOOHMP);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x29AC2C8029ABDD", Offset = "0x0", VA = "0x29AC2E0029ABDD", Slot = "5")]
	string[] NHEKNDBPMEG(string HEDPJBEBPNJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x29AC2E8A96CE44", Offset = "0x0", VA = "0x29AC300A96CE44", Slot = "6")]
	bool MEOGLPCDOGF(string HEDPJBEBPNJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xA75F7AE8029AC55", Offset = "0x0", VA = "0xA75F7B00029AC55", Slot = "7")]
	string IDOHMOFKKAH(string HEDPJBEBPNJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x29ACFE8029AC55", Offset = "0x0", VA = "0x29AD000029AC55", Slot = "8")]
	NLICMHACDLN OHMOCCHMGJB(string HEDPJBEBPNJ);
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
