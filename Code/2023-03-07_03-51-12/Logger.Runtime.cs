using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BKDBAAFNNFG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7B45186802BC9EF", Offset = "0x0", VA = "0x7B45188002BC9EF", Slot = "0")]
	void EPMJEFBIMPO(object CDECIAPNKBP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2BCA35802BC9F0", Offset = "0x0", VA = "0x2BCA37002BC9F0", Slot = "1")]
	void BFDNDPFIEAA(object CDECIAPNKBP);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2BCA3E87B45188", Offset = "0x0", VA = "0x2BCA4007B45188", Slot = "2")]
	void EOAHMHBMJCM(object CDECIAPNKBP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7B4517E802BCA8B", Offset = "0x0", VA = "0x7B45180002BCA8B", Slot = "3")]
	void JMECALDCKED(object OEGBAMNPENI, string MPGAKCEBEEJ, params object[] DMNIOKOCJFF);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2BCAD9802BCA90", Offset = "0x0", VA = "0x2BCADB002BCA90", Slot = "4")]
	void CFDANHLKFJJ(Exception ADPFAOFBEEE);
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
