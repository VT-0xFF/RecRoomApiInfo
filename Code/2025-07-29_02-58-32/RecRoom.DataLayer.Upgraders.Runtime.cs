using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class IOPCBNJGLJA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x82B73E0", Offset = "0x82B5DE0", VA = "0x1882B73E0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void JKPINOKJCKC([RecRoom.DataLayer.Field(3)] bool OIJBGIMFCEB, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 DHGLMDLACKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3ADF870", Offset = "0x3ADE270", VA = "0x183ADF870")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void GKICNNGNDJL([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 PDLJHJDBNHG, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 ACIGMOOOIGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class IOGMFAHGPCK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x82B73D0", Offset = "0x82B5DD0", VA = "0x1882B73D0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void LECLJPDMCHA([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> PGEBFDGIMJK, [Out][RecRoom.DataLayer.Field(2)] bool KGOHJAOODCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class LPLBBGIJLDD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3ADF840", Offset = "0x3ADE240", VA = "0x183ADF840")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void EGHPBGEBEDF([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 GJFINIAHPMG, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 ADMLFNMDFNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class FPBDLJKMAKH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3ADF840", Offset = "0x3ADE240", VA = "0x183ADF840")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void EGHPBGEBEDF([RecRoom.DataLayer.Field(1)] CollisionMode_v1 GJFINIAHPMG, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 ADMLFNMDFNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class HHIFKDCOKMK
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x82B73C0", Offset = "0x82B5DC0", VA = "0x1882B73C0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void NHGPFGADBBM([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 HOOCOMAKLMG, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 HBFFLPGCJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x82B73B0", Offset = "0x82B5DB0", VA = "0x1882B73B0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void EGHPBGEBEDF([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 HOOCOMAKLMG, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 HBFFLPGCJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x82B73B0", Offset = "0x82B5DB0", VA = "0x1882B73B0")]
	[RecRoom.DataLayer.UpgradeFromVersion(3)]
	public static void FKBIJGLDEPD([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 HOOCOMAKLMG, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 HBFFLPGCJPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class LPEOKDNKDCD
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3ADF840", Offset = "0x3ADE240", VA = "0x183ADF840")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void OIKLAKMGEEM([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 GJFINIAHPMG, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 ADMLFNMDFNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class EJKAFOFICDN : FBLLAJJJEEL, JHNMFGKPECO
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NLGPHNLOIPM POCJJGJCJJD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override MEBJEIOEDLD GCLDEHJKFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x82B72C0", Offset = "0x82B5CC0", VA = "0x1882B72C0", Slot = "14")]
		get
		{
			return default(MEBJEIOEDLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x82B7310", Offset = "0x82B5D10", VA = "0x1882B7310", Slot = "16")]
	public void InitReferences(JFKAHIBHGGP INBLNPFFLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x82B6D00", Offset = "0x82B5700", VA = "0x1882B6D00", Slot = "15")]
	protected override void CFEFFIOGGOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2D0C920", Offset = "0x2D0B320", VA = "0x182D0C920")]
	public EJKAFOFICDN()
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
