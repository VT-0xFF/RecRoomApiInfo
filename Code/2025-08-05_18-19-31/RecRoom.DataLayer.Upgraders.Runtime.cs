using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class ADKGKACBAAN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x825ECF0", Offset = "0x825E0F0", VA = "0x18825ECF0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void CGFKJKPEHJA([RecRoom.DataLayer.Field(3)] bool NLHMDEPINLK, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 DPALHGCDOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3D56680", Offset = "0x3D55A80", VA = "0x183D56680")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void AELLDPECHGN([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 AANJFBMPELD, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 NFNOLGJEOIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class CIALFBFOMPH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x825ED00", Offset = "0x825E100", VA = "0x18825ED00")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void ICCDDOBNLFF([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> AOIOCLJAONJ, [Out][RecRoom.DataLayer.Field(2)] bool BNALMLEPAGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class LCLEBGKJJAE
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3D56650", Offset = "0x3D55A50", VA = "0x183D56650")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void EKOAMLAPHHG([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 BEOBAPANJHO, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 MBAOOPBKPLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class JLJLLKFBDPG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3D56650", Offset = "0x3D55A50", VA = "0x183D56650")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void EKOAMLAPHHG([RecRoom.DataLayer.Field(1)] CollisionMode_v1 BEOBAPANJHO, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 MBAOOPBKPLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class KDIBAAPKBJM
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x825F3D0", Offset = "0x825E7D0", VA = "0x18825F3D0")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void KLOLFGEBHDO([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 BJEGEONHPKK, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 CDGIKMAIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x825F3C0", Offset = "0x825E7C0", VA = "0x18825F3C0")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void EKOAMLAPHHG([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 BJEGEONHPKK, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 CDGIKMAIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x825F3C0", Offset = "0x825E7C0", VA = "0x18825F3C0")]
	[RecRoom.DataLayer.UpgradeFromVersion(3)]
	public static void LCMBBOJILCN([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 BJEGEONHPKK, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 CDGIKMAIPOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class FCFNEBHCADH
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3D56650", Offset = "0x3D55A50", VA = "0x183D56650")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void KGINAPMLJIH([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 BEOBAPANJHO, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 MBAOOPBKPLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class FOIEBONDLOF : EIIFKDGBDLP, FMPNPCDDCKO
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private KOBELPGPMPF DMNKOAGMMBA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override AKNCNLDICPO GJFBEGANDPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x825ED10", Offset = "0x825E110", VA = "0x18825ED10", Slot = "14")]
		get
		{
			return default(AKNCNLDICPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x825F320", Offset = "0x825E720", VA = "0x18825F320", Slot = "16")]
	public void InitReferences(BBKOKELKFDM HPIMCEEIPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x825ED60", Offset = "0x825E160", VA = "0x18825ED60", Slot = "15")]
	protected override void GMCBLONFMDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2D2C0C0", Offset = "0x2D2B4C0", VA = "0x182D2C0C0")]
	public FOIEBONDLOF()
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
