using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ContainerFlagsData))]
public static class AKAFLIODHDG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2C70", Offset = "0x6FB2070", VA = "0x186FB2C70")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void NCEDHPIGPPJ([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 CJEICPMOALD, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 MEJBBCGOHDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class JAJIAMGHKIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2C90", Offset = "0x6FB2090", VA = "0x186FB2C90")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void HGMCKPGFOBH([RecRoom.DataLayer.Field(3)] bool BKCOOOBJANL, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 OBCABLKNBMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class BAAPHAMELDP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2C80", Offset = "0x6FB2080", VA = "0x186FB2C80")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void DAOHBIBCNBG([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> KDNNPAMIKAL, [Out][RecRoom.DataLayer.Field(2)] bool GLDAIKHBFDP)
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
