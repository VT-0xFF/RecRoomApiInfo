using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class NMNCMGALONE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7AB6900", Offset = "0x7AB5D00", VA = "0x187AB6900")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void ELJNEHHHKGG([RecRoom.DataLayer.Field(3)] bool FJMCHFCPKEE, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 PNEABCGFGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x36A4F70", Offset = "0x36A4370", VA = "0x1836A4F70")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void DIPFJJEEBBB([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 NJJGNHFHOAM, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 GALFANPJNOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class IMJFIMELBAA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7AB68D0", Offset = "0x7AB5CD0", VA = "0x187AB68D0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void PJNAKBLGAKL([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> ECIJIOCGBJK, [Out][RecRoom.DataLayer.Field(2)] bool JFPOLLPPILN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class MOPJDFKHDGA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x36A4F40", Offset = "0x36A4340", VA = "0x1836A4F40")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void OPDNMMHBAGM([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 BHCEDEKBMHE, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 CMLCOMAALAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class HDDNPFIOKKM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x36A4F40", Offset = "0x36A4340", VA = "0x1836A4F40")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void OPDNMMHBAGM([RecRoom.DataLayer.Field(1)] CollisionMode_v1 BHCEDEKBMHE, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 CMLCOMAALAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class IPBKLJPKJDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7AB68E0", Offset = "0x7AB5CE0", VA = "0x187AB68E0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void JCOBKOJOEFB([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 LLBGJIABGIB, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 DJCAADNILLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7AB68F0", Offset = "0x7AB5CF0", VA = "0x187AB68F0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void OPDNMMHBAGM([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 LLBGJIABGIB, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 DJCAADNILLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7AB68F0", Offset = "0x7AB5CF0", VA = "0x187AB68F0")]
	[RecRoom.DataLayer.UpgradeFromVersion(3)]
	public static void KICMOIHDDPI([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 LLBGJIABGIB, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 DJCAADNILLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class JAKDIHJBAGL
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x36A4F40", Offset = "0x36A4340", VA = "0x1836A4F40")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void MGGPDAIICNL([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 BHCEDEKBMHE, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 CMLCOMAALAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class HEBBIFOGMEB : DMNNDJMNGMN, JFNILPFMLLH
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private BEBKLMKMMDJ ONBKIDOEFAN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override LMKAPNBAFDO BKFDGJHNENK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7AB6830", Offset = "0x7AB5C30", VA = "0x187AB6830", Slot = "14")]
		get
		{
			return default(LMKAPNBAFDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7AB6210", Offset = "0x7AB5610", VA = "0x187AB6210", Slot = "16")]
	public void InitReferences(KKNBMHIKNAE GDLAIBAPFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7AB6260", Offset = "0x7AB5660", VA = "0x187AB6260", Slot = "15")]
	protected override void OMIHJNKMDHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x29403C0", Offset = "0x293F7C0", VA = "0x1829403C0")]
	public HEBBIFOGMEB()
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
