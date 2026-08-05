using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Components;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JIIDOANHKFP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(PrimitiveShapeType, ObjectPrefabType)> FANBIEHMJPF();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class)]
public class EHFDIHLIEIF : JAHLGPIJLNB
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9BED80", Offset = "0x9BD380", VA = "0x1809BED80")]
	public EHFDIHLIEIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NJLINMKIOLH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGPOGNGMFDA(ObjectPrefabType INKNLFCIIAC, NGEGDLDOFJE LJNCPBELMHA);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(ObjectPrefabType, ComponentTypeList, EEDOMBKPFDD)> FHAJPAGIBKO(JIIDOANHKFP JHNGKHHBEOG);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void EEDOMBKPFDD(ObjectPrefabType INKNLFCIIAC, NGEGDLDOFJE LJNCPBELMHA);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct NGEGDLDOFJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity PEKCJMKIHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager BJBBKAHIPJF;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x15C4190", Offset = "0x15C2790", VA = "0x1815C4190")]
	public NGEGDLDOFJE(Entity PEKCJMKIHGK, EntityManager BJBBKAHIPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2717FD0", Offset = "0x27165D0", VA = "0x182717FD0")]
	public void PCICHOODFHC<T>(T FEBHELIDNED) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2717FB0", Offset = "0x27165B0", VA = "0x182717FB0")]
	public void FDHFHIPGHAO<T>(T FEBHELIDNED) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7270AF0", Offset = "0x726F0F0", VA = "0x187270AF0")]
	public void DMPIIGFOADJ()
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
