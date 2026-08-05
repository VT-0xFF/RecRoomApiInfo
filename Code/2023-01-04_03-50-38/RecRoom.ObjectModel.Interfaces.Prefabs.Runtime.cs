using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public delegate void NJNPJDPFFOC(APCEPJKMKDM BKEDDPMCLJC, Entity NOADJCMIKEF, EntityManager GKHNMAAJNKF);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JAHABMICOPB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(APCEPJKMKDM, GMPCHIGGFPJ, NJNPJDPFFOC)> OOOPIFHGBPF(JEPHPHGHCPD EINHMHCOFBL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JEPHPHGHCPD
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(EOLBHDKIGHE, APCEPJKMKDM)> JPAMODDEHGC();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class NBJCFLDAFMB : GKLONNNGPKI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public NBJCFLDAFMB()
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
