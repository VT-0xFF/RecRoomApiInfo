using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JIENPLKFJBP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2D96B987F2D54C", Offset = "0x0", VA = "0x2D96BB07F2D54C", Slot = "0")]
	void PDCBBEBIIOA(object AOHKNGHOEPF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D56A802D9704", Offset = "0x0", VA = "0x7F2D56C002D9704", Slot = "1")]
	void PMOIFGGGNGF(object AOHKNGHOEPF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2D9708802D9704", Offset = "0x0", VA = "0x2D970A002D9704", Slot = "2")]
	void EEKLFDKHGFH(object AOHKNGHOEPF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2D970887F2D57C", Offset = "0x0", VA = "0x2D970A07F2D57C", Slot = "3")]
	void LCHKKKLFINM(object MFEOJPNCOBA, string GNDANPNHEDO, params object[] KCPODLJODHA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D56A802D9753", Offset = "0x0", VA = "0x7F2D56C002D9753", Slot = "4")]
	void LFFICHODOBD(Exception MGMBAAEPBGK);
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
