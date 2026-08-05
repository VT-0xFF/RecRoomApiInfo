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
public class CCBJCPHBNFE : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1F20DC0", Offset = "0x1F201C0", VA = "0x181F20DC0")]
	public CCBJCPHBNFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CFIFHGKMBKD
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMFDEMPEOFE(RRObjectPrefabData EOKGBFAAECE, AOOAANMIOJF NPPPDOILKGM);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, PMHBKOEDEGH, ComponentTypeList, BFDPCICIFLA)> BKMKMILPCPL(NativeArray<(GCBGIGDHMFN primitiveType, PMHBKOEDEGH prefabType)> BFADBEBANMF);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void BFDPCICIFLA(PMHBKOEDEGH EOKGBFAAECE, AOOAANMIOJF NPPPDOILKGM);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct AOOAANMIOJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity PPBBFEJHKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager EDIIKMBGJIA;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2CABFB0", Offset = "0x2CAB3B0", VA = "0x182CABFB0")]
	public AOOAANMIOJF(Entity PPBBFEJHKOL, EntityManager EDIIKMBGJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3D67C30", Offset = "0x3D67030", VA = "0x183D67C30")]
	public void AJAPKMAIBCL<T>(T FIIKLGCIAGG) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3D67E50", Offset = "0x3D67250", VA = "0x183D67E50")]
	public void KIKHNNABBHM<T>(T FIIKLGCIAGG) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7984780", Offset = "0x7983B80", VA = "0x187984780")]
	public void FFGBODLJFDF()
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
