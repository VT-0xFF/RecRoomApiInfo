using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class LOPOBLGOOBM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x783E4F0", Offset = "0x783D8F0", VA = "0x18783E4F0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void KENMNDCHIFE([RecRoom.DataLayer.Field(3)] bool JNNFLAAABHC, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 KHCEBCMPDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x35C1220", Offset = "0x35C0620", VA = "0x1835C1220")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void LKCMCANLIPC([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 KDKMHDIGKBK, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 DJPIDGMMMOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class HIOFLHOHMDL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x783E4C0", Offset = "0x783D8C0", VA = "0x18783E4C0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void GGGEFMCPPIA([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> CODPILFJFBC, [Out][RecRoom.DataLayer.Field(2)] bool KIALIMBPKEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class AMJDMCLGLBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x35C11F0", Offset = "0x35C05F0", VA = "0x1835C11F0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void HMNEODJOBGJ([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 IEAOMLJNJLM, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 NOOEFABFCIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class NPIAEJODGMA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x35C11F0", Offset = "0x35C05F0", VA = "0x1835C11F0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void HMNEODJOBGJ([RecRoom.DataLayer.Field(1)] CollisionMode_v1 IEAOMLJNJLM, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 NOOEFABFCIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class LGLMPFOGEML
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x783E4E0", Offset = "0x783D8E0", VA = "0x18783E4E0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void NHNPOEBEIGN([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 GCJNLMFPDOD, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 COMKHMMIAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x783E4D0", Offset = "0x783D8D0", VA = "0x18783E4D0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void HMNEODJOBGJ([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 GCJNLMFPDOD, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 COMKHMMIAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x783E4D0", Offset = "0x783D8D0", VA = "0x18783E4D0")]
	[RecRoom.DataLayer.UpgradeFromVersion(3)]
	public static void GOFKLJDAHHA([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 GCJNLMFPDOD, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 COMKHMMIAIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class KMLJKBOODLG
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x35C11F0", Offset = "0x35C05F0", VA = "0x1835C11F0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void HDCPADPCGJL([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 IEAOMLJNJLM, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 NOOEFABFCIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class FLEMNDBJKCA : NENNCPJHDEM, NOIGPCCMOKP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private ICNFPDEEJIF BBNMGAKJEEL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override GBHBOJAPDOA GFDFDHMHGGA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x783DE00", Offset = "0x783D200", VA = "0x18783DE00", Slot = "14")]
		get
		{
			return default(GBHBOJAPDOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x783E420", Offset = "0x783D820", VA = "0x18783E420", Slot = "16")]
	public void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x783DE50", Offset = "0x783D250", VA = "0x18783DE50", Slot = "15")]
	protected override void EJKDABAILNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x28ACE00", Offset = "0x28AC200", VA = "0x1828ACE00")]
	public FLEMNDBJKCA()
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
