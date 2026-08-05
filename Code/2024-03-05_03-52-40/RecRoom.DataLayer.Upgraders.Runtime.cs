using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::HPEAIBANPIA(typeof(ContainerFlagsData))]
public static class ADEAKNMNCGH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60A8D90", Offset = "0x60A7B90", VA = "0x1860A8D90")]
	[global::DGDNMKONBMN(1)]
	public static void JFAEFFIMPLA([global::HMLPPHANHBI(1)] PNFLHPNKBIO PKOLAGONCPB, [Out][global::HMLPPHANHBI(1)] PNFLHPNKBIO BHLNEKOPJMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::HPEAIBANPIA(typeof(ObjectPolicyData))]
public static class IMBAFLHCNKA
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60A8DB0", Offset = "0x60A7BB0", VA = "0x1860A8DB0")]
	[global::DGDNMKONBMN(2)]
	public static void PNKMCKJPNDK([global::HMLPPHANHBI(3)] bool PKFGJLBGJBP, [Out][global::HMLPPHANHBI(3)] PGDCJKHFMEC MDPMDKOAJOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::HPEAIBANPIA(typeof(PersistentUserTagData))]
public static class AGBDDDHNBGC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60A8DA0", Offset = "0x60A7BA0", VA = "0x1860A8DA0")]
	[global::DGDNMKONBMN(1)]
	public static void ONEBJLPLCEG([global::HMLPPHANHBI(1)] FixedList32Bytes<int> OOECMMNMHLG, [Out][global::HMLPPHANHBI(2)] bool CPMBLFCJCDI)
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
