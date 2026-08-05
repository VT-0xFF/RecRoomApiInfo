using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ContainerFlagsData))]
public static class KHJJJHDHDIB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0BB0", Offset = "0x6DAF5B0", VA = "0x186DB0BB0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void GKBIELKLCAI([RecRoom.DataLayer.Field(1)] OKCENOEKMFE EAHKDEODLJK, [Out][RecRoom.DataLayer.Field(1)] OKCENOEKMFE ADDPGMCOMGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class IECMPOFDMKA
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0BA0", Offset = "0x6DAF5A0", VA = "0x186DB0BA0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void LOPHHBDNPJB([RecRoom.DataLayer.Field(3)] bool AMGMGEFOENF, [Out][RecRoom.DataLayer.Field(3)] KKJLAJPGCHJ DDACCEBMBND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class BIPJEOJEHPF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0B90", Offset = "0x6DAF590", VA = "0x186DB0B90")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void BCPJMBJDCFD([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> JDCDPICBDPE, [Out][RecRoom.DataLayer.Field(2)] bool MOGNLBEMDBN)
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
