using System;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface AMFKPCNPDPO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ProgressionEventDTO NFFHKFNMNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2992FE872BDCD0", Offset = "0x0", VA = "0x299300072BDCD0", Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ProgressionEventRecordDTO PJMKANIHLCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x72BDCDA8029933E", Offset = "0x0", VA = "0x72BDCDC0029933E", Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	LNKDNKCDFMF JDEIPMPJCHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x29937C80299340", Offset = "0x0", VA = "0x29937E00299340", Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int BCPOMBMCPIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x29937E872BDCDC", Offset = "0x0", VA = "0x299380072BDCDC", Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool ICDNOOLFFKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72BDCDA8029946B", Offset = "0x0", VA = "0x72BDCDC0029946B", Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NAFANJGJGNL;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action FJEEPKKDNEC;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x72BDCDA802993BE", Offset = "0x0", VA = "0x72BDCDC002993BE", Slot = "8")]
	global::AGDEEHNAPKP<bool> KGCIALHGNIG();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x299410802993C0", Offset = "0x0", VA = "0x299412002993C0", Slot = "9")]
	MLEPGEJLFCO MJOGFHNBAAO();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x29941E872BDCDC", Offset = "0x0", VA = "0x299420072BDCDC", Slot = "10")]
	MLEPGEJLFCO CDGDMKKFPMF(int EKGMBLGLIII);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2994B980299470", Offset = "0x0", VA = "0x2994BB00299470", Slot = "12")]
	void AIKMCINGFHA();
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
