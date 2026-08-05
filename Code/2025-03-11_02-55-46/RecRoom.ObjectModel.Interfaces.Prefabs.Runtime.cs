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
public class EKKBMAKKJIF : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1E71BF0", Offset = "0x1E70FF0", VA = "0x181E71BF0")]
	public EKKBMAKKJIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ICMBAJOHKHG
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPNIADHBANI(RRObjectPrefabData IJODCDAMALB, EHDHBHDBLNH LIDHKCOPMFI);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, CNBJKFKGILJ, ComponentTypeList, BMGBNICNDDJ)> KPLLHLJNKAM(NativeArray<(KKPFGOPCOFD primitiveType, CNBJKFKGILJ prefabType)> FMCINHCNACL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void BMGBNICNDDJ(CNBJKFKGILJ IJODCDAMALB, EHDHBHDBLNH LIDHKCOPMFI);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EHDHBHDBLNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity JNOEBKCCPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager HIKDABPFHKC;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2C08CF0", Offset = "0x2C080F0", VA = "0x182C08CF0")]
	public EHDHBHDBLNH(Entity JNOEBKCCPMC, EntityManager HIKDABPFHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x330FFD0", Offset = "0x330F3D0", VA = "0x18330FFD0")]
	public void FHPKMMCODGE<T>(T PEBNJNGMMHE) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x33101F0", Offset = "0x330F5F0", VA = "0x1833101F0")]
	public void GFNPJHGGFOB<T>(T PEBNJNGMMHE) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7755A80", Offset = "0x7754E80", VA = "0x187755A80")]
	public void GAONJCIABCN()
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
