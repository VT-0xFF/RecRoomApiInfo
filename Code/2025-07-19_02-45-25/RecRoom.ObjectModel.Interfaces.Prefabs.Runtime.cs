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
public class LJCGBLPNKOB : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2317390", Offset = "0x2316390", VA = "0x182317390")]
	public LJCGBLPNKOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PANPPJMHGLD
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FOBBHCLFCLN(RRObjectPrefabData CMLIMNGJEDE, JAJIMDHBKAB APMDNBBEOFM);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, PNLIBHGDCFN, ComponentTypeList, FJIOOMOFDFH)> GBPAJMKIGEM(NativeArray<(GOAIGCDFKPE primitiveType, PNLIBHGDCFN prefabType)> CLNDMHNANGK);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void FJIOOMOFDFH(PNLIBHGDCFN CMLIMNGJEDE, JAJIMDHBKAB APMDNBBEOFM);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JAJIMDHBKAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity KELHIEHPDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager FMBMFCMHGGJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2FD8200", Offset = "0x2FD7200", VA = "0x182FD8200")]
	public JAJIMDHBKAB(Entity KELHIEHPDJD, EntityManager FMBMFCMHGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3CDF180", Offset = "0x3CDE180", VA = "0x183CDF180")]
	public void ODADMGGOEJG<T>(T IOALKPFEKEK) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3CDF0F0", Offset = "0x3CDE0F0", VA = "0x183CDF0F0")]
	public void GBHAFDJIHOB<T>(T IOALKPFEKEK) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x833C310", Offset = "0x833B310", VA = "0x18833C310")]
	public void LGGBDGOCFEC()
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
