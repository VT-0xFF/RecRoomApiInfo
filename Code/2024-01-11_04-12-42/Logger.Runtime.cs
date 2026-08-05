using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PBKNGMAHDIF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x23C5348023C4E5", Offset = "0x0", VA = "0x23C5360023C4E5", Slot = "0")]
	void CIBIHDAPBBB(object ACIECAMLMIJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x23C53E8958981C", Offset = "0x0", VA = "0x23C5400958981C", Slot = "1")]
	void DPFELOCOEJN(object ACIECAMLMIJ);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x948644E8023C565", Offset = "0x0", VA = "0x94864500023C565", Slot = "2")]
	void KBALLEFNGKH(object ACIECAMLMIJ);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x23C60C8023C565", Offset = "0x0", VA = "0x23C60E0023C565", Slot = "3")]
	void LEMEHKFLHIC(object AGHGCGMHDAO, string MPEIKHEGNLM, params object[] BFAMAJEDCBA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x23C60C89589C80", Offset = "0x0", VA = "0x23C60E09589C80", Slot = "4")]
	void MLKMFAKLMPL(Exception ALIBMJDCMCM);
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
