using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::NFBIHJKNAMA(typeof(ContainerFlagsData))]
public static class DBIDKHDIHLB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF2A0", Offset = "0x5FBE0A0", VA = "0x185FBF2A0")]
	[global::MFPJBGJCJOL(1)]
	public static void IPBFOGAMPEH([global::MNHIBGCDOBM(1)] NONJHGAANGP ONIEEMLIBMF, [Out][global::MNHIBGCDOBM(1)] NONJHGAANGP EAACDBCCLAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::NFBIHJKNAMA(typeof(ObjectPolicyData))]
public static class BNJLHCLNCOL
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF290", Offset = "0x5FBE090", VA = "0x185FBF290")]
	[global::MFPJBGJCJOL(2)]
	public static void IGBOGPECLCI([global::MNHIBGCDOBM(3)] bool DMHOIHBLGLA, [Out][global::MNHIBGCDOBM(3)] HJHFJNCLMIG LJFFFJBJMOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::NFBIHJKNAMA(typeof(PersistentUserTagData))]
public static class KHAFGFLJAHK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF2B0", Offset = "0x5FBE0B0", VA = "0x185FBF2B0")]
	[global::MFPJBGJCJOL(1)]
	public static void ALLKBIKHKAD([global::MNHIBGCDOBM(1)] FixedList32Bytes<int> JAKMGJIIIFN, [Out][global::MNHIBGCDOBM(2)] bool EHNCJOPMNCI)
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
