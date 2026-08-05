using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public delegate void KCGENDPLBIB(KCPOKGIHHKK GANNEANJGDH, Entity DJGIAPPGDDP, EntityManager AIFDIGHJEAF);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NHALKGIKIBN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(KCPOKGIHHKK, ComponentTypeList, KCGENDPLBIB)> EDBHBLKMFGE(KACDEIAKJIK HFGBBMMCEFF);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KACDEIAKJIK
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(FILDKNJLENH, KCPOKGIHHKK)> HBBFGAGIIIJ();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class JDELFEDNEEL : ENPMBAGPCIO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xE974F0", Offset = "0xE95CF0", VA = "0x180E974F0")]
	public JDELFEDNEEL()
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
