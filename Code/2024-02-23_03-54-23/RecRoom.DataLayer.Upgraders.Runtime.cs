using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::KDPHPCMIDME(typeof(ContainerFlagsData))]
public static class NBHKGNLPKDE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5F8EC80", Offset = "0x5F8D680", VA = "0x185F8EC80")]
	[global::DKHMPMJECHB(1)]
	public static void NGPHHLLKEHN([global::MBLAPLINKNC(1)] AAJBBPEHLCO MHGGIOGEOAF, [Out][global::MBLAPLINKNC(1)] AAJBBPEHLCO DIOFNBNIFCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::KDPHPCMIDME(typeof(ObjectPolicyData))]
public static class MDHCJBFCAGE
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5F8EC70", Offset = "0x5F8D670", VA = "0x185F8EC70")]
	[global::DKHMPMJECHB(2)]
	public static void NPOFDCJKKJD([global::MBLAPLINKNC(3)] bool GOAOFKHBNAP, [Out][global::MBLAPLINKNC(3)] HPKPKKLNNBD HPGFBABPMCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::KDPHPCMIDME(typeof(PersistentUserTagData))]
public static class HIHEMLGGLPC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5F8EC60", Offset = "0x5F8D660", VA = "0x185F8EC60")]
	[global::DKHMPMJECHB(1)]
	public static void NKOGLGBMCML([global::MBLAPLINKNC(1)] FixedList32Bytes<int> KPHFHOMDNLN, [Out][global::MBLAPLINKNC(2)] bool HOLKOEOPEAA)
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
