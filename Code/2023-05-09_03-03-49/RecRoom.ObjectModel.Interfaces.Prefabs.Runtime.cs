using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public delegate void LKCGAGIHLIC(IMJFJJBFBGO FPPOGBDGFJM, Entity OOGAMDNOHNH, EntityManager IMCLABBJAOB);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JFECPFAKGNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(IMJFJJBFBGO, ComponentTypeList, LKCGAGIHLIC)> DELEIHOJGHB(AHOBDEDDKCC DKNCGBIHPEI);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AHOBDEDDKCC
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(BFFEGPGDBEI, IMJFJJBFBGO)> OCFKHGMJOPA();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class DPMKCDEDKBA : PGOPFOOOOPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1E63C80", Offset = "0x1E62680", VA = "0x181E63C80")]
	public DPMKCDEDKBA()
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
