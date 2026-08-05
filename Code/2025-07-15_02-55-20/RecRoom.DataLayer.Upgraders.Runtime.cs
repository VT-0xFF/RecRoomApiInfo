using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class KEPPLHNBLPE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x80B08B0", Offset = "0x80AF4B0", VA = "0x1880B08B0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void DAHLIPBDGDO([RecRoom.DataLayer.Field(3)] bool EAAKIJIBMAD, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 HHPCFHFLKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3195B00", Offset = "0x3194700", VA = "0x183195B00")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void LDKFNPBOHME([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 NFCHCPFDFMN, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 GAFJKOKCPFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class DGNCMCCOOKB
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x80B0880", Offset = "0x80AF480", VA = "0x1880B0880")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void GGFKOHEHABG([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> OBELFLFLBMI, [Out][RecRoom.DataLayer.Field(2)] bool JHFBBEPGAOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class HAIOIDFGLIO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3195AD0", Offset = "0x31946D0", VA = "0x183195AD0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void FECCNFMKMKI([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 OJNBCCCOMPJ, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 IOKMBOFHINB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class ACEAFHOIFFI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3195AD0", Offset = "0x31946D0", VA = "0x183195AD0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void FECCNFMKMKI([RecRoom.DataLayer.Field(1)] CollisionMode_v1 OJNBCCCOMPJ, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 IOKMBOFHINB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class GAGGAGGBHOI
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x80B0890", Offset = "0x80AF490", VA = "0x1880B0890")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void BLBJBFPKPDA([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 HDCPMFALPKO, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 EEIOKKGKAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x80B08A0", Offset = "0x80AF4A0", VA = "0x1880B08A0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void FECCNFMKMKI([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 HDCPMFALPKO, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 EEIOKKGKAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x80B08A0", Offset = "0x80AF4A0", VA = "0x1880B08A0")]
	[RecRoom.DataLayer.UpgradeFromVersion(3)]
	public static void IBFJBBFGAFM([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 HDCPMFALPKO, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 EEIOKKGKAPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class DKBNCFBAJNM
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3195AD0", Offset = "0x31946D0", VA = "0x183195AD0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void GLDCOGPECAH([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 OJNBCCCOMPJ, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 IOKMBOFHINB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class NOOMCFDLBAL : CJKPIPFJMAE, PNNOEJFPBEL
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private OIENKMAIJMM JEEMKABDLNP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override PEOHNMCPNIJ OJAPELLDHBE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x80B08C0", Offset = "0x80AF4C0", VA = "0x1880B08C0", Slot = "14")]
		get
		{
			return default(PEOHNMCPNIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x80B0910", Offset = "0x80AF510", VA = "0x1880B0910", Slot = "16")]
	public void InitReferences(MDHHMAKNOBB HKAENDMEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x80B0960", Offset = "0x80AF560", VA = "0x1880B0960", Slot = "15")]
	protected override void OBEJJCMJBBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2CB4A60", Offset = "0x2CB3660", VA = "0x182CB4A60")]
	public NOOMCFDLBAL()
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
