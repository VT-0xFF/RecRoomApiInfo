using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IOHDLIGGGEP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCBNPPFKHDF(DOELAEOOEOB LNPLCOCFIOP, CKHLMLFMOBM IEBDHIBNLJH);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(DOELAEOOEOB, ComponentTypeList, IOKKIOOLBDP)> CHLOHMHFMHE(LBIJNFMGAEC MAIIJMKDKMO);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void IOKKIOOLBDP(DOELAEOOEOB LNPLCOCFIOP, CKHLMLFMOBM IEBDHIBNLJH);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct CKHLMLFMOBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity IBKNLGIDEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager DIKLEKJGKDE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x257D0D0", Offset = "0x257C2D0", VA = "0x18257D0D0")]
	public CKHLMLFMOBM(Entity IBKNLGIDEBH, EntityManager DIKLEKJGKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2949F20", Offset = "0x2949120", VA = "0x182949F20")]
	public void OLOHHMDPKEO<T>(T JMDCGOKJIDA) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x294A140", Offset = "0x2949340", VA = "0x18294A140")]
	public void OOMOAFCEDFL<T>(T JMDCGOKJIDA) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69E5A70", Offset = "0x69E4C70", VA = "0x1869E5A70")]
	public void GDILCKJGNFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LBIJNFMGAEC
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(ABNGHCBPDJL, DOELAEOOEOB)> KKHMDLKBJPO();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class GCANHPPDGMA : DFPPNDAPLGM
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x14D3B10", Offset = "0x14D2D10", VA = "0x1814D3B10")]
	public GCANHPPDGMA()
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
