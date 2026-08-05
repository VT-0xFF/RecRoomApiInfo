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
public class EDAJDIALCKD : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2065F80", Offset = "0x2064580", VA = "0x182065F80")]
	public EDAJDIALCKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JOEHCHDMBJF
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INJFENIOOIO(RRObjectPrefabData BLHCDMNIPMC, MOKINFALKBI FBJKBMEOFCA);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, ENDJLEPDNKB, ComponentTypeList, EEIGPDGGHBG)> NNDEMHOOMHD(NativeArray<(JMKKFNHDEDM primitiveType, ENDJLEPDNKB prefabType)> DNBJKBOBJFC);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void EEIGPDGGHBG(ENDJLEPDNKB BLHCDMNIPMC, MOKINFALKBI FBJKBMEOFCA);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct MOKINFALKBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity IOGPJKLGKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager IPJDHIAOJKP;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2E17000", Offset = "0x2E15600", VA = "0x182E17000")]
	public MOKINFALKBI(Entity IOGPJKLGKKO, EntityManager IPJDHIAOJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3944F20", Offset = "0x3943520", VA = "0x183944F20")]
	public void DGBNDJBCMEF<T>(T OHLIHBDBKCE) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3945140", Offset = "0x3943740", VA = "0x183945140")]
	public void NLBBMANJLAK<T>(T OHLIHBDBKCE) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7DD1470", Offset = "0x7DCFA70", VA = "0x187DD1470")]
	public void AJEKNNIBGFK()
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
