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
	[Cpp2IlInjected.Address(RVA = "0x256E1F0", Offset = "0x256CBF0", VA = "0x18256E1F0")]
	public CKHLMLFMOBM(Entity IBKNLGIDEBH, EntityManager DIKLEKJGKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x293B8F0", Offset = "0x293A2F0", VA = "0x18293B8F0")]
	public void OLOHHMDPKEO<T>(T JMDCGOKJIDA) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x293BB10", Offset = "0x293A510", VA = "0x18293BB10")]
	public void OOMOAFCEDFL<T>(T JMDCGOKJIDA) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69CAB10", Offset = "0x69C9510", VA = "0x1869CAB10")]
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
	[Cpp2IlInjected.Address(RVA = "0x14DD360", Offset = "0x14DBD60", VA = "0x1814DD360")]
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
