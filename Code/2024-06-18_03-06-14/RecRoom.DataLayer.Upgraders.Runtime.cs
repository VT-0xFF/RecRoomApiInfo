using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::BBMNAEDJAJE(typeof(ContainerFlagsData))]
public static class MMCBAGPNIKE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6890F80", Offset = "0x688F980", VA = "0x186890F80")]
	[global::DJEKMOIAJPC(1)]
	public static void MEBHGNIPLFD([global::OMCHOCMMNFH(1)] FCGHOGLKKBI GHFMDPNFPBN, [Out][global::OMCHOCMMNFH(1)] FCGHOGLKKBI MEBNKOEFKDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::BBMNAEDJAJE(typeof(ObjectPolicyData))]
public static class BEDBFKLNCEG
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6890F70", Offset = "0x688F970", VA = "0x186890F70")]
	[global::DJEKMOIAJPC(2)]
	public static void PAOPNAFGBLP([global::OMCHOCMMNFH(3)] bool LKFPOOHEPAI, [Out][global::OMCHOCMMNFH(3)] PKOJBPLDAHP GBNNPAAOJAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::BBMNAEDJAJE(typeof(PersistentUserTagData))]
public static class NKCCJOPCIKP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6890F90", Offset = "0x688F990", VA = "0x186890F90")]
	[global::DJEKMOIAJPC(1)]
	public static void MBCHHNGBGAF([global::OMCHOCMMNFH(1)] FixedList32Bytes<int> JLAJKJKMAEO, [Out][global::OMCHOCMMNFH(2)] bool GHLNLCDMIEG)
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
