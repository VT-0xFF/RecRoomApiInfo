using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public delegate void FPKNLHBDGEP(PEMKGMKGDAH NFNGIKPPKJH, Entity IEFFOCOBJJI, EntityManager MKHPDCKNNBB);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ONKHKDOBJAL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(PEMKGMKGDAH, ComponentTypeList, FPKNLHBDGEP)> PMAICNFJLJA(BPDFOFCBJLO AAPBAEGCALL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BPDFOFCBJLO
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(PDAOCOFFNGC, PEMKGMKGDAH)> BBKIFGLIMLL();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class LJHGPNJAMAI : DPKIKFFCGDF
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x225D3E0", Offset = "0x225C1E0", VA = "0x18225D3E0")]
	public LJHGPNJAMAI()
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
