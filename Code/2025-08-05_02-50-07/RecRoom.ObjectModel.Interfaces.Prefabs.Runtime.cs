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
public class NLCALLFLALN : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x23556D0", Offset = "0x2354AD0", VA = "0x1823556D0")]
	public NLCALLFLALN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GOFMNEGPMPL
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JENDLKJBOII(RRObjectPrefabData HCOCMBHFGFG, LFADCNHFLLE HGPMENNMCEA);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, KEPNMPHCHCC, ComponentTypeList, OHDHLMNNBFP)> AGINIGLLKJC(NativeArray<(BFBNMLCCBFM primitiveType, KEPNMPHCHCC prefabType)> JJPCACLOGCO);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void OHDHLMNNBFP(KEPNMPHCHCC HCOCMBHFGFG, LFADCNHFLLE HGPMENNMCEA);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LFADCNHFLLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity MEOOAHKPJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager JGFECLAMEOK;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x302F400", Offset = "0x302E800", VA = "0x18302F400")]
	public LFADCNHFLLE(Entity MEOOAHKPJCE, EntityManager JGFECLAMEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3DA6240", Offset = "0x3DA5640", VA = "0x183DA6240")]
	public void LFFCNKDPJLH<T>(T CBMEHPPMEEA) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3DA61B0", Offset = "0x3DA55B0", VA = "0x183DA61B0")]
	public void KKODGIEKFDD<T>(T CBMEHPPMEEA) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8475DD0", Offset = "0x84751D0", VA = "0x188475DD0")]
	public void OIFHAMNMKPD()
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
