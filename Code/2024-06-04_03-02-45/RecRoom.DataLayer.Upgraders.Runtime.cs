using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::IONMJJNJOBD(typeof(ContainerFlagsData))]
public static class OIPKHGGDELM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x681CCE0", Offset = "0x681B4E0", VA = "0x18681CCE0")]
	[global::LMCLGGPCCKI(1)]
	public static void DOAKBEPKEPN([global::CMNNOLJEBAE(1)] KNIOBLBDGHD NMOCBIDGDPA, [Out][global::CMNNOLJEBAE(1)] KNIOBLBDGHD IHMHCKPGJNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::IONMJJNJOBD(typeof(ObjectPolicyData))]
public static class GMGJAGNCJDA
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x681CCD0", Offset = "0x681B4D0", VA = "0x18681CCD0")]
	[global::LMCLGGPCCKI(2)]
	public static void LEDFPOKMKOC([global::CMNNOLJEBAE(3)] bool DHFAICKLOMH, [Out][global::CMNNOLJEBAE(3)] EOKNLIPIJFA LLFDOLOPMIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::IONMJJNJOBD(typeof(PersistentUserTagData))]
public static class BJFHHJHEMAM
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x681CCC0", Offset = "0x681B4C0", VA = "0x18681CCC0")]
	[global::LMCLGGPCCKI(1)]
	public static void HIHKOHCLJEJ([global::CMNNOLJEBAE(1)] FixedList32Bytes<int> KJGCAHPCGKA, [Out][global::CMNNOLJEBAE(2)] bool EPDHFBJFGDN)
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
