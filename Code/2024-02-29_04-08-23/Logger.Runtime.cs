using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FHEHABMALFA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x24268680242637", Offset = "0x0", VA = "0x24268800242637", Slot = "0")]
	void FDPKAFHEJCK(object PGKJJCPHNLC);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2426868975BAAC", Offset = "0x0", VA = "0x2426880975BAAC", Slot = "1")]
	void OOKEEADPEON(object PGKJJCPHNLC);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x975BABA8024268E", Offset = "0x0", VA = "0x975BABC0024268E", Slot = "2")]
	void BHDCDOHIMIM(object PGKJJCPHNLC);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2426DD8024268E", Offset = "0x0", VA = "0x2426DF0024268E", Slot = "3")]
	void KBJJMCGEMCK(object HOLFPPNPJAH, string GDBGIPNHFLM, params object[] BBFBHKMAMKC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2426DE8975BAAC", Offset = "0x0", VA = "0x2426E00975BAAC", Slot = "4")]
	void BDGNLCPMAPJ(Exception ICJFBBEMBMF);
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
