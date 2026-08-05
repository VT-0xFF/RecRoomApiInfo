using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KPFHEDMDJDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(JBOEKGNECFI, KECBEHOHBCN)> OKICLLBLNLH();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class)]
public class BIKPGNPKIGD : EFDDNEKNAJL
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x97A870", Offset = "0x979070", VA = "0x18097A870")]
	public BIKPGNPKIGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LCLIFGLLAPD
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BAPNLHBLDNP(KECBEHOHBCN MCBNACIDAGA, DIFFKKJJKPP LOOBIPAHIEL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(KECBEHOHBCN, ComponentTypeList, MMAEMHJKCEP)> ELCPJOECMON(KPFHEDMDJDJ CBGOOONHBMI);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void MMAEMHJKCEP(KECBEHOHBCN MCBNACIDAGA, DIFFKKJJKPP LOOBIPAHIEL);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct DIFFKKJJKPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity AJDEFAPHMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager EADLBIHJKBG;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1AAFBE0", Offset = "0x1AAE3E0", VA = "0x181AAFBE0")]
	public DIFFKKJJKPP(Entity AJDEFAPHMKF, EntityManager EADLBIHJKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3075730", Offset = "0x3073F30", VA = "0x183075730")]
	public void OLFLGMGEIBD<T>(T MENBIMCLIOI) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3075710", Offset = "0x3073F10", VA = "0x183075710")]
	public void AJDPONOAPEJ<T>(T MENBIMCLIOI) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F2D2A0", Offset = "0x6F2BAA0", VA = "0x186F2D2A0")]
	public void CBPBOGLIELH()
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
