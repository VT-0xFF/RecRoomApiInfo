using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::APPKLGBEEKE(typeof(ContainerFlagsData))]
public static class EMIAFFICHLC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6DA3BF0", Offset = "0x6DA2FF0", VA = "0x186DA3BF0")]
	[global::DPFJNHLDBDN(1)]
	public static void BFCKLIFIAGK([global::DBJGIMIHLPB(1)] KLDPKACKFII EIDKPDKGDIO, [Out][global::DBJGIMIHLPB(1)] KLDPKACKFII NHHDKPPMENI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::APPKLGBEEKE(typeof(ObjectPolicyData))]
public static class BJLHGENKIGH
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6DA3BE0", Offset = "0x6DA2FE0", VA = "0x186DA3BE0")]
	[global::DPFJNHLDBDN(2)]
	public static void BDKFLCHBOPF([global::DBJGIMIHLPB(3)] bool HBHNOBFMBCP, [Out][global::DBJGIMIHLPB(3)] AIHHMFAMMMA MLLKMCGEGGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::APPKLGBEEKE(typeof(PersistentUserTagData))]
public static class PJGKNHEIEMB
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6DA3C00", Offset = "0x6DA3000", VA = "0x186DA3C00")]
	[global::DPFJNHLDBDN(1)]
	public static void OMIEHPBNNDH([global::DBJGIMIHLPB(1)] FixedList32Bytes<int> DDHIEPBKNHM, [Out][global::DBJGIMIHLPB(2)] bool EJLPOJGNIHB)
	{
	}
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
