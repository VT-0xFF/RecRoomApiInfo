using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::KDLFMKFJDND(typeof(ContainerFlagsData))]
public static class KCFCELKFJCP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69CBF70", Offset = "0x69CA570", VA = "0x1869CBF70")]
	[global::DKLNGCPBMFH(1)]
	public static void PNEFAGGCHGN([global::DOHEHJPPEEF(1)] DGLLELHCEGN LMGENLCEKLK, [Out][global::DOHEHJPPEEF(1)] DGLLELHCEGN DBFKNMPOJCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::KDLFMKFJDND(typeof(ObjectPolicyData))]
public static class KCIJNMNBJHH
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69CBF80", Offset = "0x69CA580", VA = "0x1869CBF80")]
	[global::DKLNGCPBMFH(2)]
	public static void KAENHCCKNID([global::DOHEHJPPEEF(3)] bool KCJBDPMDMAE, [Out][global::DOHEHJPPEEF(3)] KBPHFEOEKMF MCGGLIKAALP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::KDLFMKFJDND(typeof(PersistentUserTagData))]
public static class FHHHJHAJEOH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69CBF60", Offset = "0x69CA560", VA = "0x1869CBF60")]
	[global::DKLNGCPBMFH(1)]
	public static void NMJONEKJMAK([global::DOHEHJPPEEF(1)] FixedList32Bytes<int> FGPDHFALOFH, [Out][global::DOHEHJPPEEF(2)] bool PIEIEECKIBE)
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
