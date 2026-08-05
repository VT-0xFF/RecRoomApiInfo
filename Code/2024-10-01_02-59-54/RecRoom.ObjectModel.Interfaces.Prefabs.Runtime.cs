using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FMLOFBILBME
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HNEAMLPAONF(MGPJKDJNENK MFNDAKNCCCP, DCDMMAEKPMP LLEOBGPKPAE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(MGPJKDJNENK, ComponentTypeList, CAMJEHIJIEJ)> JIFJHKADEMP(OBGDHHANEIM AMDDGALABJK);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void CAMJEHIJIEJ(MGPJKDJNENK MFNDAKNCCCP, DCDMMAEKPMP LLEOBGPKPAE);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct DCDMMAEKPMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity GLFIOFJHMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager POOMEDKNPIK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2805F60", Offset = "0x2805360", VA = "0x182805F60")]
	public DCDMMAEKPMP(Entity GLFIOFJHMHG, EntityManager POOMEDKNPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2C808B0", Offset = "0x2C7FCB0", VA = "0x182C808B0")]
	public void JOJCHNFNPDL<T>(T LIHHDPOHLDK) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2C80AD0", Offset = "0x2C7FED0", VA = "0x182C80AD0")]
	public void KDJNGODLBPB<T>(T LIHHDPOHLDK) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6EF3950", Offset = "0x6EF2D50", VA = "0x186EF3950")]
	public void HDHMLFNLJPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OBGDHHANEIM
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(FKCCBAHBFDI, MGPJKDJNENK)> AEPMBNCBLJN();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class AKBOEODPABC : OACGMPBFJHP
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x19BDE10", Offset = "0x19BD210", VA = "0x1819BDE10")]
	public AKBOEODPABC()
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
