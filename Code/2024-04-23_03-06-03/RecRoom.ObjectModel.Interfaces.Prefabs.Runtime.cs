using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MFOPDIMGGCA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGNCHJFKIMH(PLACGONOKNH INLOKFDEDIJ, LLPIOBAFOBE AKOPCBJNGNA);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(PLACGONOKNH, ComponentTypeList, LHDPPECCKOK)> PMCLBFOJOHO(IMCPCOMNALO MDGDFGMAEEG);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void LHDPPECCKOK(PLACGONOKNH INLOKFDEDIJ, LLPIOBAFOBE AKOPCBJNGNA);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LLPIOBAFOBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity KNIDMAMMIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager BKPACEIFJEG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2395E70", Offset = "0x2394E70", VA = "0x182395E70")]
	public LLPIOBAFOBE(Entity KNIDMAMMIEJ, EntityManager BKPACEIFJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2964690", Offset = "0x2963690", VA = "0x182964690")]
	public void PGLEONAELKI<T>(T LDGMLLMKHLF) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2964610", Offset = "0x2963610", VA = "0x182964610")]
	public void JAIJDNABIDH<T>(T LDGMLLMKHLF) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6384DD0", Offset = "0x6383DD0", VA = "0x186384DD0")]
	public void KGPBBNCKHIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IMCPCOMNALO
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(NGHGEBOPDDH, PLACGONOKNH)> GHKFDNDGOBA();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class DAKJPOPKBKM : IGIJIHDOMKC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7D00C0", Offset = "0x7CF0C0", VA = "0x1807D00C0")]
	public DAKJPOPKBKM()
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
