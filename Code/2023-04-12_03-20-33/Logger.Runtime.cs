using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JIENPLKFJBP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2CF1DA802CF1D6", Offset = "0x0", VA = "0x2CF1DC002CF1D6", Slot = "0")]
	void PDCBBEBIIOA(object AOHKNGHOEPF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2CF1DA87FB13AC", Offset = "0x0", VA = "0x2CF1DC07FB13AC", Slot = "1")]
	void PMOIFGGGNGF(object AOHKNGHOEPF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7FB139A802CF225", Offset = "0x0", VA = "0x7FB139C002CF225", Slot = "2")]
	void EEKLFDKHGFH(object AOHKNGHOEPF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2CF255802CF230", Offset = "0x0", VA = "0x2CF257002CF230", Slot = "3")]
	void LCHKKKLFINM(object MFEOJPNCOBA, string GNDANPNHEDO, params object[] KCPODLJODHA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2CF25587F04094", Offset = "0x0", VA = "0x2CF25707F04094", Slot = "4")]
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
