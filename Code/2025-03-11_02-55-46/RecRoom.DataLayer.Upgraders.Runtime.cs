using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class LMADMFBDLNA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x75A29C0", Offset = "0x75A1DC0", VA = "0x1875A29C0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void OEKBLHFANKB([RecRoom.DataLayer.Field(3)] bool ADHBBPCJOAO, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 NHJKDMPGJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3621240", Offset = "0x3620640", VA = "0x183621240")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void HAIGMINJBGN([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 GPCIMOKNEGB, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 GFEAIPODHNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class ALEGJKICPGP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x75A2300", Offset = "0x75A1700", VA = "0x1875A2300")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void IHIDCHNEHLE([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> JJCIOCEFNLE, [Out][RecRoom.DataLayer.Field(2)] bool ILLNPEDGDIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class COEMKLPEKKL
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3621210", Offset = "0x3620610", VA = "0x183621210")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void DCKLDELNPDO([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 BLMGNEDEHDK, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 EBNFGKDLPAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class BAOODMAKNEL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3621210", Offset = "0x3620610", VA = "0x183621210")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void DCKLDELNPDO([RecRoom.DataLayer.Field(1)] CollisionMode_v1 BLMGNEDEHDK, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 EBNFGKDLPAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class MNCAFLDFABF
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x75A29D0", Offset = "0x75A1DD0", VA = "0x1875A29D0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void AKECCJDEBCF([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 BKJBGKFEPGB, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 KMJFGAHNJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x75A29E0", Offset = "0x75A1DE0", VA = "0x1875A29E0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void DCKLDELNPDO([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 BKJBGKFEPGB, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 KMJFGAHNJPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class BLLEGGELHPL
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3621210", Offset = "0x3620610", VA = "0x183621210")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void JCOJBMJOABJ([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 BLMGNEDEHDK, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 EBNFGKDLPAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class CAKGLCGGJIH : KLPLMHFHIEA, FLJLMKCIEIM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly HLBHMADGLFA GCIBFPDCNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private OAALKIJDLOD HKDAOBKAKGE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override HLBHMADGLFA COHAOGFFGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x75A2920", Offset = "0x75A1D20", VA = "0x1875A2920", Slot = "14")]
		get
		{
			return default(HLBHMADGLFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x75A28D0", Offset = "0x75A1CD0", VA = "0x1875A28D0", Slot = "16")]
	public void InitReferences(FHGOKBONFMJ BHDEAEIFGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x75A2310", Offset = "0x75A1710", VA = "0x1875A2310", Slot = "15")]
	protected override void IKMPNONKEPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x27FBB00", Offset = "0x27FAF00", VA = "0x1827FBB00")]
	public CAKGLCGGJIH()
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
