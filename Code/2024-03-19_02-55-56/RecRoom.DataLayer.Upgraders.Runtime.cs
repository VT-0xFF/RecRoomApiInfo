using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::EBPFPHOCGNB(typeof(ContainerFlagsData))]
public static class IIDHLDGDMCP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6156940", Offset = "0x6155940", VA = "0x186156940")]
	[global::KEAEAOFFDEJ(1)]
	public static void AJJLEHDKGKH([global::DJMGDJBDIKC(1)] KPMECJNFOCC IDPLNLCDKNF, [Out][global::DJMGDJBDIKC(1)] KPMECJNFOCC AHJPCACGNGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::EBPFPHOCGNB(typeof(ObjectPolicyData))]
public static class LKBMPPIOKCH
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6156950", Offset = "0x6155950", VA = "0x186156950")]
	[global::KEAEAOFFDEJ(2)]
	public static void KPDHNAICIIO([global::DJMGDJBDIKC(3)] bool IAAAKMMOKNC, [Out][global::DJMGDJBDIKC(3)] EPPCAEDGIAE LKCCHOABBBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::EBPFPHOCGNB(typeof(PersistentUserTagData))]
public static class FOOPFFMLHEH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6156930", Offset = "0x6155930", VA = "0x186156930")]
	[global::KEAEAOFFDEJ(1)]
	public static void LACEIKOEHHA([global::DJMGDJBDIKC(1)] FixedList32Bytes<int> APDCHDEHAEA, [Out][global::DJMGDJBDIKC(2)] bool INDOGOFBAEF)
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
