using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class DLJFIFKGBOO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7F62710", Offset = "0x7F60D10", VA = "0x187F62710")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void MPDIFFOKAGG([RecRoom.DataLayer.Field(3)] bool KBPPGOCDNAB, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 ENCLHPAOMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x38D2760", Offset = "0x38D0D60", VA = "0x1838D2760")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void OHMPNLCLNGP([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 DNGPJGHLFNP, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 NOJLDFBEPEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class KBENLFEMKHA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7F62740", Offset = "0x7F60D40", VA = "0x187F62740")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void APBCKMACKCI([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> FDNFPDAMLJB, [Out][RecRoom.DataLayer.Field(2)] bool FIBNABDHAGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class EOEEEANNBPI
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x38D2730", Offset = "0x38D0D30", VA = "0x1838D2730")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void JPGCIDOAICA([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 LFMKIINCPNH, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 PFPDPIHOEAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class LBDFECDIIOD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x38D2730", Offset = "0x38D0D30", VA = "0x1838D2730")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void JPGCIDOAICA([RecRoom.DataLayer.Field(1)] CollisionMode_v1 LFMKIINCPNH, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 PFPDPIHOEAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class JGANMBIPMMM
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F62720", Offset = "0x7F60D20", VA = "0x187F62720")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void DNPFMPHECGI([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 CONLMDHBFCG, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 KLLIHKGBPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F62730", Offset = "0x7F60D30", VA = "0x187F62730")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void JPGCIDOAICA([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 CONLMDHBFCG, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 KLLIHKGBPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7F62730", Offset = "0x7F60D30", VA = "0x187F62730")]
	[RecRoom.DataLayer.UpgradeFromVersion(3)]
	public static void KCFMJKKIPBM([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 CONLMDHBFCG, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 KLLIHKGBPOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class KHOJPEIJBOC
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x38D2730", Offset = "0x38D0D30", VA = "0x1838D2730")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void DEHFFGFIGMO([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 LFMKIINCPNH, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 PFPDPIHOEAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class MNOJAHMBKNL : JMEFIFNMAAM, JPODKHCGMPE
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private HNJHKDBCEOI EMIOKCEDBKA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override LHMKAIAPMBI OAAFJAHOMDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7F62750", Offset = "0x7F60D50", VA = "0x187F62750", Slot = "14")]
		get
		{
			return default(LHMKAIAPMBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F627A0", Offset = "0x7F60DA0", VA = "0x187F627A0", Slot = "16")]
	public void InitReferences(MGPNAOEDNIM KIIAJJAGEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7F627F0", Offset = "0x7F60DF0", VA = "0x187F627F0", Slot = "15")]
	protected override void KNOANLOJGPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D780", Offset = "0x2C1BD80", VA = "0x182C1D780")]
	public MNOJAHMBKNL()
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
