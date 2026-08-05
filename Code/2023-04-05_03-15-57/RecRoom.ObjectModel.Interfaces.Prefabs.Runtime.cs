using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public delegate void MFECPBIKMNM(OBNHEEKLBIB IBFEICPOBBG, Entity PJEENOLDJIO, EntityManager JGDEKKJFKAJ);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EADJHKFEPHB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(OBNHEEKLBIB, ComponentTypeList, MFECPBIKMNM)> JBCEEBGOLLH(JJMCFGGDMGC APEJINPFNBH);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JJMCFGGDMGC
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(MCLBIBPLLEA, OBNHEEKLBIB)> BJDHAHLCMPI();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class GPCIKNALAEI : EDPKKCFLJBE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xE95DD0", Offset = "0xE94DD0", VA = "0x180E95DD0")]
	public GPCIKNALAEI()
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
