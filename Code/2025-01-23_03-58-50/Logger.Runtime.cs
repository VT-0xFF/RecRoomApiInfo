using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HPEADDKCNII
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xAA7BC6E802A67C5", Offset = "0x0", VA = "0xAA7BC70002A67C5", Slot = "0")]
	void CLLGOIEIHDM(object AGHKKLOENAF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2A686E802A67C5", Offset = "0x0", VA = "0x2A6870002A67C5", Slot = "1")]
	void ALHGGMIJEPK(object AGHKKLOENAF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2A686E8AC8CEFC", Offset = "0x0", VA = "0x2A68700AC8CEFC", Slot = "2")]
	void AHAGIJADCMI(object AGHKKLOENAF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xAC8CF16802A68C1", Offset = "0x0", VA = "0xAC8CF18002A68C1", Slot = "3")]
	void DPOOILELPGG(object IKGPEBFFMPK, string AENEDEDOEJK, params object[] GIOJKAECAOO);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A68C5802A68C1", Offset = "0x0", VA = "0x2A68C7002A68C1", Slot = "4")]
	void NMMMCHBBKEJ(Exception IACMJDBHAFH);
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
