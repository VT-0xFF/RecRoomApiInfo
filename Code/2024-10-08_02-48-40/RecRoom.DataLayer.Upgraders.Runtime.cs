using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::DFHCELEDEGK(typeof(ContainerFlagsData))]
public static class CCKOEEBHLEM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C27290", Offset = "0x6C26490", VA = "0x186C27290")]
	[global::AHLJBKMBNJE(1)]
	public static void HOOOAOJOECJ([global::PKNFFIINCGN(1)] BOHCGEJKFCB KLDGLHOAFHH, [Out][global::PKNFFIINCGN(1)] BOHCGEJKFCB GLPAADEMMGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::DFHCELEDEGK(typeof(ObjectPolicyData))]
public static class CKIEFKAKIII
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C272A0", Offset = "0x6C264A0", VA = "0x186C272A0")]
	[global::AHLJBKMBNJE(2)]
	public static void HNLNHNAPGKG([global::PKNFFIINCGN(3)] bool JIANBCFEKKC, [Out][global::PKNFFIINCGN(3)] DEKBOMIPMEK CBEJFPKIGAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::DFHCELEDEGK(typeof(PersistentUserTagData))]
public static class ABDFFEEJKHK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C27280", Offset = "0x6C26480", VA = "0x186C27280")]
	[global::AHLJBKMBNJE(1)]
	public static void BNFNLGEJKNH([global::PKNFFIINCGN(1)] FixedList32Bytes<int> CJKIOJKDEFA, [Out][global::PKNFFIINCGN(2)] bool HIMKBCPHMFG)
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
