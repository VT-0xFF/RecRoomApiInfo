using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class AAIJDGFFMIL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8414DC0", Offset = "0x84133C0", VA = "0x188414DC0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void EFONMILOMNJ([RecRoom.DataLayer.Field(3)] bool ANGBKOKMDPD, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 OAKCIAMNOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3DB70A0", Offset = "0x3DB56A0", VA = "0x183DB70A0")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void NAPLCOPLOMH([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 GFHDKHCEGAG, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 AHOIBMBJKJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class GDELNDNGPCK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8414DF0", Offset = "0x84133F0", VA = "0x188414DF0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void IGMPNFKMKBD([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> MFBOBLCOBIC, [Out][RecRoom.DataLayer.Field(2)] bool LIOHLLNKKLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class HMCDFJAIHKG
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3DB7070", Offset = "0x3DB5670", VA = "0x183DB7070")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void CHJEDHJBLLP([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 JHGKHIGHBBL, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 BDHPLBBJNMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class OCOPICMGPFH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3DB7070", Offset = "0x3DB5670", VA = "0x183DB7070")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void CHJEDHJBLLP([RecRoom.DataLayer.Field(1)] CollisionMode_v1 JHGKHIGHBBL, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 BDHPLBBJNMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class ENHIAFKIIND
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8414DE0", Offset = "0x84133E0", VA = "0x188414DE0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void GBMLLHAIPAM([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 JPAMEIMOHGI, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 PGGHILKKBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8414DD0", Offset = "0x84133D0", VA = "0x188414DD0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void CHJEDHJBLLP([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 JPAMEIMOHGI, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 PGGHILKKBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8414DD0", Offset = "0x84133D0", VA = "0x188414DD0")]
	[RecRoom.DataLayer.UpgradeFromVersion(3)]
	public static void GCAPJAJDPKA([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 JPAMEIMOHGI, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 PGGHILKKBLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class AFPDGLNHIDO
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3DB7070", Offset = "0x3DB5670", VA = "0x183DB7070")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void MNPCDNIOMHA([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 JHGKHIGHBBL, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 BDHPLBBJNMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class LAHAGLAFKND : JJGJGPDOCLP, DPFKFJLGBCO
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NPIDHPAHKDP BPNFCMEJILE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override IDGHEFJHGEI AOPICECIPOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8415420", Offset = "0x8413A20", VA = "0x188415420", Slot = "14")]
		get
		{
			return default(IDGHEFJHGEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84153D0", Offset = "0x84139D0", VA = "0x1884153D0", Slot = "16")]
	public void InitReferences(MKDGNELEFKI MMELACBKGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8414E00", Offset = "0x8413400", VA = "0x188414E00", Slot = "15")]
	protected override void EHHIPFLBJFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2D9FA40", Offset = "0x2D9E040", VA = "0x182D9FA40")]
	public LAHAGLAFKND()
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
