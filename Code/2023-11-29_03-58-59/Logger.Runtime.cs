using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EEBFEKBNEGF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x232FC280232FA0", Offset = "0x0", VA = "0x232FC400232FA0", Slot = "0")]
	void FPKCBBOJANI(object BLHBFCHIDPL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x232FC28914149C", Offset = "0x0", VA = "0x232FC40914149C", Slot = "1")]
	void KCBIFEFDHPK(object BLHBFCHIDPL);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x93287DA80233059", Offset = "0x0", VA = "0x93287DC00233059", Slot = "2")]
	void GJOFFIOBNOA(object BLHBFCHIDPL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2330A880233059", Offset = "0x0", VA = "0x2330AA00233059", Slot = "3")]
	void CCNABMGIMBD(object LAACBMJOJOJ, string GIAELHONAOK, params object[] IFILEFKNBLN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2330A8893287F8", Offset = "0x0", VA = "0x2330AA093287F8", Slot = "4")]
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
