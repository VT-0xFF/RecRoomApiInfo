using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class BEMKDMLLBKA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7D80860", Offset = "0x7D7F460", VA = "0x187D80860")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void OMLDKCEBMMH([RecRoom.DataLayer.Field(3)] bool OHIPNFIHKCI, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 GEFKHBLJENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3915DB0", Offset = "0x39149B0", VA = "0x183915DB0")]
	[RecRoom.DataLayer.UpgradeFromVersion(5)]
	public static void ICKLGGLKPJD([RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v1 DMHGCKEGLMH, [Out][RecRoom.DataLayer.Field(3)] ObjectPolicyUserConfigurableFlags_v2 PIFBFMMDFPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class FHBHIHDAKAL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7D80870", Offset = "0x7D7F470", VA = "0x187D80870")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void ELOEPBINBOG([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> FHDDDNNLNCN, [Out][RecRoom.DataLayer.Field(2)] bool FPNNMLFAKPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionLayerData))]
public static class EPDMGNKJAGO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3915D80", Offset = "0x3914980", VA = "0x183915D80")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void DEGLEMBKLCL([RecRoom.DataLayer.Field(1)] ContainerCollisionLayerEnum_v1 ENEAIMANIIG, [Out][RecRoom.DataLayer.Field(1)] CollisionLayerEnum_v2 JAKICABDOHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelCollisionModeData))]
public static class LGKOEMFDIHK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3915D80", Offset = "0x3914980", VA = "0x183915D80")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void DEGLEMBKLCL([RecRoom.DataLayer.Field(1)] CollisionMode_v1 ENEAIMANIIG, [Out][RecRoom.DataLayer.Field(1)] CollisionMode_v2 JAKICABDOHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelFlagsData))]
public static class INKILCILIBI
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7D80880", Offset = "0x7D7F480", VA = "0x187D80880")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void BINAKODIFMI([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 ABDLANPPFKC, [Out][RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 OFKJEKPEPJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7D80890", Offset = "0x7D7F490", VA = "0x187D80890")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void DEGLEMBKLCL([RecRoom.DataLayer.Field(1)] ContainerEnumFlags_v1 ABDLANPPFKC, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 OFKJEKPEPJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7D80890", Offset = "0x7D7F490", VA = "0x187D80890")]
	[RecRoom.DataLayer.UpgradeFromVersion(3)]
	public static void OJPMIMPDAAA([RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v2 ABDLANPPFKC, [Out][RecRoom.DataLayer.Field(1)] PhysicsModelEnumFlags_v3 OFKJEKPEPJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[RecRoom.DataLayer.Upgrader(typeof(PhysicsModelGrabbableModeData))]
public static class LNDJEBABKIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3915D80", Offset = "0x3914980", VA = "0x183915D80")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void JAOCBKAPOCB([RecRoom.DataLayer.Field(1)] GrabbableMode_v1 ENEAIMANIIG, [Out][RecRoom.DataLayer.Field(1)] GrabbableMode_v2 JAKICABDOHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[RecRoom.DataLayer.CustomUpgradeSystem("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
public class KKKBGHMPNFL : AIBAPDFOPFD, OMNICACBHFO
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IGILMMBBECJ HOABPANFHMK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	protected override JPIBGNDAFKP HOEGMFFOKBK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7D80E60", Offset = "0x7D7FA60", VA = "0x187D80E60", Slot = "14")]
		get
		{
			return default(JPIBGNDAFKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D80EB0", Offset = "0x7D7FAB0", VA = "0x187D80EB0", Slot = "16")]
	public void InitReferences(OLKHLOEBPJH PFNBNJEHPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7D808A0", Offset = "0x7D7F4A0", VA = "0x187D808A0", Slot = "15")]
	protected override void DFPLLHNGAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2BB2390", Offset = "0x2BB0F90", VA = "0x182BB2390")]
	public KKKBGHMPNFL()
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
