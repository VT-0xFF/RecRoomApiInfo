using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::EOEJHMIPHFJ(typeof(ContainerFlagsData))]
public static class NDFGLBNDOHL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6E6A3C0", Offset = "0x6E693C0", VA = "0x186E6A3C0")]
	[global::EBBNPCFIHLD(1)]
	public static void FMAFAOPGEDJ([global::BFHHOAIOEJG(1)] KGMCLDKIBHB MCFANDODNCN, [Out][global::BFHHOAIOEJG(1)] KGMCLDKIBHB LEMHCCOLNGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::EOEJHMIPHFJ(typeof(ObjectPolicyData))]
public static class NNFJGHBDCOL
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6E6A3D0", Offset = "0x6E693D0", VA = "0x186E6A3D0")]
	[global::EBBNPCFIHLD(2)]
	public static void KDGMGCFCDCN([global::BFHHOAIOEJG(3)] bool LICIPGDIJLH, [Out][global::BFHHOAIOEJG(3)] OPNAOIHLHJL IECLEDMOCFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::EOEJHMIPHFJ(typeof(PersistentUserTagData))]
public static class EPHKKHOPAJD
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6E6A3B0", Offset = "0x6E693B0", VA = "0x186E6A3B0")]
	[global::EBBNPCFIHLD(1)]
	public static void ACAHKGCLAKM([global::BFHHOAIOEJG(1)] FixedList32Bytes<int> HLIJPJKOGAE, [Out][global::BFHHOAIOEJG(2)] bool CPNLIAIBFAP)
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
