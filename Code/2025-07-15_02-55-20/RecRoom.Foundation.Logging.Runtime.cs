using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct GMMMPEFMCBF
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8113280", Offset = "0x8111E80", VA = "0x188113280")]
	public static GMMMPEFMCBF KDDDGPNBGLG(PEOHNMCPNIJ GDLIBGFAMED)
	{
		return default(GMMMPEFMCBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8113360", Offset = "0x8111F60", VA = "0x188113360")]
	public GMMMPEFMCBF(PEOHNMCPNIJ GDLIBGFAMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x81132A0", Offset = "0x8111EA0", VA = "0x1881132A0")]
	public void KNOCPKMAFOM([In] FixedString128Bytes JIBDMFNCFIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MLKEKGHOAAG
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8113280", Offset = "0x8111E80", VA = "0x188113280")]
	public static GMMMPEFMCBF PFAMGHBOCBB(this PEOHNMCPNIJ GDLIBGFAMED)
	{
		return default(GMMMPEFMCBF);
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
