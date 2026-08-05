using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Components;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NFLFBHMBMEK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(PrimitiveShapeType, ObjectPrefabType)> NCFJOOMKEKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class)]
public class BCINEHNDCBE : LBCLEEENKKC
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x92DE00", Offset = "0x92C600", VA = "0x18092DE00")]
	public BCINEHNDCBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EOEEPKNNODG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AOGGJLIGLNM(ObjectPrefabType KJIFGCIDDIC, GCCEBCPNNOL FLJBONPLKBA);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(ObjectPrefabType, ComponentTypeList, LHPGENEBKLI)> KLGEOEIFHAN(NFLFBHMBMEK GINDOLIAELM);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void LHPGENEBKLI(ObjectPrefabType KJIFGCIDDIC, GCCEBCPNNOL FLJBONPLKBA);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GCCEBCPNNOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity CMBJDMJHALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager LMJGFJDJJLA;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x83CA00", Offset = "0x83B200", VA = "0x18083CA00")]
	public GCCEBCPNNOL(Entity CMBJDMJHALL, EntityManager LMJGFJDJJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x30B4980", Offset = "0x30B3180", VA = "0x1830B4980")]
	public void OLBGCODNBJK<T>(T ECNGHFJBIJL) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x30B4960", Offset = "0x30B3160", VA = "0x1830B4960")]
	public void HHMBPBFDFAL<T>(T ECNGHFJBIJL) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE48C0", Offset = "0x6FE30C0", VA = "0x186FE48C0")]
	public void BNPCFCPEDKM()
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
