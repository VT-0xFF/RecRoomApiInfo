using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EEBFEKBNEGF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9327A22802332AF", Offset = "0x0", VA = "0x9327A24002332AF", Slot = "0")]
	void FPKCBBOJANI(object BLHBFCHIDPL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2332B3802332AF", Offset = "0x0", VA = "0x2332B5002332AF", Slot = "1")]
	void KCBIFEFDHPK(object BLHBFCHIDPL);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2332B389327A34", Offset = "0x0", VA = "0x2332B509327A34", Slot = "2")]
	void GJOFFIOBNOA(object BLHBFCHIDPL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x9327A2280233306", Offset = "0x0", VA = "0x9327A2400233306", Slot = "3")]
	void CCNABMGIMBD(object LAACBMJOJOJ, string GIAELHONAOK, params object[] IFILEFKNBLN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x23333380233310", Offset = "0x0", VA = "0x23333500233310", Slot = "4")]
	void BHHNAGAKLKD(Exception LGFOLODPIEE);
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
