using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class FKHKMKAJNAI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x78C3B30", Offset = "0x78C2530", VA = "0x1878C3B30")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void HOEIGDNJJEI([RecRoom.DataLayer.Field(3)] bool EKNNPLBFAEE, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 BNNEEGIINDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3820F20", Offset = "0x381F920", VA = "0x183820F20")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void IELEPFLAANM([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 OCDJAMBMLIK, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 IDFOBDFLLCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class ILBLEPCEBNL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x78C4210", Offset = "0x78C2C10", VA = "0x1878C4210")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void NAMAGCMGMMD([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> AGMGBCKIJCO, [Out][RecRoom.DataLayer.Field(2)] bool FONADPDFEMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class KLLNKDDELGG
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3820EF0", Offset = "0x381F8F0", VA = "0x183820EF0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void IKOBNBIGDPA([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 KKMIKMKCMKE, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 GNMBGILIMLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class PKHBKAJLAGK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3820EF0", Offset = "0x381F8F0", VA = "0x183820EF0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void IKOBNBIGDPA([RecRoom.DataLayer.Field(1)] CollisionMode_v1 KKMIKMKCMKE, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 GNMBGILIMLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class GADJHLNCGHD
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x78C3B50", Offset = "0x78C2550", VA = "0x1878C3B50")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void PBOEABGKDEC([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 IJGPJNIDLPO, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 GDINIEMKFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x78C3B40", Offset = "0x78C2540", VA = "0x1878C3B40")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void IKOBNBIGDPA([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 IJGPJNIDLPO, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 GDINIEMKFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x78C3B40", Offset = "0x78C2540", VA = "0x1878C3B40")]
	[RecRoom.DataLayer.UpgradeFromVersion(3)]
	public static void IMHJEDCHGOG([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 IJGPJNIDLPO, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 GDINIEMKFPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class JABLKMLACHO
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3820EF0", Offset = "0x381F8F0", VA = "0x183820EF0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void PJGJMNMGEAL([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 KKMIKMKCMKE, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 GNMBGILIMLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class HJBLPAEBOLG : DEKKAHDLANI, KFPIMHBKPFA
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private DJCFMDOMDNB ABLJJDDCNPO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override LMPJBEBLCLM HIMKLMLGBHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x78C3B60", Offset = "0x78C2560", VA = "0x1878C3B60", Slot = "14")]
		get
		{
			return default(LMPJBEBLCLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x78C4170", Offset = "0x78C2B70", VA = "0x1878C4170", Slot = "16")]
	public void InitReferences(LBHNIGEPODB GNJMKKKJHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x78C3BB0", Offset = "0x78C25B0", VA = "0x1878C3BB0", Slot = "15")]
	protected override void FBONMCAOKHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x28D32E0", Offset = "0x28D1CE0", VA = "0x1828D32E0")]
	public HJBLPAEBOLG()
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
