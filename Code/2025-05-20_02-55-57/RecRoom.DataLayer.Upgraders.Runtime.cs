using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class PNIBNIFPAHL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7C51E10", Offset = "0x7C51010", VA = "0x187C51E10")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void AEHNIDFLLAF([RecRoom.DataLayer.Field(3)] bool IAFGFPIMJDF, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 MJJLCGKEEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x386ABB0", Offset = "0x3869DB0", VA = "0x18386ABB0")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void JEKLHMHGJGG([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 KAFBMBFLMAN, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 EHCPKNNAGCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class HNNGGBMHCCF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7C51750", Offset = "0x7C50950", VA = "0x187C51750")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void AMLAINHPELF([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> BLGKPGNAIBK, [Out][RecRoom.DataLayer.Field(2)] bool FLAACCIPMCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class MHDCCBMPMGK
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x386AB80", Offset = "0x3869D80", VA = "0x18386AB80")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void EDGFKHAGGKI([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 JIJCOIBMMGK, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 PDBEAHFDFJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class EKDHLNHIEPP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x386AB80", Offset = "0x3869D80", VA = "0x18386AB80")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void EDGFKHAGGKI([RecRoom.DataLayer.Field(1)] CollisionMode_v1 JIJCOIBMMGK, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 PDBEAHFDFJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class ELLPKCEEEBO
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C51740", Offset = "0x7C50940", VA = "0x187C51740")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void KFHFIIIPLLK([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 JCBEELOPLAI, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 PHPKBFHMFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C51730", Offset = "0x7C50930", VA = "0x187C51730")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void EDGFKHAGGKI([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 JCBEELOPLAI, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 PHPKBFHMFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C51730", Offset = "0x7C50930", VA = "0x187C51730")]
	[RecRoom.DataLayer.UpgradeFromVersion(3)]
	public static void CCKAKGHEIGI([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 JCBEELOPLAI, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 PHPKBFHMFAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class OBGEIEAOEHM
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x386AB80", Offset = "0x3869D80", VA = "0x18386AB80")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void MGFEOPIGKAI([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 JIJCOIBMMGK, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 PDBEAHFDFJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class NHCLNOHJPLF : DLCFKFGCDJI, IELLFNEFJEB
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private OMNBBOPHMDK IMKKFKBDHKM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override FODGIOKBGBI GCMHLHCLEDM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C517B0", Offset = "0x7C509B0", VA = "0x187C517B0", Slot = "14")]
		get
		{
			return default(FODGIOKBGBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C51760", Offset = "0x7C50960", VA = "0x187C51760", Slot = "16")]
	public void InitReferences(PJPDGGELCKG JIHODFEAJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C51800", Offset = "0x7C50A00", VA = "0x187C51800", Slot = "15")]
	protected override void NPLOINNMNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2A042A0", Offset = "0x2A034A0", VA = "0x182A042A0")]
	public NHCLNOHJPLF()
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
