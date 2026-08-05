using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::GLFMNCBODBH(typeof(ContainerFlagsData))]
public static class PELLBANBHGO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6D93710", Offset = "0x6D92B10", VA = "0x186D93710")]
	[global::NJBFNAMGCAO(1)]
	public static void AILPEJJJEBA([global::LEDNNADJOAI(1)] MHPNLKALAJE NMNJGJLCBIG, [Out][global::LEDNNADJOAI(1)] MHPNLKALAJE GOGFMJIHMAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::GLFMNCBODBH(typeof(ObjectPolicyData))]
public static class NNBKDMONBIN
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6D93700", Offset = "0x6D92B00", VA = "0x186D93700")]
	[global::NJBFNAMGCAO(2)]
	public static void JJHNFKPCCJJ([global::LEDNNADJOAI(3)] bool FCGACCFIOHG, [Out][global::LEDNNADJOAI(3)] IABBENFALKI MOPHLBHNAIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::GLFMNCBODBH(typeof(PersistentUserTagData))]
public static class BFNHOKOEKLD
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6D936F0", Offset = "0x6D92AF0", VA = "0x186D936F0")]
	[global::NJBFNAMGCAO(1)]
	public static void OOICKGOBGJN([global::LEDNNADJOAI(1)] FixedList32Bytes<int> HNGFBCNFFAA, [Out][global::LEDNNADJOAI(2)] bool KAAKCJDHIGG)
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
