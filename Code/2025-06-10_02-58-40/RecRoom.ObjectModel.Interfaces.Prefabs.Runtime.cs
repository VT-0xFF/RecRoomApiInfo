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
public class MLHMILKIBCA : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2189610", Offset = "0x2188810", VA = "0x182189610")]
	public MLHMILKIBCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NHNPKDBGEBE
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAMGBFKFPEI(RRObjectPrefabData OBMOFEPEPAD, CMBCIMIONDM HBNOJPHCEPL);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, DDPHEKACOFI, ComponentTypeList, DCIFKHOCFBG)> BNAGAOICLGF(NativeArray<(AJCKMHEMCBO primitiveType, DDPHEKACOFI prefabType)> PHOPLOLENLE);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void DCIFKHOCFBG(DDPHEKACOFI OBMOFEPEPAD, CMBCIMIONDM HBNOJPHCEPL);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct CMBCIMIONDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity GONFONDIOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager GHGOAAAICCH;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2F71020", Offset = "0x2F70220", VA = "0x182F71020")]
	public CMBCIMIONDM(Entity GONFONDIOED, EntityManager GHGOAAAICCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x37F9EE0", Offset = "0x37F90E0", VA = "0x1837F9EE0")]
	public void DEEMOOGCBGF<T>(T KJIOHKMJAPE) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x37FA100", Offset = "0x37F9300", VA = "0x1837FA100")]
	public void DEJJBBODCOK<T>(T KJIOHKMJAPE) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7E10820", Offset = "0x7E0FA20", VA = "0x187E10820")]
	public void MHJCOPALDKJ()
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
