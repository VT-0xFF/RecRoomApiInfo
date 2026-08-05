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
		[Cpp2IlInjected.Address(RVA = "0x72BDCCE8029CF6E", Offset = "0x0", VA = "0x72BDCD00029CF6E", Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	ProgressionEventRecordDTO PJMKANIHLCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29CF7C8029CF70", Offset = "0x0", VA = "0x29CF7E0029CF70", Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	LNKDNKCDFMF JDEIPMPJCHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x29CF7E872BDCD0", Offset = "0x0", VA = "0x29CF80072BDCD0", Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int BCPOMBMCPIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72BDCCE8029CF8E", Offset = "0x0", VA = "0x72BDCD00029CF8E", Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool ICDNOOLFFKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x29CFBC8029CFB0", Offset = "0x0", VA = "0x29CFBE0029CFB0", Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NAFANJGJGNL;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action FJEEPKKDNEC;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x29CF9C8029CF90", Offset = "0x0", VA = "0x29CF9E0029CF90", Slot = "8")]
	global::AGDEEHNAPKP<bool> KGCIALHGNIG();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x29CF9E872BDCD0", Offset = "0x0", VA = "0x29CFA0072BDCD0", Slot = "9")]
	MLEPGEJLFCO MJOGFHNBAAO();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x72BDCCE8029CFAE", Offset = "0x0", VA = "0x72BDCD00029CFAE", Slot = "10")]
	MLEPGEJLFCO CDGDMKKFPMF(int EKGMBLGLIII);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x29CFBE872BDCD0", Offset = "0x0", VA = "0x29CFC0072BDCD0", Slot = "12")]
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
