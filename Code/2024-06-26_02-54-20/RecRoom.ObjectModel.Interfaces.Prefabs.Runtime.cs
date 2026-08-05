using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FDBOACFNDNM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHEGHNDNGHO(HMNDHIDLGHN HKILDBKKLEG, OILHJAJLJCF MIKCJFHLFDK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(HMNDHIDLGHN, ComponentTypeList, BGGGDMOEPDE)> HDBCCBLDMBA(GHPMALCNPAL OGFAONAECPK);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void BGGGDMOEPDE(HMNDHIDLGHN HKILDBKKLEG, OILHJAJLJCF MIKCJFHLFDK);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OILHJAJLJCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity JOAHHHNEJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager EHDLNANHIAB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x25762E0", Offset = "0x25748E0", VA = "0x1825762E0")]
	public OILHJAJLJCF(Entity JOAHHHNEJGM, EntityManager EHDLNANHIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2CA07E0", Offset = "0x2C9EDE0", VA = "0x182CA07E0")]
	public void LHLEJLJODIO<T>(T CBAEIEAPLIH) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2CA0760", Offset = "0x2C9ED60", VA = "0x182CA0760")]
	public void FAANOJPABDH<T>(T CBAEIEAPLIH) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A2DE60", Offset = "0x6A2C460", VA = "0x186A2DE60")]
	public void NBLMDGLPJKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GHPMALCNPAL
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(BBDBMCJMGFO, HMNDHIDLGHN)> PLLGNIMJHPA();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class OOHPAOBBBKI : GODPKMDNFNE
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x14E19E0", Offset = "0x14DFFE0", VA = "0x1814E19E0")]
	public OOHPAOBBBKI()
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
