using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class CIOOMLDODLE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7AE1490", Offset = "0x7ADFC90", VA = "0x187AE1490")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void IBBNFCCNHJH([RecRoom.DataLayer.Field(3)] bool AMJEFJPHHNG, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 ENMPGGCMLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x360E300", Offset = "0x360CB00", VA = "0x18360E300")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void GKBHAIPLKBH([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 ACFACIOKNNI, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 EINBIEMJACC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class CIIODNHMFIF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7AE1480", Offset = "0x7ADFC80", VA = "0x187AE1480")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void DFPKIBFMHDN([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> CHKOHMIIEJH, [Out][RecRoom.DataLayer.Field(2)] bool MBDEAMEEANK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class ILHKJFJKLOL
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x360E2D0", Offset = "0x360CAD0", VA = "0x18360E2D0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void OPAOLCALALI([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 GGBFBJAOFOK, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 EFGFBKMBCFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class KPMNELHMHOH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x360E2D0", Offset = "0x360CAD0", VA = "0x18360E2D0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void OPAOLCALALI([RecRoom.DataLayer.Field(1)] CollisionMode_v1 GGBFBJAOFOK, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 EFGFBKMBCFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class LGGLFBLNECA
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7AE1B50", Offset = "0x7AE0350", VA = "0x187AE1B50")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void LIJAOAJKOKH([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 CHHLNEKFKMD, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 GIJKNKGEBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7AE1B60", Offset = "0x7AE0360", VA = "0x187AE1B60")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void OPAOLCALALI([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 CHHLNEKFKMD, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 GIJKNKGEBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7AE1B60", Offset = "0x7AE0360", VA = "0x187AE1B60")]
	[RecRoom.DataLayer.UpgradeFromVersion(3)]
	public static void PJAMECIADLP([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 CHHLNEKFKMD, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 GIJKNKGEBID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class LOGPCFMBEOD
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x360E2D0", Offset = "0x360CAD0", VA = "0x18360E2D0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void CBHPNOOGOCB([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 GGBFBJAOFOK, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 EFGFBKMBCFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class DPDPACEEFNH : LPANKDMAOHE, JOGFKELELCN
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private AOMAGPGICLH PMNGAGAKNJK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override LLPKKNNAIAE BAOGIJBMDME
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7AE1AB0", Offset = "0x7AE02B0", VA = "0x187AE1AB0", Slot = "14")]
		get
		{
			return default(LLPKKNNAIAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7AE1A60", Offset = "0x7AE0260", VA = "0x187AE1A60", Slot = "16")]
	public void InitReferences(FOMOPIDDKEF OLDEEBBAPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7AE14A0", Offset = "0x7ADFCA0", VA = "0x187AE14A0", Slot = "15")]
	protected override void COLBOKBEFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x299DFD0", Offset = "0x299C7D0", VA = "0x18299DFD0")]
	public DPDPACEEFNH()
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
