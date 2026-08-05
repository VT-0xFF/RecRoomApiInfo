using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class BOHBFJLCGNN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7D01D10", Offset = "0x7D00710", VA = "0x187D01D10")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void FPKKIDJAFPD([RecRoom.DataLayer.Field(3)] bool LCFOCOFDFLM, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 FIKPCOCNDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3ABFC60", Offset = "0x3ABE660", VA = "0x183ABFC60")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void JBJFCFAMCAD([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 NGEPLLLPPCI, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 KCNPBOEBOJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class DEHHOAJEGHB
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7D01D20", Offset = "0x7D00720", VA = "0x187D01D20")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void FPICLAFCGBC([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> FHMNFJFMOMK, [Out][RecRoom.DataLayer.Field(2)] bool KMIFKJNGBHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class LGEAEFNLBOE
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3ABFC30", Offset = "0x3ABE630", VA = "0x183ABFC30")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void FAKLFCKGLFN([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 AJHCLHGHINB, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 GMGNNFDOICN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class MPJOALDHDHB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3ABFC30", Offset = "0x3ABE630", VA = "0x183ABFC30")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void FAKLFCKGLFN([RecRoom.DataLayer.Field(1)] CollisionMode_v1 AJHCLHGHINB, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 GMGNNFDOICN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class KPFNMJHEOCB
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7D01D40", Offset = "0x7D00740", VA = "0x187D01D40")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void KPFGEDLHMPD([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 OECGHOPENJD, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 OHPPKOCAONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7D01D30", Offset = "0x7D00730", VA = "0x187D01D30")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void FAKLFCKGLFN([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 OECGHOPENJD, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 OHPPKOCAONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7D01D30", Offset = "0x7D00730", VA = "0x187D01D30")]
	[RecRoom.DataLayer.UpgradeFromVersion(3)]
	public static void OMAMDPCKAMH([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 OECGHOPENJD, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 OHPPKOCAONE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class MKPNJELHOCI
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3ABFC30", Offset = "0x3ABE630", VA = "0x183ABFC30")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void GBCBGLLMCKD([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 AJHCLHGHINB, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 GMGNNFDOICN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class MCNFFEDDPGG : DEKEAIHHHBC, BOEGHMMFADM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private JJDJPBGKODD BIJMCPLLCFP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override COJJKFBGGKB NLLEOCMFOCP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7D01D50", Offset = "0x7D00750", VA = "0x187D01D50", Slot = "14")]
		get
		{
			return default(COJJKFBGGKB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D01DA0", Offset = "0x7D007A0", VA = "0x187D01DA0", Slot = "16")]
	public void InitReferences(FKFJNEKJHIE CCGCAONCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7D01DF0", Offset = "0x7D007F0", VA = "0x187D01DF0", Slot = "15")]
	protected override void PGCLMIIADMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2B76FB0", Offset = "0x2B759B0", VA = "0x182B76FB0")]
	public MCNFFEDDPGG()
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
