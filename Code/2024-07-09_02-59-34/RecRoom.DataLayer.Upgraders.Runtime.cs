using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::MKBEMHNFMKO(typeof(ContainerFlagsData))]
public static class GGNLIJNDINF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6995A30", Offset = "0x6994630", VA = "0x186995A30")]
	[global::ALPOEOPBPNO(1)]
	public static void IPAMJAOCKOB([global::MFMEPIAMLKJ(1)] DHKMNICNAEB PFMPKDNHGJP, [Out][global::MFMEPIAMLKJ(1)] DHKMNICNAEB FNPIGNHLEPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::MKBEMHNFMKO(typeof(ObjectPolicyData))]
public static class JJHEJMKMJAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6995A40", Offset = "0x6994640", VA = "0x186995A40")]
	[global::ALPOEOPBPNO(2)]
	public static void AOBFIAPHKFJ([global::MFMEPIAMLKJ(3)] bool GGOFCANILIM, [Out][global::MFMEPIAMLKJ(3)] AMDHMCDLIKB DKIOAOHDADG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::MKBEMHNFMKO(typeof(PersistentUserTagData))]
public static class NNDGDJPBHIE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6995A50", Offset = "0x6994650", VA = "0x186995A50")]
	[global::ALPOEOPBPNO(1)]
	public static void AOHCJADGCKN([global::MFMEPIAMLKJ(1)] FixedList32Bytes<int> PJNBHAEFPPO, [Out][global::MFMEPIAMLKJ(2)] bool ADNJFECCHEC)
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
