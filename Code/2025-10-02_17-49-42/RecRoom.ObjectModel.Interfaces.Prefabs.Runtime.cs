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
public class CJFEELBMBIA : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2421520", Offset = "0x241FF20", VA = "0x182421520")]
	public CJFEELBMBIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MDLHAGLAGFL
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BMHMJJAPGON(RRObjectPrefabData LLPHCEGIIGN, GOMMBCOLPLC KFLMOKMBADN);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, HNDOCECHNBA, ComponentTypeList, GNHBNKHCJNE)> LMJAFJLNJCL(NativeArray<(BMLHKENOJFK primitiveType, HNDOCECHNBA prefabType)> MGKAOIHOBAC);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void GNHBNKHCJNE(HNDOCECHNBA LLPHCEGIIGN, GOMMBCOLPLC KFLMOKMBADN);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct GOMMBCOLPLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity BDOCGCBPBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager NCBHJFGCEMJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3101A80", Offset = "0x3100480", VA = "0x183101A80")]
	public GOMMBCOLPLC(Entity BDOCGCBPBOC, EntityManager NCBHJFGCEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA510", Offset = "0x3DB8F10", VA = "0x183DBA510")]
	public void FNAEMEPGHFK<T>(T KMAFNKGMDCF) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA730", Offset = "0x3DB9130", VA = "0x183DBA730")]
	public void JAAAMJIBLEN<T>(T KMAFNKGMDCF) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x86C2D60", Offset = "0x86C1760", VA = "0x1886C2D60")]
	public void JDOPEIELPIF()
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
