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
	[Cpp2IlInjected.Address(RVA = "0x788BC40", Offset = "0x788B040", VA = "0x18788BC40")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void KENMNDCHIFE([RecRoom.DataLayer.Field(3)] bool JNNFLAAABHC, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 KHCEBCMPDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x35D74D0", Offset = "0x35D68D0", VA = "0x1835D74D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x788BC10", Offset = "0x788B010", VA = "0x18788BC10")]
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
	[Cpp2IlInjected.Address(RVA = "0x35D74A0", Offset = "0x35D68A0", VA = "0x1835D74A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x35D74A0", Offset = "0x35D68A0", VA = "0x1835D74A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x788BC30", Offset = "0x788B030", VA = "0x18788BC30")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void NHNPOEBEIGN([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 GCJNLMFPDOD, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 COMKHMMIAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x788BC20", Offset = "0x788B020", VA = "0x18788BC20")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void HMNEODJOBGJ([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 GCJNLMFPDOD, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 COMKHMMIAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x788BC20", Offset = "0x788B020", VA = "0x18788BC20")]
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
	[Cpp2IlInjected.Address(RVA = "0x35D74A0", Offset = "0x35D68A0", VA = "0x1835D74A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x788B560", Offset = "0x788A960", VA = "0x18788B560", Slot = "14")]
		get
		{
			return default(GBHBOJAPDOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x788BB70", Offset = "0x788AF70", VA = "0x18788BB70", Slot = "16")]
	public void InitReferences(BJMEEALALCJ BJPDKNNBBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x788B5B0", Offset = "0x788A9B0", VA = "0x18788B5B0", Slot = "15")]
	protected override void EJKDABAILNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x28ADC00", Offset = "0x28AD000", VA = "0x1828ADC00")]
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
