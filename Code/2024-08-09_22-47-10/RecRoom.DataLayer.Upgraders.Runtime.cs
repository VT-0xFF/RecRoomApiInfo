using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::DEMBNHCEGJO(typeof(ContainerFlagsData))]
public static class ALCGAAPNOAL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x68BD1A0", Offset = "0x68BC5A0", VA = "0x1868BD1A0")]
	[global::CDNJDCHNMEH(1)]
	public static void LEENHHEHJJD([global::AKOGMCGBMOC(1)] DAMGCJMCCIG ILPKFBFCIEC, [Out][global::AKOGMCGBMOC(1)] DAMGCJMCCIG GEOBKBFLHDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::DEMBNHCEGJO(typeof(ObjectPolicyData))]
public static class GNAEMBBAEDN
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x68BD1B0", Offset = "0x68BC5B0", VA = "0x1868BD1B0")]
	[global::CDNJDCHNMEH(2)]
	public static void ONGPBCIHPCH([global::AKOGMCGBMOC(3)] bool EOMIBMKMHIB, [Out][global::AKOGMCGBMOC(3)] NBGHNPHLDEF EMGMDFDPKIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::DEMBNHCEGJO(typeof(PersistentUserTagData))]
public static class HDPAOJNNCGB
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68BD1C0", Offset = "0x68BC5C0", VA = "0x1868BD1C0")]
	[global::CDNJDCHNMEH(1)]
	public static void HJDBGNLIKEO([global::AKOGMCGBMOC(1)] FixedList32Bytes<int> DKBIJHGLBLL, [Out][global::AKOGMCGBMOC(2)] bool DECJEDCHIKI)
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
