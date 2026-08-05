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
public class NOEKOFKABPL : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1E79E60", Offset = "0x1E79060", VA = "0x181E79E60")]
	public NOEKOFKABPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ABHHOJEHEBI
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOFLDJNFMPD(RRObjectPrefabData ACLLIENJBND, EPEDIJHDCFL OAMDDHHAKLF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, GBIMNPEINGJ, ComponentTypeList, CODNHNPCCMP)> EFDCJBIAFIJ(NativeArray<(PMLONBCCMJA primitiveType, GBIMNPEINGJ prefabType)> HIKBJMLPKIN);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void CODNHNPCCMP(GBIMNPEINGJ ACLLIENJBND, EPEDIJHDCFL OAMDDHHAKLF);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EPEDIJHDCFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity JJMNGBLHAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager HOPEOGNNILD;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2C106A0", Offset = "0x2C0F8A0", VA = "0x182C106A0")]
	public EPEDIJHDCFL(Entity JJMNGBLHAJC, EntityManager HOPEOGNNILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x32FA050", Offset = "0x32F9250", VA = "0x1832FA050")]
	public void GFIEJLHFJLN<T>(T OMFJNFBDJCA) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x32FA270", Offset = "0x32F9470", VA = "0x1832FA270")]
	public void NIGMCDBJLJA<T>(T OMFJNFBDJCA) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7767570", Offset = "0x7766770", VA = "0x187767570")]
	public void IIMBLOPEFNP()
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
