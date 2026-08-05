using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::BKGOECAJGGA(typeof(ContainerFlagsData))]
public static class BOFEBCMPBGK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60FAA20", Offset = "0x60F9C20", VA = "0x1860FAA20")]
	[global::JGNGEMHMDNP(1)]
	public static void ELDGKGHBGFN([global::JEJFDDMFHFN(1)] BPEECEOEIPM AHOMAGFPFAB, [Out][global::JEJFDDMFHFN(1)] BPEECEOEIPM AHIDOBJCKGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::BKGOECAJGGA(typeof(ObjectPolicyData))]
public static class DOOBIDIJKLO
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60FAA30", Offset = "0x60F9C30", VA = "0x1860FAA30")]
	[global::JGNGEMHMDNP(2)]
	public static void CAHJJLCKIGH([global::JEJFDDMFHFN(3)] bool KMDIAELEJPH, [Out][global::JEJFDDMFHFN(3)] OBPHPMOBDFL PCHAAMDAAJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::BKGOECAJGGA(typeof(PersistentUserTagData))]
public static class LOPKEPAJEBL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60FAA40", Offset = "0x60F9C40", VA = "0x1860FAA40")]
	[global::JGNGEMHMDNP(1)]
	public static void CKOBPNHAKGK([global::JEJFDDMFHFN(1)] FixedList32Bytes<int> GIDCLHMBPPO, [Out][global::JEJFDDMFHFN(2)] bool LPJJEKIAHHI)
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
