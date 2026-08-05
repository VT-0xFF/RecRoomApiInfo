using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public delegate void FHINBEIIHEC(AOIKBHJMDBO GDAJCNKPBDC, Entity GOANOLJBHPF, EntityManager BJMEFCCEPHI);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EDJDLABAIND
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(AOIKBHJMDBO, ComponentTypeList, FHINBEIIHEC)> KBHMGNAHPCL(DFMKILDNMLK HPAFIPNLAIL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DFMKILDNMLK
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(MGHIFAKDBDN, AOIKBHJMDBO)> LJIMDEEFLLN();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class LJPCFGFOLLL : AGCFOLLKBED
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public LJPCFGFOLLL()
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
