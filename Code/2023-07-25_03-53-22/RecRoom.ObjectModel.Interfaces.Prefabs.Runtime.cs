using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface OIODHKMKNNI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(LAHOJAAPJMH, ELIGIOKOANN)> HDKKLMPKDFB();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class)]
public class CJDKDIEFLCB : GNKEBIFFBCC
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xAAA3B0", Offset = "0xAA93B0", VA = "0x180AAA3B0")]
	public CJDKDIEFLCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ONCALFGFMEG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JADFHLHAIKO(ELIGIOKOANN LNODCOPPJNC, EPGAKKKEPGF OJDMEPONJOC);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(ELIGIOKOANN, ComponentTypeList, EBFDEKIDKCG)> MCGBJIDKHJP(OIODHKMKNNI AEGGKCHJNLF);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void EBFDEKIDKCG(ELIGIOKOANN LNODCOPPJNC, EPGAKKKEPGF OJDMEPONJOC);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct EPGAKKKEPGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity NNCCHIHKALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager PFNOJANOPHC;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x12EB3B0", Offset = "0x12EA3B0", VA = "0x1812EB3B0")]
	public EPGAKKKEPGF(Entity NNCCHIHKALO, EntityManager PFNOJANOPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1FFFDC0", Offset = "0x1FFEDC0", VA = "0x181FFFDC0")]
	public void DGLJBNFHKAF<T>(T CKDFGEALFAK) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1FFFEA0", Offset = "0x1FFEEA0", VA = "0x181FFFEA0")]
	public void OOJBKBAGJLN<T>(T CKDFGEALFAK) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x730B950", Offset = "0x730A950", VA = "0x18730B950")]
	public void GHGNKOCLGGH()
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
