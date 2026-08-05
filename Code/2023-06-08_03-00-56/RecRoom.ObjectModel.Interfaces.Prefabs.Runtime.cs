using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Components;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface AIENBFPPLDN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(PrimitiveShapeType, ObjectPrefabType)> OLKJKBIPOIF();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class)]
public class IEAGPPAPJNN : LMBDOPFLGJC
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9B3AA0", Offset = "0x9B28A0", VA = "0x1809B3AA0")]
	public IEAGPPAPJNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DCPJKDDCOFL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MAEGNDKHBLL(ObjectPrefabType HPLFBDKKOIF, AIFHNFKMJFK NCACKFGGLII);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(ObjectPrefabType, ComponentTypeList, PCCIMEAAAPJ)> ELFDGCBBNCP(AIENBFPPLDN ONBOJIHAIND);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void PCCIMEAAAPJ(ObjectPrefabType HPLFBDKKOIF, AIFHNFKMJFK NCACKFGGLII);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct AIFHNFKMJFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity FPIIEOBJDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager HCPDBMFJKPJ;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x866900", Offset = "0x865700", VA = "0x180866900")]
	public AIFHNFKMJFK(Entity FPIIEOBJDDB, EntityManager HCPDBMFJKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2C5EFC0", Offset = "0x2C5DDC0", VA = "0x182C5EFC0")]
	public void MDELLMLPPIN<T>(T KKLNCEHOHED) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2C5EFA0", Offset = "0x2C5DDA0", VA = "0x182C5EFA0")]
	public void KELAMJBEMDN<T>(T KKLNCEHOHED) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7003BB0", Offset = "0x70029B0", VA = "0x187003BB0")]
	public void GPJDIIOFKCF()
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
