using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class MKENJENGCKP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x75B4B60", Offset = "0x75B3D60", VA = "0x1875B4B60")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void MEDNOBEOHMB([RecRoom.DataLayer.Field(3)] bool JMKLFBBOLGO, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 BCFKGGKKKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3494550", Offset = "0x3493750", VA = "0x183494550")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void PAJDHNAEIMF([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 GNICDIGBMGK, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 AAHFDFLGNMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class NEKOIEHJDFP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x75B4B70", Offset = "0x75B3D70", VA = "0x1875B4B70")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void NONCGFHHCKI([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> ANPAKJGAMFF, [Out][RecRoom.DataLayer.Field(2)] bool AOGKCBKAHCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class IMFALEBCELH
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3494520", Offset = "0x3493720", VA = "0x183494520")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void EGHPPAIJHIG([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 HDPIMFNJLMN, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 NHGKIMEFJKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class MFNLCBGCADA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3494520", Offset = "0x3493720", VA = "0x183494520")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void EGHPPAIJHIG([RecRoom.DataLayer.Field(1)] CollisionMode_v1 HDPIMFNJLMN, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 NHGKIMEFJKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class BMAFEBPEFJP
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x75B44A0", Offset = "0x75B36A0", VA = "0x1875B44A0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void ELLJAFNIGNK([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 JFHMADJFCAM, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 GKKHHAEOPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x75B4490", Offset = "0x75B3690", VA = "0x1875B4490")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void EGHPPAIJHIG([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 JFHMADJFCAM, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 GKKHHAEOPNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class MGCAEPFDOPI
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3494520", Offset = "0x3493720", VA = "0x183494520")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void IJHAAPIMNAH([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 HDPIMFNJLMN, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 NHGKIMEFJKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class GLCOEEKIFMA : KFGKGKONJFM, ANAKBJKCMDF
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private KBGIJHKKNPO IFIGLIMLAJB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override PBBCGFNIILA IPKFDHIOJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x75B44B0", Offset = "0x75B36B0", VA = "0x1875B44B0", Slot = "14")]
		get
		{
			return default(PBBCGFNIILA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x75B4AC0", Offset = "0x75B3CC0", VA = "0x1875B4AC0", Slot = "16")]
	public void InitReferences(DBCOBCEEMIL LGCLECJNKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x75B4500", Offset = "0x75B3700", VA = "0x1875B4500", Slot = "15")]
	protected override void GLMEEKBEFCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x27EDC20", Offset = "0x27ECE20", VA = "0x1827EDC20")]
	public GLCOEEKIFMA()
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
