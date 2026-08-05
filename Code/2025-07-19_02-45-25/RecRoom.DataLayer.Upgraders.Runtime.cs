using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class PPFDAODHCOM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8124820", Offset = "0x8123820", VA = "0x188124820")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void BPJEMHKNAJP([RecRoom.DataLayer.Field(3)] bool LAIDDNOGDGE, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 OMENDEGIBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3A435B0", Offset = "0x3A425B0", VA = "0x183A435B0")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void DNBDJCJIJBO([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 PGAEDBIFHEJ, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 DFNOKPMEGNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class CPFGDNOHDKK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8124160", Offset = "0x8123160", VA = "0x188124160")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void INMACGLEDHA([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> LHCAACJBMFJ, [Out][RecRoom.DataLayer.Field(2)] bool IAGAPOHJHMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class JAECCELNJOG
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3A43580", Offset = "0x3A42580", VA = "0x183A43580")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void MGNPFIELLNK([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 BKFMBMLFOLE, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 HCPHGFGFIBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class KCOFPDCJEMK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3A43580", Offset = "0x3A42580", VA = "0x183A43580")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void MGNPFIELLNK([RecRoom.DataLayer.Field(1)] CollisionMode_v1 BKFMBMLFOLE, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 HCPHGFGFIBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class BPFKADFHGEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8124140", Offset = "0x8123140", VA = "0x188124140")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void JEAADADMBOA([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 DGLPEADPFCH, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 AAOELGPEIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8124150", Offset = "0x8123150", VA = "0x188124150")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void MGNPFIELLNK([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 DGLPEADPFCH, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 AAOELGPEIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8124150", Offset = "0x8123150", VA = "0x188124150")]
	[RecRoom.DataLayer.UpgradeFromVersion(3)]
	public static void PMBINLNLEFO([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 DGLPEADPFCH, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 AAOELGPEIAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class ADGCAIFFHCB
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3A43580", Offset = "0x3A42580", VA = "0x183A43580")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void KHAICOBLGBP([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 BKFMBMLFOLE, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 HCPHGFGFIBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class GINBCKEPFGP : MCADHMFACDO, PJNGLGAADAH
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private OLNFGDBGEEF KLCPEOOBIDH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override ONIHMLNNEEF APKHGLJHJLF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8124780", Offset = "0x8123780", VA = "0x188124780", Slot = "14")]
		get
		{
			return default(ONIHMLNNEEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8124170", Offset = "0x8123170", VA = "0x188124170", Slot = "16")]
	public void InitReferences(BLPLIKKLKBG CCGPMJFFCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x81241C0", Offset = "0x81231C0", VA = "0x1881241C0", Slot = "15")]
	protected override void JMDHHKBHBDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2CDB670", Offset = "0x2CDA670", VA = "0x182CDB670")]
	public GINBCKEPFGP()
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
