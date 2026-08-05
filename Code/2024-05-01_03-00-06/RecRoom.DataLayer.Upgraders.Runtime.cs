using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::OKNPLJCMPGD(typeof(ContainerFlagsData))]
public static class DGAIMDFOEJH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x61DD780", Offset = "0x61DC580", VA = "0x1861DD780")]
	[global::OGCMFCGMFJK(1)]
	public static void IEBDPFMNMHD([global::LPKOFLNCEDL(1)] BAMHMIEKLNG NOANHIHBJNI, [Out][global::LPKOFLNCEDL(1)] BAMHMIEKLNG KCLIKAOLADB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::OKNPLJCMPGD(typeof(ObjectPolicyData))]
public static class LCOPJPEBJJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x61DD7A0", Offset = "0x61DC5A0", VA = "0x1861DD7A0")]
	[global::OGCMFCGMFJK(2)]
	public static void HIBOBOMOIEK([global::LPKOFLNCEDL(3)] bool NINLBBGJOBI, [Out][global::LPKOFLNCEDL(3)] BDIGGNJMLKE OKIGIEHONKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::OKNPLJCMPGD(typeof(PersistentUserTagData))]
public static class HGEJBBDAEPG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61DD790", Offset = "0x61DC590", VA = "0x1861DD790")]
	[global::OGCMFCGMFJK(1)]
	public static void OBOBELFEBNO([global::LPKOFLNCEDL(1)] FixedList32Bytes<int> HMMKLKCHIGP, [Out][global::LPKOFLNCEDL(2)] bool JPDFKJCBBBK)
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
