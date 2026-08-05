using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::OAEHJLJCHPO(typeof(ContainerFlagsData))]
public static class BFPBGHJDKLH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6976D10", Offset = "0x6975310", VA = "0x186976D10")]
	[global::CAGJMNEJICB(1)]
	public static void KAOCHCABJFE([global::OEDHNLDDELA(1)] LONNJOBPNCL AAKABOLFJJG, [Out][global::OEDHNLDDELA(1)] LONNJOBPNCL BGONENLPBKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::OAEHJLJCHPO(typeof(ObjectPolicyData))]
public static class HMEJBBOFCHL
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6976D30", Offset = "0x6975330", VA = "0x186976D30")]
	[global::CAGJMNEJICB(2)]
	public static void EBEINPBFEEN([global::OEDHNLDDELA(3)] bool KIMJCBEBFEL, [Out][global::OEDHNLDDELA(3)] PEHDHGKMHNJ NCGAEKDJMAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::OAEHJLJCHPO(typeof(PersistentUserTagData))]
public static class DHBJEKOCOPD
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6976D20", Offset = "0x6975320", VA = "0x186976D20")]
	[global::CAGJMNEJICB(1)]
	public static void OEPFLLCEEOA([global::OEDHNLDDELA(1)] FixedList32Bytes<int> LNMGFNBGPMP, [Out][global::OEDHNLDDELA(2)] bool AKKMDFFGIPB)
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
