using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class GNGACAMNEIL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x84B1690", Offset = "0x84AFC90", VA = "0x1884B1690")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void BFFOFKJGHHF([RecRoom.DataLayer.Field(3)] bool IDAMJKMLHON, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 ANBGOGICGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3DBBAE0", Offset = "0x3DBA0E0", VA = "0x183DBBAE0")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void FIGOPKJCMMG([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 NANNGIHMHLM, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 MKOBLEPGEHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class CLAFMMLFKDE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x84B1680", Offset = "0x84AFC80", VA = "0x1884B1680")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void FOBJKBNDLBE([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> GFELOCNKDDG, [Out][RecRoom.DataLayer.Field(2)] bool CIAJIGJGHOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class LCJMAJKMHAK
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3DBBAB0", Offset = "0x3DBA0B0", VA = "0x183DBBAB0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void IKOOKNIEFCO([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 PPEFJKBNOEP, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 DNPKCGAKHLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class NGJBLAIGFBP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3DBBAB0", Offset = "0x3DBA0B0", VA = "0x183DBBAB0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void IKOOKNIEFCO([RecRoom.DataLayer.Field(1)] CollisionMode_v1 PPEFJKBNOEP, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 DNPKCGAKHLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class MNDJFDMLIGC
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x84B16B0", Offset = "0x84AFCB0", VA = "0x1884B16B0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void JHIPGILEIPB([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 PIMLGHGJENJ, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 MMMKNBAAOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x84B16A0", Offset = "0x84AFCA0", VA = "0x1884B16A0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void IKOOKNIEFCO([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 PIMLGHGJENJ, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 MMMKNBAAOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x84B16A0", Offset = "0x84AFCA0", VA = "0x1884B16A0")]
	[RecRoom.DataLayer.UpgradeFromVersion(3)]
	public static void GPBFCCEBNMH([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 PIMLGHGJENJ, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 MMMKNBAAOEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class PAEICGMDBGE
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3DBBAB0", Offset = "0x3DBA0B0", VA = "0x183DBBAB0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void OMGIFFIDEAL([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 PPEFJKBNOEP, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 DNPKCGAKHLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class PIFAEFIPCLG : GAEPCFMEMPO, MOLBKPMFEIO
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EAIBHHLGAGE PJALMJHKKHI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override IPHNFELODMJ EANLMHBELEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84B1CE0", Offset = "0x84B02E0", VA = "0x1884B1CE0", Slot = "14")]
		get
		{
			return default(IPHNFELODMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84B16C0", Offset = "0x84AFCC0", VA = "0x1884B16C0", Slot = "16")]
	public void InitReferences(CNPFBIMHGJN KADNKCJPKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x84B1710", Offset = "0x84AFD10", VA = "0x1884B1710", Slot = "15")]
	protected override void LMBOGBMNCII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2E01C10", Offset = "0x2E00210", VA = "0x182E01C10")]
	public PIFAEFIPCLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[RecRoom.DataLayer.Upgrader(typeof(TerrainWaterData))]
public static class JEBHOINKKDD
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3DBBAB0", Offset = "0x3DBA0B0", VA = "0x183DBBAB0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void ANBLCAJHNCL([RecRoom.DataLayer.Field(7)] TerrainWaterMaterial_v1 NANNGIHMHLM, [Out][RecRoom.DataLayer.Field(7)] TerrainWaterMaterial_v2 OIAKIODILPA)
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
