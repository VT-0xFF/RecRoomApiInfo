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
	[Cpp2IlInjected.Address(RVA = "0x8A3CC0", Offset = "0x8A28C0", VA = "0x1808A3CC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x820FC0", Offset = "0x81FBC0", VA = "0x180820FC0")]
	public GCCEBCPNNOL(Entity CMBJDMJHALL, EntityManager LMJGFJDJJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2D02230", Offset = "0x2D00E30", VA = "0x182D02230")]
	public void OLBGCODNBJK<T>(T ECNGHFJBIJL) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2D02210", Offset = "0x2D00E10", VA = "0x182D02210")]
	public void HHMBPBFDFAL<T>(T ECNGHFJBIJL) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6FF7760", Offset = "0x6FF6360", VA = "0x186FF7760")]
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
