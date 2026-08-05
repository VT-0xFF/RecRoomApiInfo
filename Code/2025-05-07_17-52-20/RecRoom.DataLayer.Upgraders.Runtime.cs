using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class EIBIHKPDMMC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CFC0", Offset = "0x7C1BFC0", VA = "0x187C1CFC0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void CGKNOPHLGEN([RecRoom.DataLayer.Field(3)] bool DIIGLPJLFEO, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 EIBMLBPPJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3888DC0", Offset = "0x3887DC0", VA = "0x183888DC0")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void IJMIIABCFNC([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 IFKAFBEGKEH, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 AGPCDJANBHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class BCEJHIBCJMI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CF90", Offset = "0x7C1BF90", VA = "0x187C1CF90")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void BPKOHIIBPKE([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> MKHFKNEFINC, [Out][RecRoom.DataLayer.Field(2)] bool GFIBEEDOKGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class OIDKGCBMFAG
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3888D90", Offset = "0x3887D90", VA = "0x183888D90")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void LJAAPIHGBHE([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 KIDPOMGFMKB, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 ELDDEEODOKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class MJHHLLCJLKK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3888D90", Offset = "0x3887D90", VA = "0x183888D90")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void LJAAPIHGBHE([RecRoom.DataLayer.Field(1)] CollisionMode_v1 KIDPOMGFMKB, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 ELDDEEODOKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class BNBIKCIKFCG
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CFB0", Offset = "0x7C1BFB0", VA = "0x187C1CFB0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void PNHKOGFPJAD([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 DGFMBAPHOCO, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 BDJPOFFKBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CFA0", Offset = "0x7C1BFA0", VA = "0x187C1CFA0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void LJAAPIHGBHE([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 DGFMBAPHOCO, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 BDJPOFFKBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CFA0", Offset = "0x7C1BFA0", VA = "0x187C1CFA0")]
	[RecRoom.DataLayer.UpgradeFromVersion(3)]
	public static void MFEFMJCKPNJ([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 DGFMBAPHOCO, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 BDJPOFFKBAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class HOGENOMJEAD
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3888D90", Offset = "0x3887D90", VA = "0x183888D90")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void DGDBGAPFNNM([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 KIDPOMGFMKB, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 ELDDEEODOKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class HEOBPNFENHK : DIPDKNKLPLB, PNPJOMLIBJD
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private LCNMIAJOHCH DLGICKFGCLP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override JBBHIJHGEPM AHIMDJPCPBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D590", Offset = "0x7C1C590", VA = "0x187C1D590", Slot = "14")]
		get
		{
			return default(JBBHIJHGEPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D5E0", Offset = "0x7C1C5E0", VA = "0x187C1D5E0", Slot = "16")]
	public void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CFD0", Offset = "0x7C1BFD0", VA = "0x187C1CFD0", Slot = "15")]
	protected override void BCNKFDIFGJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x29CDEA0", Offset = "0x29CCEA0", VA = "0x1829CDEA0")]
	public HEOBPNFENHK()
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
