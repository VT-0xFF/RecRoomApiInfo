using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class LKAFOJJCPJH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x84A7D00", Offset = "0x84A6700", VA = "0x1884A7D00")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void PPKBELFDJGI([RecRoom.DataLayer.Field(3)] bool KGIENFBNMGI, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 JHBIAAAGFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3DECDD0", Offset = "0x3DEB7D0", VA = "0x183DECDD0")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void NBPALBIFKKH([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 IMGODHPFAEJ, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 ELKKBFOGLKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class BHHOPHEOFJA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x84A7630", Offset = "0x84A6030", VA = "0x1884A7630")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void KLBOLJLNMOG([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> FOBGEFFAIOK, [Out][RecRoom.DataLayer.Field(2)] bool EJKGFBMADGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class MJNNOMNBDMC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3DECDA0", Offset = "0x3DEB7A0", VA = "0x183DECDA0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void IAFPMCOGLGI([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 KGCMICBGABJ, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 MPGFNEFLINC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class ECLCEIFNCFK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3DECDA0", Offset = "0x3DEB7A0", VA = "0x183DECDA0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void IAFPMCOGLGI([RecRoom.DataLayer.Field(1)] CollisionMode_v1 KGCMICBGABJ, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 MPGFNEFLINC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class MGNINKNJDFO
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x84A7D20", Offset = "0x84A6720", VA = "0x1884A7D20")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void LMEOJBDAGJI([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 EHCCBGLCELD, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 MNIOMPGMLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x84A7D10", Offset = "0x84A6710", VA = "0x1884A7D10")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void IAFPMCOGLGI([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 EHCCBGLCELD, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 MNIOMPGMLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x84A7D10", Offset = "0x84A6710", VA = "0x1884A7D10")]
	[RecRoom.DataLayer.UpgradeFromVersion(3)]
	public static void MJAHINELMIC([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 EHCCBGLCELD, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 MNIOMPGMLGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class OKCFDIEJENF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3DECDA0", Offset = "0x3DEB7A0", VA = "0x183DECDA0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void HDJCNIMOIPG([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 KGCMICBGABJ, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 MPGFNEFLINC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class BOPBCGICIKC : MBOGFOIFGED, BOHILICPPOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private PHHAKGMBJOL FJJDLJNOFCM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override OLFEOKKCIEG JAPFEIFECJM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84A7640", Offset = "0x84A6040", VA = "0x1884A7640", Slot = "14")]
		get
		{
			return default(OLFEOKKCIEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84A7690", Offset = "0x84A6090", VA = "0x1884A7690", Slot = "16")]
	public void InitReferences(BDGILPFNAIO NBEKNJIPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x84A76E0", Offset = "0x84A60E0", VA = "0x1884A76E0", Slot = "15")]
	protected override void OFPPJINCNDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
	public BOPBCGICIKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[RecRoom.DataLayer.Upgrader(typeof(TerrainWaterData))]
public static class PPBHGPJDMBA
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3DECDA0", Offset = "0x3DEB7A0", VA = "0x183DECDA0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void FLBDINJPFBF([RecRoom.DataLayer.Field(7)] TerrainWaterMaterial_v1 IMGODHPFAEJ, [Out][RecRoom.DataLayer.Field(7)] TerrainWaterMaterial_v2 LGLNBNPEKLK)
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
