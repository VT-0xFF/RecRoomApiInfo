using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::ENEMLGJEOMA(typeof(ContainerFlagsData))]
public static class BHCFCOLKEOK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60EE360", Offset = "0x60ECF60", VA = "0x1860EE360")]
	[global::IFCLCMEJEAB(1)]
	public static void CAOBOFFGJIG([global::LFHHNDGABIE(1)] GEIOBDNIBFI JCIEHGJJGOP, [Out][global::LFHHNDGABIE(1)] GEIOBDNIBFI FAJACDCBBJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::ENEMLGJEOMA(typeof(ObjectPolicyData))]
public static class FCIGOBKDFDG
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60EE370", Offset = "0x60ECF70", VA = "0x1860EE370")]
	[global::IFCLCMEJEAB(2)]
	public static void NOMNLMFFNJJ([global::LFHHNDGABIE(3)] bool ODJECGOJJPM, [Out][global::LFHHNDGABIE(3)] ABHMDJOONNA OGPBDNPMEAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::ENEMLGJEOMA(typeof(PersistentUserTagData))]
public static class KELGFMNOOAL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60EE380", Offset = "0x60ECF80", VA = "0x1860EE380")]
	[global::IFCLCMEJEAB(1)]
	public static void FMBBGPJJINK([global::LFHHNDGABIE(1)] FixedList32Bytes<int> PJIFCCMNNGH, [Out][global::LFHHNDGABIE(2)] bool IDNCLHHMBLC)
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
