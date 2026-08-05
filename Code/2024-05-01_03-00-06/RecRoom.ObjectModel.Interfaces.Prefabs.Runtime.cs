using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HAFAEPPOEHG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FMNOMLADEOB(LGNBEHGCHLL MIEPJJBHNJD, OMDELBINLGK LNMJJEMOJLJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(LGNBEHGCHLL, ComponentTypeList, HNLIFHAEJEE)> GOAHGIIJBAL(OKEPPCBHPKE PPDDJPLJCLP);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void HNLIFHAEJEE(LGNBEHGCHLL MIEPJJBHNJD, OMDELBINLGK LNMJJEMOJLJ);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OMDELBINLGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity IBOBFMDOLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager BCAONBAACAD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2390E10", Offset = "0x238FC10", VA = "0x182390E10")]
	public OMDELBINLGK(Entity IBOBFMDOLFK, EntityManager BCAONBAACAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A24280", Offset = "0x2A23080", VA = "0x182A24280")]
	public void KNPAMBFMNAD<T>(T DIBNBLEEFNN) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2A24200", Offset = "0x2A23000", VA = "0x182A24200")]
	public void ACAIHNIOBDK<T>(T DIBNBLEEFNN) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x62E9010", Offset = "0x62E7E10", VA = "0x1862E9010")]
	public void JGHDBPCCGHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OKEPPCBHPKE
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(GGOBOICLBDK, LGNBEHGCHLL)> CCBENHEKLAJ();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class NPJIMLCIOCH : CLKDHNLADCA
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7BF230", Offset = "0x7BE030", VA = "0x1807BF230")]
	public NPJIMLCIOCH()
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
