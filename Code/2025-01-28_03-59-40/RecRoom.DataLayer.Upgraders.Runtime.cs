using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class DHHMAOBMBPL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x71DD7F0", Offset = "0x71DC9F0", VA = "0x1871DD7F0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void HANAODNDGLE([RecRoom.DataLayer.Field(3)] bool FPDNKCGNPEF, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 HPIEALDMKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3336000", Offset = "0x3335200", VA = "0x183336000")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void MOFLKHOOEEM([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 KGKHOCAIHMN, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 AIGNIMOHCDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class EMAIHIHEKPB
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x71DD800", Offset = "0x71DCA00", VA = "0x1871DD800")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void LJOMFBLBEPN([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> FIHHAAIJGPL, [Out][RecRoom.DataLayer.Field(2)] bool OHNHMAMOJIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class CIALLFPAPJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3335FD0", Offset = "0x33351D0", VA = "0x183335FD0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void DMBKAHNKKIP([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 BGKIOALJNDJ, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 GGHDHEDBJLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class ELIOHBIKBDF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3335FD0", Offset = "0x33351D0", VA = "0x183335FD0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void DMBKAHNKKIP([RecRoom.DataLayer.Field(1)] CollisionMode_v1 BGKIOALJNDJ, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 GGHDHEDBJLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class JCGGKHCGDAB
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x71DD820", Offset = "0x71DCA20", VA = "0x1871DD820")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void LJCNFKKCIJE([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 ADCCODBPOPB, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 BAKKBBOMLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x71DD810", Offset = "0x71DCA10", VA = "0x1871DD810")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void DMBKAHNKKIP([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 ADCCODBPOPB, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 BAKKBBOMLDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class INEBGNDLCLD
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3335FD0", Offset = "0x33351D0", VA = "0x183335FD0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void FCCILBFNCLF([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 BGKIOALJNDJ, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 GGHDHEDBJLK)
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
