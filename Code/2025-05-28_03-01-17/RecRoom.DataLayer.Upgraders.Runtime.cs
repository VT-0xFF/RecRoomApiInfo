using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class GJEHNLAPLFC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7D565E0", Offset = "0x7D553E0", VA = "0x187D565E0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void EHJBOHIFLNO([RecRoom.DataLayer.Field(3)] bool HKKIKPAAAPK, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 KKBDAOHAGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4148BC0", Offset = "0x41479C0", VA = "0x184148BC0")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void BIPDFLNFBBP([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 HIKDLOJNBJD, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 PGFPNHDODGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class ICOHHCNCHCG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7D565F0", Offset = "0x7D553F0", VA = "0x187D565F0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void FOAHJNBPPJP([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> FIAMKOAPKNO, [Out][RecRoom.DataLayer.Field(2)] bool ODCFILDBKCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class CDOGFFAHCCP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4148BA0", Offset = "0x41479A0", VA = "0x184148BA0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void HNNEOPMOBFM([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 KHJEADFMOJM, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 BHBDEJBFADC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class KCNJOJIHMIO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4148BA0", Offset = "0x41479A0", VA = "0x184148BA0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void HNNEOPMOBFM([RecRoom.DataLayer.Field(1)] CollisionMode_v1 KHJEADFMOJM, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 BHBDEJBFADC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class FCNGLIPKFFG
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7D565C0", Offset = "0x7D553C0", VA = "0x187D565C0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void GAEALMELLGF([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 ALAAFJOMEJA, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 OBFNKIPGEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7D565D0", Offset = "0x7D553D0", VA = "0x187D565D0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void HNNEOPMOBFM([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 ALAAFJOMEJA, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 OBFNKIPGEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7D565D0", Offset = "0x7D553D0", VA = "0x187D565D0")]
	[RecRoom.DataLayer.UpgradeFromVersion(3)]
	public static void HHCEHOJMAMG([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 ALAAFJOMEJA, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 OBFNKIPGEPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class MFLDLJAKHOM
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4148BA0", Offset = "0x41479A0", VA = "0x184148BA0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void IJALEAMEIIE([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 KHJEADFMOJM, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 BHBDEJBFADC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class ODNBPKGBAFA : PBINLJPKIGC, GACJOGFPDAE
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NJMAGLDKMDP GDGKDIOOOJE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override IEBEPMGFCGH NDLHJECGFPL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7D56600", Offset = "0x7D55400", VA = "0x187D56600", Slot = "14")]
		get
		{
			return default(IEBEPMGFCGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D56650", Offset = "0x7D55450", VA = "0x187D56650", Slot = "16")]
	public void InitReferences(LFBEMDOHFPC EPHKCBICOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7D566A0", Offset = "0x7D554A0", VA = "0x187D566A0", Slot = "15")]
	protected override void OGBLGNGEAPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2A78D90", Offset = "0x2A77B90", VA = "0x182A78D90")]
	public ODNBPKGBAFA()
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
