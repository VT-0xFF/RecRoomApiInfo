using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class IBPFHOENINO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E240", Offset = "0x7C0D440", VA = "0x187C0E240")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void DNFIBLDAMIK([RecRoom.DataLayer.Field(3)] bool FLMPPFFPHMM, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 FFMDBMBLMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3AC3700", Offset = "0x3AC2900", VA = "0x183AC3700")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void JMDHJNKDELC([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 MKLGNKECLPO, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 PPABCIAKENC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class IMGPKAGBPFD
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E250", Offset = "0x7C0D450", VA = "0x187C0E250")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void MNADMEDECFN([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> OECAECFBJIG, [Out][RecRoom.DataLayer.Field(2)] bool MCKGCCKLJJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class PECAAOFEABN
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3AC36D0", Offset = "0x3AC28D0", VA = "0x183AC36D0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void MHAOOEAADPF([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 LMDCFNDMKMH, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 MCOCJMBCCJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class DPGAEJNCFLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3AC36D0", Offset = "0x3AC28D0", VA = "0x183AC36D0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void MHAOOEAADPF([RecRoom.DataLayer.Field(1)] CollisionMode_v1 LMDCFNDMKMH, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 MCOCJMBCCJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class OAGLGHKHPIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E920", Offset = "0x7C0DB20", VA = "0x187C0E920")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void OJIEBEHFOHC([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 PJJKIIOIEEP, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 OGOLLMADKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E910", Offset = "0x7C0DB10", VA = "0x187C0E910")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void MHAOOEAADPF([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 PJJKIIOIEEP, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 OGOLLMADKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E910", Offset = "0x7C0DB10", VA = "0x187C0E910")]
	[RecRoom.DataLayer.UpgradeFromVersion(3)]
	public static void DMBEJFDEOHN([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 PJJKIIOIEEP, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 OGOLLMADKLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class DFAGCOLPPBK
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3AC36D0", Offset = "0x3AC28D0", VA = "0x183AC36D0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void LAEPBLJBIHG([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 LMDCFNDMKMH, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 MCOCJMBCCJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class JLCIPBGKLPO : AOFENJANFGA, HGIOMKPLONA
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly KEPOMIIOHBM EBHKLAMEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private DKDGOHEOKAK CGNJEGDEALJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override KEPOMIIOHBM AODHEIHGBPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C0E260", Offset = "0x7C0D460", VA = "0x187C0E260", Slot = "14")]
		get
		{
			return default(KEPOMIIOHBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E2B0", Offset = "0x7C0D4B0", VA = "0x187C0E2B0", Slot = "16")]
	public void InitReferences(EENCHNOCEIL BNPCDJLAAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E300", Offset = "0x7C0D500", VA = "0x187C0E300", Slot = "15")]
	protected override void PHOAAHOHMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2B24DC0", Offset = "0x2B23FC0", VA = "0x182B24DC0")]
	public JLCIPBGKLPO()
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
