using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class PPACMGLCPKG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7F5A700", Offset = "0x7F58F00", VA = "0x187F5A700")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void DHLACNFMFLD([RecRoom.DataLayer.Field(3)] bool MONACIKMHCC, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 NMFHGOAHANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F0F0", Offset = "0x3A9D8F0", VA = "0x183A9F0F0")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void EJHLOGMMBBJ([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 HAIBAGMKENG, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 IIPGAFKJNLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class LMPMMDILMBO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7F5A6D0", Offset = "0x7F58ED0", VA = "0x187F5A6D0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void JMJPIFACFLB([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> LKKCBIFCBED, [Out][RecRoom.DataLayer.Field(2)] bool OAEJBPCDJCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class IJPKMHAHEBN
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F0C0", Offset = "0x3A9D8C0", VA = "0x183A9F0C0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void KLLONHLHANE([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 GJKNNKIANJJ, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 NMNMOFPMJKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class BMANGIDHHIE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F0C0", Offset = "0x3A9D8C0", VA = "0x183A9F0C0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void KLLONHLHANE([RecRoom.DataLayer.Field(1)] CollisionMode_v1 GJKNNKIANJJ, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 NMNMOFPMJKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class PCHFGIPNODJ
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F5A6F0", Offset = "0x7F58EF0", VA = "0x187F5A6F0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void HHJFIOEALDN([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 PPGABMFGNCC, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 BGPNGCEFEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F5A6E0", Offset = "0x7F58EE0", VA = "0x187F5A6E0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void KLLONHLHANE([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 PPGABMFGNCC, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 BGPNGCEFEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7F5A6E0", Offset = "0x7F58EE0", VA = "0x187F5A6E0")]
	[RecRoom.DataLayer.UpgradeFromVersion(3)]
	public static void FKOCJKKNPHG([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 PPGABMFGNCC, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 BGPNGCEFEGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class BFGOIMNKCHI
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F0C0", Offset = "0x3A9D8C0", VA = "0x183A9F0C0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void IGPJPPBNMPN([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 GJKNNKIANJJ, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 NMNMOFPMJKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class EPNODFODILP : MGLMPKHAIKK, FHLMMIDFMKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private ECLGHANDHLL FIBHGPNFMJH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override BMELPJIFPCL MIHGFEDHECA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7F5A020", Offset = "0x7F58820", VA = "0x187F5A020", Slot = "14")]
		get
		{
			return default(BMELPJIFPCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F5A630", Offset = "0x7F58E30", VA = "0x187F5A630", Slot = "16")]
	public void InitReferences(OBECFEHHJHL NOKFLPEFADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7F5A070", Offset = "0x7F58870", VA = "0x187F5A070", Slot = "15")]
	protected override void DEILEOEKILO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2B051F0", Offset = "0x2B039F0", VA = "0x182B051F0")]
	public EPNODFODILP()
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
