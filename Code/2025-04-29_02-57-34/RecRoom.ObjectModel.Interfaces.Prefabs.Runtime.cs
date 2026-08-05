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
public class MCIMCPGJDFH : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1FE5BD0", Offset = "0x1FE4FD0", VA = "0x181FE5BD0")]
	public MCIMCPGJDFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EIJGOBKMJJC
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BALIPNMMOIO(RRObjectPrefabData OGLFGINBMNF, PLCMHHDOJKP CGBGKIBEAKK);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, KGBPAFEODGH, ComponentTypeList, OLJNCCBCNHC)> ALKCNGHJOOK(NativeArray<(HKOELKKOBKF primitiveType, KGBPAFEODGH prefabType)> ILBPAJHJOFH);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void OLJNCCBCNHC(KGBPAFEODGH OGLFGINBMNF, PLCMHHDOJKP CGBGKIBEAKK);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct PLCMHHDOJKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity BGFOMMJBGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager IBLGEGBFEIJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2D791B0", Offset = "0x2D785B0", VA = "0x182D791B0")]
	public PLCMHHDOJKP(Entity BGFOMMJBGIM, EntityManager IBLGEGBFEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x38C48C0", Offset = "0x38C3CC0", VA = "0x1838C48C0")]
	public void KFMFOPCGNHM<T>(T OOEMJLHLIHJ) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x38C4830", Offset = "0x38C3C30", VA = "0x1838C4830")]
	public void JFIPJLDGPFP<T>(T OOEMJLHLIHJ) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C74E00", Offset = "0x7C74200", VA = "0x187C74E00")]
	public void KHDBGFKFEMG()
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
