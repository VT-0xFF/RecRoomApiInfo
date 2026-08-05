using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class HLFJJDFLDAI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x833CA20", Offset = "0x833B820", VA = "0x18833CA20")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void FNAPEFECLOH([RecRoom.DataLayer.Field(3)] bool KLCCPOCIJFN, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 AEDIGFLCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3D29FD0", Offset = "0x3D28DD0", VA = "0x183D29FD0")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void BANBEODMFID([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 ADNIDBPMOJD, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 AGJEBPCKJCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class DPEILMFOFLC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x833CA10", Offset = "0x833B810", VA = "0x18833CA10")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void FFNJKMFGCLN([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> IEHEOLEINAP, [Out][RecRoom.DataLayer.Field(2)] bool KDLCAFMJCPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class NFOOMMAPPEK
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3D29FA0", Offset = "0x3D28DA0", VA = "0x183D29FA0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void FEOPPNPEGNG([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 HNLFFLNNKGK, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 AGEFPDLPNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class GMOKPOGCEMB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3D29FA0", Offset = "0x3D28DA0", VA = "0x183D29FA0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void FEOPPNPEGNG([RecRoom.DataLayer.Field(1)] CollisionMode_v1 HNLFFLNNKGK, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 AGEFPDLPNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class NMIOOMFOJHF
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x833CA40", Offset = "0x833B840", VA = "0x18833CA40")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void JOHGPIGJKDL([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 HONEFAKFPFD, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 PCGMNNAIPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x833CA30", Offset = "0x833B830", VA = "0x18833CA30")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void FEOPPNPEGNG([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 HONEFAKFPFD, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 PCGMNNAIPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x833CA30", Offset = "0x833B830", VA = "0x18833CA30")]
	[RecRoom.DataLayer.UpgradeFromVersion(3)]
	public static void NHIGDCDPAFF([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 HONEFAKFPFD, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 PCGMNNAIPMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class ADGBFAKCJAI
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3D29FA0", Offset = "0x3D28DA0", VA = "0x183D29FA0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void KBGOCMPHBGD([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 HNLFFLNNKGK, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 AGEFPDLPNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class DHIHPOFDPKA : AODBLGBGJEN, CMKJLANCAGA
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private ICLJPEBKHIL GOAOCHKJDMM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override ALMLLDBPKBM ICNEBIIBIEE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x833C970", Offset = "0x833B770", VA = "0x18833C970", Slot = "14")]
		get
		{
			return default(ALMLLDBPKBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x833C360", Offset = "0x833B160", VA = "0x18833C360", Slot = "16")]
	public void InitReferences(CKKEMANKHME GLBBEGAGJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x833C3B0", Offset = "0x833B1B0", VA = "0x18833C3B0", Slot = "15")]
	protected override void NNBJJGHJBBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2D7A0A0", Offset = "0x2D78EA0", VA = "0x182D7A0A0")]
	public DHIHPOFDPKA()
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
