using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NILNDPCCLIB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2C3DFE87AEB99C", Offset = "0x0", VA = "0x2C3E0007AEB99C", Slot = "0")]
	void NDPGLCAACEE(object ICGADBEDOKK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7AEB99A802C3E2C", Offset = "0x0", VA = "0x7AEB99C002C3E2C", Slot = "1")]
	void MLELIFDMLCO(object ICGADBEDOKK);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2C3E75802C3E30", Offset = "0x0", VA = "0x2C3E77002C3E30", Slot = "2")]
	void BNCJEJEKKDP(object ICGADBEDOKK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2C3E7E87AEBB18", Offset = "0x0", VA = "0x2C3E8007AEBB18", Slot = "3")]
	void IAPOFPMPPKD(object MAFDHEKFLMG, string CBMJIKPEMCL, params object[] FKNKEJLLBEP);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7AEB99A802C3EAC", Offset = "0x0", VA = "0x7AEB99C002C3EAC", Slot = "4")]
	void CEGKELFPDAM(Exception KODHGAIEAOC);
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
