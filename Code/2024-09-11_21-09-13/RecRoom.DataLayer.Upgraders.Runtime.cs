using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::EAEGFDIFCDA(typeof(ContainerFlagsData))]
public static class GILCJCFNJEO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6B33160", Offset = "0x6B31760", VA = "0x186B33160")]
	[global::MFHBEFNCLCE(1)]
	public static void JOCCOAIAICG([global::MHJDIPDINOC(1)] FCJLNBDJJLP BPODGOAFELB, [Out][global::MHJDIPDINOC(1)] FCJLNBDJJLP HFIKGALOBPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::EAEGFDIFCDA(typeof(ObjectPolicyData))]
public static class FAKCAABOMIH
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6B33150", Offset = "0x6B31750", VA = "0x186B33150")]
	[global::MFHBEFNCLCE(2)]
	public static void KINJJLKAKBE([global::MHJDIPDINOC(3)] bool MHDAOLPMHIC, [Out][global::MHJDIPDINOC(3)] CMBLEAIFMMK OGECPHANGNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::EAEGFDIFCDA(typeof(PersistentUserTagData))]
public static class JFEJHBBPFIC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6B33170", Offset = "0x6B31770", VA = "0x186B33170")]
	[global::MFHBEFNCLCE(1)]
	public static void GEFICDINOHI([global::MHJDIPDINOC(1)] FixedList32Bytes<int> PKHLPDFNIKO, [Out][global::MHJDIPDINOC(2)] bool LHGAADHEBEC)
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
