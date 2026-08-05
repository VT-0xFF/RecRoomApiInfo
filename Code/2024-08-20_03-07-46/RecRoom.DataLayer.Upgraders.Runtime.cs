using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::PHHJNBMLBNJ(typeof(ContainerFlagsData))]
public static class LPEDGHFGEDE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6941590", Offset = "0x6940590", VA = "0x186941590")]
	[global::MBOMOCPBJPD(1)]
	public static void GPBPMEKMNMN([global::GOKFAGPOOAO(1)] CCGENIJLDEA MKECELCGCDC, [Out][global::GOKFAGPOOAO(1)] CCGENIJLDEA OFAAKMKMNGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::PHHJNBMLBNJ(typeof(ObjectPolicyData))]
public static class PAAPDMDAEBE
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69415A0", Offset = "0x69405A0", VA = "0x1869415A0")]
	[global::MBOMOCPBJPD(2)]
	public static void CEOPAGHMOAM([global::GOKFAGPOOAO(3)] bool IKEGPAJLLLF, [Out][global::GOKFAGPOOAO(3)] AKKFFPHNNIN MOMOANKHLJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::PHHJNBMLBNJ(typeof(PersistentUserTagData))]
public static class EJMCBBHFBFM
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6941580", Offset = "0x6940580", VA = "0x186941580")]
	[global::MBOMOCPBJPD(1)]
	public static void NBMOKEDIEHM([global::GOKFAGPOOAO(1)] FixedList32Bytes<int> AIOEALANAFH, [Out][global::GOKFAGPOOAO(2)] bool KGCMOPMBIND)
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
