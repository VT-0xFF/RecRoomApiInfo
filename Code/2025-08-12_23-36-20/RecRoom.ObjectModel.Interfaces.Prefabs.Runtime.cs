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
public class LIAJNNOMHKL : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x23B06A0", Offset = "0x23AF4A0", VA = "0x1823B06A0")]
	public LIAJNNOMHKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DLCMLBEJEOK
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OKKMMMKHNBF(RRObjectPrefabData HBKNEJHHAGJ, JJLCAJBAKEB MOLNIFNKDAN);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, ELEOMACPFLA, ComponentTypeList, PEJLPHFLHOK)> FAKGALHJFBG(NativeArray<(OJDJBNOCNOE primitiveType, ELEOMACPFLA prefabType)> ELNALBEFADP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void PEJLPHFLHOK(ELEOMACPFLA HBKNEJHHAGJ, JJLCAJBAKEB MOLNIFNKDAN);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JJLCAJBAKEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity DJHHEAHBFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager OPLCAABCINH;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x308A720", Offset = "0x3089520", VA = "0x18308A720")]
	public JJLCAJBAKEB(Entity DJHHEAHBFFL, EntityManager OPLCAABCINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3D71A80", Offset = "0x3D70880", VA = "0x183D71A80")]
	public void BNFJAIPBEBA<T>(T HGMAIPELJHM) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3D71CA0", Offset = "0x3D70AA0", VA = "0x183D71CA0")]
	public void EAGMKHNPLAJ<T>(T HGMAIPELJHM) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x854B700", Offset = "0x854A500", VA = "0x18854B700")]
	public void EKDHGGMMGPJ()
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
