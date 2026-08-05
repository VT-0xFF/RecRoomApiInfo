using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NAHEBPCFLAF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGJHNOMMMPP(MMAKLLHOPJG ECCNNFLILMF, FPKBPDPEBML GGPEOLGDKKM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(MMAKLLHOPJG, ComponentTypeList, OOJJCPIOJPA)> PAGPKGLANPH(IAGCKLNHLCD LOEHICMJPOM);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void OOJJCPIOJPA(MMAKLLHOPJG ECCNNFLILMF, FPKBPDPEBML GGPEOLGDKKM);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FPKBPDPEBML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity INJBCGOEBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager NFHPCHOLBII;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2550C00", Offset = "0x254F600", VA = "0x182550C00")]
	public FPKBPDPEBML(Entity INJBCGOEBHC, EntityManager NFHPCHOLBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B15360", Offset = "0x2B13D60", VA = "0x182B15360")]
	public void BJDAAADFLKD<T>(T DBOBEHLEAAE) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2B15580", Offset = "0x2B13F80", VA = "0x182B15580")]
	public void IHOOLNIEJHJ<T>(T DBOBEHLEAAE) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69B9B10", Offset = "0x69B8510", VA = "0x1869B9B10")]
	public void HOIAJJHADCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IAGCKLNHLCD
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(KLOIDLPMPGK, MMAKLLHOPJG)> KFFFLLHDAGJ();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class DJLGNCCLGEI : HJDOGECJOAI
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x14C46D0", Offset = "0x14C30D0", VA = "0x1814C46D0")]
	public DJLGNCCLGEI()
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
