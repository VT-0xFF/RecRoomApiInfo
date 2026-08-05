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
public class KGBJKMLPJEG : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x23C4B80", Offset = "0x23C3180", VA = "0x1823C4B80")]
	public KGBJKMLPJEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KIICNPGEHND
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLNGDGDAKCM(RRObjectPrefabData MMBNDPFHBFJ, IBDNFGKIDBN MIIJKEGPKFH);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, GJAKPPLFMHA, ComponentTypeList, NHIDBIKHCBI)> GILDBKEDPLD(NativeArray<(FNNLELJCGID primitiveType, GJAKPPLFMHA prefabType)> CCNOIFOMIED);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void NHIDBIKHCBI(GJAKPPLFMHA MMBNDPFHBFJ, IBDNFGKIDBN MIIJKEGPKFH);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct IBDNFGKIDBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity COIPJNEHPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager JMBADOBJEBH;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x309D6B0", Offset = "0x309BCB0", VA = "0x18309D6B0")]
	public IBDNFGKIDBN(Entity COIPJNEHPIG, EntityManager JMBADOBJEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3DF0E70", Offset = "0x3DEF470", VA = "0x183DF0E70")]
	public void ADPGIIFDGLO<T>(T FKMNCAKIOFK) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3DF1090", Offset = "0x3DEF690", VA = "0x183DF1090")]
	public void JHCKANLEFHH<T>(T FKMNCAKIOFK) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x862B830", Offset = "0x8629E30", VA = "0x18862B830")]
	public void BPONBBLCKFE()
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
