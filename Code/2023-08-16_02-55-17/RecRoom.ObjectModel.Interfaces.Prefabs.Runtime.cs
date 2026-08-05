using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface ADLMCGEFLCG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(EKGFPCGJLIK, IANCKMHPHEB)> JIOAIEDNHFM();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class)]
public class MGLIIJEDBGP : BILDCBEKACL
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8C2A40", Offset = "0x8C1C40", VA = "0x1808C2A40")]
	public MGLIIJEDBGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GDCDLFBODIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFDOBHECEKH(IANCKMHPHEB GLKDKMADKLI, EBJIHNMJANF LGDPAGNNGKE);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(IANCKMHPHEB, ComponentTypeList, BIGKDEKAMGP)> FIEMABIBMIP(ADLMCGEFLCG MKADFFOHHLL);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void BIGKDEKAMGP(IANCKMHPHEB GLKDKMADKLI, EBJIHNMJANF LGDPAGNNGKE);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct EBJIHNMJANF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity BLNICJMKCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager NMHMIPEFENM;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x15BCC60", Offset = "0x15BBE60", VA = "0x1815BCC60")]
	public EBJIHNMJANF(Entity BLNICJMKCEF, EntityManager NMHMIPEFENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xF102E0", Offset = "0xF0F4E0", VA = "0x180F102E0")]
	public void BNDJKAKDCIM<T>(T NABCGCEIEGG) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xF103C0", Offset = "0xF0F5C0", VA = "0x180F103C0")]
	public void GACDLMCDFPM<T>(T NABCGCEIEGG) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F860", Offset = "0x6F7EA60", VA = "0x186F7F860")]
	public void FOEFOKAHCFO()
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
