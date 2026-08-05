using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class PNIIOGHICLD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x77CE6F0", Offset = "0x77CDAF0", VA = "0x1877CE6F0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void IEGMGDCELAN([RecRoom.DataLayer.Field(3)] bool HFBOMMNGGDB, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 CPMLONDPBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x35D9F70", Offset = "0x35D9370", VA = "0x1835D9F70")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void FHHEDDKNADE([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 CHAOCCEIJLD, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 GJLPLOLFIKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class KJBMDAGCNDK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x77CE6C0", Offset = "0x77CDAC0", VA = "0x1877CE6C0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void OIAEEJKEPIE([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> MEBHEOCCLEP, [Out][RecRoom.DataLayer.Field(2)] bool FLFOHAFMBJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class HIOAIBBOALM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x35D9F40", Offset = "0x35D9340", VA = "0x1835D9F40")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void JCLCPIFJAJI([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 ICAPBAKKPBL, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 DHFBCDKDEBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class HPBOAFALOOC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x35D9F40", Offset = "0x35D9340", VA = "0x1835D9F40")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void JCLCPIFJAJI([RecRoom.DataLayer.Field(1)] CollisionMode_v1 ICAPBAKKPBL, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 DHFBCDKDEBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class OENEPFJEPED
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x77CE6E0", Offset = "0x77CDAE0", VA = "0x1877CE6E0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void MEAFPMGGPNP([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 PGJNNFBLICH, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 LIGLAJLMDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x77CE6D0", Offset = "0x77CDAD0", VA = "0x1877CE6D0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void JCLCPIFJAJI([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 PGJNNFBLICH, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 LIGLAJLMDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x77CE6D0", Offset = "0x77CDAD0", VA = "0x1877CE6D0")]
	[RecRoom.DataLayer.UpgradeFromVersion(3)]
	public static void GLGJONNCFIN([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 PGJNNFBLICH, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 LIGLAJLMDDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class JPMFAAPDNOF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x35D9F40", Offset = "0x35D9340", VA = "0x1835D9F40")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void GNABFBOONJH([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 ICAPBAKKPBL, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 DHFBCDKDEBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class ACKFEEHAEHP : FJAOCJNHBPG, IHCCKBEFLCO
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private AHBNDOHGONG DIJPGPHNLBB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override ABDDJEPKCOD DLBCFJLNCHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x77CE5D0", Offset = "0x77CD9D0", VA = "0x1877CE5D0", Slot = "14")]
		get
		{
			return default(ABDDJEPKCOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x77CE620", Offset = "0x77CDA20", VA = "0x1877CE620", Slot = "16")]
	public void InitReferences(INNCJKBLPNO OOCDOIMOCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x77CE010", Offset = "0x77CD410", VA = "0x1877CE010", Slot = "15")]
	protected override void BIOMHKNCIPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x287BC50", Offset = "0x287B050", VA = "0x18287BC50")]
	public ACKFEEHAEHP()
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
