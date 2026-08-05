using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IJEGDDGCIAO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DHDBMBILJDO(DMHNOCGAKFK HOHJLAELNHM, HACEHCPKLEI MAPEDJBIKBA);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(DMHNOCGAKFK, ComponentTypeList, AIOAALLIGMA)> PGLAIFKMNED(OPKBLBAFFCH CFDDAEFDPMF);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void AIOAALLIGMA(DMHNOCGAKFK HOHJLAELNHM, HACEHCPKLEI MAPEDJBIKBA);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct HACEHCPKLEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity OGLHBJLEIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager CDKDONGNIMC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x22B8130", Offset = "0x22B7530", VA = "0x1822B8130")]
	public HACEHCPKLEI(Entity OGLHBJLEIOC, EntityManager CDKDONGNIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x27F5C90", Offset = "0x27F5090", VA = "0x1827F5C90")]
	public void NINGCLMMDDO<T>(T PCGOHCLJAPN) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x27F5C10", Offset = "0x27F5010", VA = "0x1827F5C10")]
	public void GJBEJNFFKFC<T>(T PCGOHCLJAPN) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x627BAA0", Offset = "0x627AEA0", VA = "0x18627BAA0")]
	public void IGLIHENALDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OPKBLBAFFCH
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(HAONKCOIBBF, DMHNOCGAKFK)> PKECDLMHGFD();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class AABHHMBABKD : MKFINLHOENC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7CD100", Offset = "0x7CC500", VA = "0x1807CD100")]
	public AABHHMBABKD()
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
