using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KCGMHNBBENK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2D895787E0A3B0", Offset = "0x0", VA = "0x2D895907E0A3B0", Slot = "0")]
	void CDNPLAGEDBK(object MGFJDFPNJKC);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7E0A3CE802D89A2", Offset = "0x0", VA = "0x7E0A3D0002D89A2", Slot = "1")]
	void LPMJOAMLGIC(object MGFJDFPNJKC);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2D89A6802D89A2", Offset = "0x0", VA = "0x2D89A8002D89A2", Slot = "2")]
	void BHHKNBHOOKM(object MGFJDFPNJKC);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2D89A687E0A3E0", Offset = "0x0", VA = "0x2D89A807E0A3E0", Slot = "3")]
	void GIHDCNJFFHM(object CDBJCAAPIOD, string FHPFCIHDMMN, params object[] OBPCMKOMOOP);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7E0A3CE802D89F1", Offset = "0x0", VA = "0x7E0A3D0002D89F1", Slot = "4")]
	void KAFGOKGLHJJ(Exception OBEBIDPMGCE);
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
