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
public class MJHPBHEOEOP : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2087970", Offset = "0x2086B70", VA = "0x182087970")]
	public MJHPBHEOEOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GCNMMIDKKNF
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HECHFIKBEON(RRObjectPrefabData ONDECPHMAJI, CJEGAMBHHDJ ELAPGGHMDCC);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, OKHKCFDCPLN, ComponentTypeList, FEGMKJJDCPK)> GKGDPEHLKKF(NativeArray<(JNBMIBPKCDD primitiveType, OKHKCFDCPLN prefabType)> MKNDMKBODAI);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void FEGMKJJDCPK(OKHKCFDCPLN ONDECPHMAJI, CJEGAMBHHDJ ELAPGGHMDCC);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct CJEGAMBHHDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity LBPCFJCJDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager EPEFONCBOCP;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2E42940", Offset = "0x2E41B40", VA = "0x182E42940")]
	public CJEGAMBHHDJ(Entity LBPCFJCJDPM, EntityManager EPEFONCBOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x36212D0", Offset = "0x36204D0", VA = "0x1836212D0")]
	public void DENBCCCLIHH<T>(T MLCDCHNOCFI) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3621240", Offset = "0x3620440", VA = "0x183621240")]
	public void CLIAOGJINCA<T>(T MLCDCHNOCFI) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7E38EF0", Offset = "0x7E380F0", VA = "0x187E38EF0")]
	public void JNMNLBKBKIM()
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
