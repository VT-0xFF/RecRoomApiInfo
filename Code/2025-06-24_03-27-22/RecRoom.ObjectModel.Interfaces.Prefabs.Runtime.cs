using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.DataLayer;
using Unity.Collections;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[AttributeUsage(AttributeTargets.Class)]
public class IFLGCDCIHDD : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x220C420", Offset = "0x220B020", VA = "0x18220C420")]
	public IFLGCDCIHDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JLOJIEPIMEL
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BJLGLCOMFBG(RRObjectPrefabData OGJLEDHLGFK, NHFEIFJMNIO NPAKGHLCCBD);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, OJMHHFAGIGE, ComponentTypeList, IOPIIKBKAPE)> LJJCOKCPCAL(NativeArray<(DDKHKNGGFFK primitiveType, OJMHHFAGIGE prefabType)> HJNGFCNMBPA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void IOPIIKBKAPE(OJMHHFAGIGE OGJLEDHLGFK, NHFEIFJMNIO NPAKGHLCCBD);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct NHFEIFJMNIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity JMNEAPNCNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager HGAKBEIGHGE;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x30047A0", Offset = "0x30033A0", VA = "0x1830047A0")]
	public NHFEIFJMNIO(Entity JMNEAPNCNHN, EntityManager HGAKBEIGHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3C3A840", Offset = "0x3C39440", VA = "0x183C3A840")]
	public void PEPEIECOOBP<T>(T OOHGFGHCOAJ) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3C3A7B0", Offset = "0x3C393B0", VA = "0x183C3A7B0")]
	public void GAGGLOKMHBJ<T>(T OOHGFGHCOAJ) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7F88D50", Offset = "0x7F87950", VA = "0x187F88D50")]
	public void AJNMKNHNMPF()
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
