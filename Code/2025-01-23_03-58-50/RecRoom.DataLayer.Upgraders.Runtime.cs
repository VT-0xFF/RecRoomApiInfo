using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ContainerFlagsData))]
public static class JMMAPODGPFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F09D90", Offset = "0x6F08590", VA = "0x186F09D90")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void EEMNODBEAEK([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 MGDJKDGLKGF, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 JOFDEHIBDID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class NBFJKLJFNAN
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F09DA0", Offset = "0x6F085A0", VA = "0x186F09DA0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void ABOJOJACEBK([RecRoom.DataLayer.Field(3)] bool PFMJMCHOLEO, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 NHJAJPHALPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class GEDONFLINDM
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F09D80", Offset = "0x6F08580", VA = "0x186F09D80")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void GDIFHGMNPGE([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> LJIMCKDEHJA, [Out][RecRoom.DataLayer.Field(2)] bool DGGDIDGMJHB)
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
