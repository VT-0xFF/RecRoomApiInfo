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
public class NAAIKCIBIGJ : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1F41440", Offset = "0x1F40840", VA = "0x181F41440")]
	public NAAIKCIBIGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IPJKBHEBKCC
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NIAGDFOAKKI(RRObjectPrefabData OEEAJPMCKOG, JBKHLOJDIMP CANJLIJBNBF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, CGLGBAJFIGE, ComponentTypeList, PKNBNFLBKHF)> BDEOPKJDOPJ(NativeArray<(OGALGCNMGJH primitiveType, CGLGBAJFIGE prefabType)> BLHMEEFEFEH);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void PKNBNFLBKHF(CGLGBAJFIGE OEEAJPMCKOG, JBKHLOJDIMP CANJLIJBNBF);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JBKHLOJDIMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity GJIBJHOJMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager MPNJFPGMBFH;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2CDD680", Offset = "0x2CDCA80", VA = "0x182CDD680")]
	public JBKHLOJDIMP(Entity GJIBJHOJMIG, EntityManager MPNJFPGMBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x366FB90", Offset = "0x366EF90", VA = "0x18366FB90")]
	public void JFGGMENNDNP<T>(T FFOEEMKIKJO) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x366FDB0", Offset = "0x366F1B0", VA = "0x18366FDB0")]
	public void LBPIDCCPOMG<T>(T FFOEEMKIKJO) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x79F7590", Offset = "0x79F6990", VA = "0x1879F7590")]
	public void ODAPDKKDIBE()
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
