using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HLAOJMHANAK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2541E2802541C0", Offset = "0x0", VA = "0x2541E4002541C0", Slot = "0")]
	void HEFADAFEBPD(object LAGKGKDNMJM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2541E28997F8CC", Offset = "0x0", VA = "0x2541E40997F8CC", Slot = "1")]
	void MDCIKEHJDMB(object LAGKGKDNMJM);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9B7DFC680254279", Offset = "0x0", VA = "0x9B7DFC800254279", Slot = "2")]
	void GGAFDCAPOLI(object LAGKGKDNMJM);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2542C880254279", Offset = "0x0", VA = "0x2542CA00254279", Slot = "3")]
	void HKOEEFLJBGO(object DFKOHNJAKHM, string GCJDIJFGBBE, params object[] JMCMGAGCLNF);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2542C889B7DFE4", Offset = "0x0", VA = "0x2542CA09B7DFE4", Slot = "4")]
	void MOCGDBKOOAK(Exception IKEDLLBMBGJ);
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
