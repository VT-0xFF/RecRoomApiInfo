using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::NHMFNAJFNAL(typeof(ContainerFlagsData))]
public static class GFOPDDCJCIH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6278AE0", Offset = "0x6277AE0", VA = "0x186278AE0")]
	[global::OOFLONIOLDG(1)]
	public static void LNABDNPIBPL([global::LCLPOMFIIFP(1)] JIDDLIBAHMP KAHOHEDCJHB, [Out][global::LCLPOMFIIFP(1)] JIDDLIBAHMP PBNAEIHBPEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::NHMFNAJFNAL(typeof(ObjectPolicyData))]
public static class CJLNKJCMIKA
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6278AC0", Offset = "0x6277AC0", VA = "0x186278AC0")]
	[global::OOFLONIOLDG(2)]
	public static void NCDJDDAHBFG([global::LCLPOMFIIFP(3)] bool ACOPMLFFHLC, [Out][global::LCLPOMFIIFP(3)] GMGCKILLHIB ODGEOOFAOHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::NHMFNAJFNAL(typeof(PersistentUserTagData))]
public static class DMLCGHDHKNC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6278AD0", Offset = "0x6277AD0", VA = "0x186278AD0")]
	[global::OOFLONIOLDG(1)]
	public static void DPMIALCBHGL([global::LCLPOMFIIFP(1)] FixedList32Bytes<int> GDLGHCFALIO, [Out][global::LCLPOMFIIFP(2)] bool EBOGHIFPHMC)
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
