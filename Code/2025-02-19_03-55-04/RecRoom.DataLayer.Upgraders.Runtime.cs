using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class NMLKFKCDCLA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7468570", Offset = "0x7467170", VA = "0x187468570")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void JAGILEJJBHK([RecRoom.DataLayer.Field(3)] bool BBJMGAKOOML, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 HOHMEIEFKJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x337A140", Offset = "0x3378D40", VA = "0x18337A140")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void NAACGKKMKAG([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 KBPCKNBNLNJ, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 HALAKJENNMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class OCEGAEFOENJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7468580", Offset = "0x7467180", VA = "0x187468580")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void ELAODHIFIGN([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> AJOBKLGCIIG, [Out][RecRoom.DataLayer.Field(2)] bool IGJMCOCDHKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class FNJNPNAOOEI
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x337A110", Offset = "0x3378D10", VA = "0x18337A110")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void CFDMEALIKHL([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 CGPMLCFDDHA, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 DNBDCKCECAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class CGAGKDCMJFK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x337A110", Offset = "0x3378D10", VA = "0x18337A110")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void CFDMEALIKHL([RecRoom.DataLayer.Field(1)] CollisionMode_v1 CGPMLCFDDHA, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 DNBDCKCECAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class LCONHNBMEOF
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7468550", Offset = "0x7467150", VA = "0x187468550")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void AOIABAHAMJC([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 LBCJHHDGPBN, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 DFFBDDDBLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7468560", Offset = "0x7467160", VA = "0x187468560")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void CFDMEALIKHL([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 LBCJHHDGPBN, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 DFFBDDDBLIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class DPFAJFFGKOG
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x337A110", Offset = "0x3378D10", VA = "0x18337A110")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void IJGHLBNOPEO([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 CGPMLCFDDHA, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 DNBDCKCECAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class JFADINOHHML : KFLBHBDKIGH, PEGFAJCJPDH
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private ILFFMBHNJPD GJHHDMNOJJI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override NDNFAPMFFIF HBFNBGCENOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7467E20", Offset = "0x7466A20", VA = "0x187467E20", Slot = "14")]
		get
		{
			return default(NDNFAPMFFIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7467E70", Offset = "0x7466A70", VA = "0x187467E70", Slot = "16")]
	public void InitReferences(AILCBCECHFO CHJFHCEJGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7467EC0", Offset = "0x7466AC0", VA = "0x187467EC0", Slot = "15")]
	protected override void OLKBCHDLCGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x27631A0", Offset = "0x2761DA0", VA = "0x1827631A0")]
	public JFADINOHHML()
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
