using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public delegate void JAOIHGPNOHJ(OADLDHPKENB FKEOEHMKOOO, Entity LLEBIIAHFDD, EntityManager CLLNDNAAIKP);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CBHBFIGOJJC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(OADLDHPKENB, FEBPDFEEBHG, JAOIHGPNOHJ)> IMOCEFECCMP(BDJJCEGPPNF DEBJMFLLNHC);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BDJJCEGPPNF
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(CKLKKHOPBLL, OADLDHPKENB)> EJGGFAKDIJP();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class LCOEPHOCAPA : NDNOEJBHMOK
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public LCOEPHOCAPA()
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
