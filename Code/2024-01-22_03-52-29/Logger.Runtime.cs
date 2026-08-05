using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface ELGANHKEGLI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x95EDC528023B6DC", Offset = "0x0", VA = "0x95EDC540023B6DC", Slot = "0")]
	void AOEJNDMBIGP(object ADLBEINOKAL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x23B72B8023B6DC", Offset = "0x0", VA = "0x23B72D0023B6DC", Slot = "1")]
	void NOFAGJEHPGO(object ADLBEINOKAL);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x23B72B895EDC70", Offset = "0x0", VA = "0x23B72D095EDC70", Slot = "2")]
	void NMHDBGAJMFP(object ADLBEINOKAL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x95EDC7E8023B733", Offset = "0x0", VA = "0x95EDC800023B733", Slot = "3")]
	void FEEGLABPMOA(object AOGDICEMNLI, string NBMOIMOKFPB, params object[] CNLJFDAGKBD);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x23B7828023B733", Offset = "0x0", VA = "0x23B7840023B733", Slot = "4")]
	void OOKGAPGGCNG(Exception FHJPKMDNCBE);
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
