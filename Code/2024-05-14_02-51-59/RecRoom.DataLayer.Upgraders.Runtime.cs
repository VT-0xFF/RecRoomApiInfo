using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::AGFIFFCNPNM(typeof(ContainerFlagsData))]
public static class BOBHOLJLKEB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x63030E0", Offset = "0x6301AE0", VA = "0x1863030E0")]
	[global::EDDIMDEGHDF(1)]
	public static void ECGBPDFNNBH([global::GBDNJDNNBCG(1)] NIDCEBJLBCC JECDHANDPLD, [Out][global::GBDNJDNNBCG(1)] NIDCEBJLBCC KOOMNCGEOCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::AGFIFFCNPNM(typeof(ObjectPolicyData))]
public static class CAIMFPAPNIP
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x63030F0", Offset = "0x6301AF0", VA = "0x1863030F0")]
	[global::EDDIMDEGHDF(2)]
	public static void POFMMGCBBAN([global::GBDNJDNNBCG(3)] bool FHBCEPPDPEN, [Out][global::GBDNJDNNBCG(3)] GHGOCJLCCKJ LDCPKAFLBID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::AGFIFFCNPNM(typeof(PersistentUserTagData))]
public static class ABBNENMLCPD
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x63030D0", Offset = "0x6301AD0", VA = "0x1863030D0")]
	[global::EDDIMDEGHDF(1)]
	public static void CBHENELJLBH([global::GBDNJDNNBCG(1)] FixedList32Bytes<int> KAHJCFKMJIK, [Out][global::GBDNJDNNBCG(2)] bool MHCEELGJGCB)
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
