using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[RecRoom.DataLayer.Upgrader(typeof(ContainerFlagsData))]
public static class COKAOJPCPBD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C04C80", Offset = "0x6C03880", VA = "0x186C04C80")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void CDMMPJHDNPO([RecRoom.DataLayer.Field(1)] NCAHLIGACJD GAIMOFKMHNB, [Out][RecRoom.DataLayer.Field(1)] NCAHLIGACJD ANIMBJACOMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RecRoom.DataLayer.Upgrader(typeof(ObjectPolicyData))]
public static class DEHCNDPOOMB
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C04C90", Offset = "0x6C03890", VA = "0x186C04C90")]
	[RecRoom.DataLayer.UpgradeFromVersion(2)]
	public static void CFGGHGBLMFH([RecRoom.DataLayer.Field(3)] bool DPFCOKKIKLK, [Out][RecRoom.DataLayer.Field(3)] IDFJCJHJMNO KCDIMIFJDPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RecRoom.DataLayer.Upgrader(typeof(PersistentUserTagData))]
public static class BDJGIJMGFAK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C04C70", Offset = "0x6C03870", VA = "0x186C04C70")]
	[RecRoom.DataLayer.UpgradeFromVersion(1)]
	public static void FJDLFNDBIFC([RecRoom.DataLayer.Field(1)] FixedList32Bytes<int> IONNJJHBKGH, [Out][RecRoom.DataLayer.Field(2)] bool OCLFMKAABDN)
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
