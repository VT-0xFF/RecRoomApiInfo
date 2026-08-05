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
public class KDGGPFOMJPG : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x241B440", Offset = "0x2419A40", VA = "0x18241B440")]
	public KDGGPFOMJPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MODDCANKGEE
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BOMBEOEHHGM(RRObjectPrefabData LBMDJCMFBKL, BKCLBMADBAK DHJODJGIMDJ);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, KMGJLAHNDFB, ComponentTypeList, IOJCOEHLJHH)> BMKNGMBANKP(NativeArray<(PINBFOAJNAG primitiveType, KMGJLAHNDFB prefabType)> MPMALMOAMEL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void IOJCOEHLJHH(KMGJLAHNDFB LBMDJCMFBKL, BKCLBMADBAK DHJODJGIMDJ);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BKCLBMADBAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity JAPNANJIKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager OLNPNJLIAFG;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3106D70", Offset = "0x3105370", VA = "0x183106D70")]
	public BKCLBMADBAK(Entity JAPNANJIKLB, EntityManager OLNPNJLIAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3B61B40", Offset = "0x3B60140", VA = "0x183B61B40")]
	public void IAMMACFOCIM<T>(T KOPHBHGIACG) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3B61AB0", Offset = "0x3B600B0", VA = "0x183B61AB0")]
	public void HDKFAMBHPII<T>(T KOPHBHGIACG) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x86C8E00", Offset = "0x86C7400", VA = "0x1886C8E00")]
	public void BJJLBOCHCLH()
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
