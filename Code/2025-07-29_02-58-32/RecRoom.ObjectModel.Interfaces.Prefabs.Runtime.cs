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
public class BIPPOGJGKAG : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x234AA50", Offset = "0x2349450", VA = "0x18234AA50")]
	public BIPPOGJGKAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AMIFEAOPNEB
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKDNABFGEAM(RRObjectPrefabData NEEBPDGFOPO, EKLNPGPPHGD MLAOKHBJMMI);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, HNILOHJHGJL, ComponentTypeList, CPJOGKGMJCD)> JPAPBNINELG(NativeArray<(CEHCOOIBKHM primitiveType, HNILOHJHGJL prefabType)> AIBHFOFPIBC);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void CPJOGKGMJCD(HNILOHJHGJL NEEBPDGFOPO, EKLNPGPPHGD MLAOKHBJMMI);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EKLNPGPPHGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity EOGGAEBALGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager MGCKGGMOENE;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3024C90", Offset = "0x3023690", VA = "0x183024C90")]
	public EKLNPGPPHGD(Entity EOGGAEBALGK, EntityManager MGCKGGMOENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5CE0", Offset = "0x3AE46E0", VA = "0x183AE5CE0")]
	public void MAAIKGLMNNO<T>(T PDKJBMPOMNC) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5C50", Offset = "0x3AE4650", VA = "0x183AE5C50")]
	public void JKHJHLFKOFD<T>(T PDKJBMPOMNC) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x84CE5A0", Offset = "0x84CCFA0", VA = "0x1884CE5A0")]
	public void AOFLLLFNJOJ()
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
