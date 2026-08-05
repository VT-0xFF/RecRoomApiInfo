using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public delegate void HDAFOCFOAHA(CNKGPKGDJHD FNGBDAJENGB, Entity LHCPLOHKBCE, EntityManager IIODDCGHDHF);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OOCNBKCHBGM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(CNKGPKGDJHD, ComponentTypeList, HDAFOCFOAHA)> BFFKNGNACFH(DNFGCBJMOHN ELFOBADGBAE);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DNFGCBJMOHN
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(HAGCJKKHBBM, CNKGPKGDJHD)> FKICIFCOLGO();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class DCAIGIIFNJM : ECLDMCLCKCC
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x26966F0", Offset = "0x26958F0", VA = "0x1826966F0")]
	public DCAIGIIFNJM()
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
