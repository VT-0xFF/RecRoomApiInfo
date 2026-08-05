using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class PCIKOODFNNP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x723C240", Offset = "0x723B040", VA = "0x18723C240")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void BBBMMMBFKKJ([RecRoom.DataLayer.Field(3)] bool GFMCMKHENKH, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 HNALEDONGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x32B6610", Offset = "0x32B5410", VA = "0x1832B6610")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void DJKBPCPBMAB([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 LCNMKIDANOO, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 KDAODECDMCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class IHGFLDCCPHM
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x723C230", Offset = "0x723B030", VA = "0x18723C230")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void CFLGFOLJJKA([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> LGAJBJOLBKK, [Out][RecRoom.DataLayer.Field(2)] bool ELOKMCPMOLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class EBBDEBHMANB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x32B65E0", Offset = "0x32B53E0", VA = "0x1832B65E0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void AIGCPGKFJOM([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 BKEPLGJNEJH, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 COJIJIEDOKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class KJOPEAMCLCE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x32B65E0", Offset = "0x32B53E0", VA = "0x1832B65E0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void AIGCPGKFJOM([RecRoom.DataLayer.Field(1)] CollisionMode_v1 BKEPLGJNEJH, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 COJIJIEDOKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class FGFNGHHCBDO
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x723C220", Offset = "0x723B020", VA = "0x18723C220")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void JFBEGIJOKOC([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 MMANGOAGNFP, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 HBMGAKEDAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x723C210", Offset = "0x723B010", VA = "0x18723C210")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void AIGCPGKFJOM([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 MMANGOAGNFP, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 HBMGAKEDAGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class BPAFAKOCPCC
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x32B65E0", Offset = "0x32B53E0", VA = "0x1832B65E0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void GKPFOLGHIJH([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 BKEPLGJNEJH, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 COJIJIEDOKL)
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
