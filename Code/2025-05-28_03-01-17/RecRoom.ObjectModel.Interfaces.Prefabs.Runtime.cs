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
public class CDFMAEJFMLK : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x20D9420", Offset = "0x20D8220", VA = "0x1820D9420")]
	public CDFMAEJFMLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IFKCKIPGIOC
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PIGIDHCPHMI(RRObjectPrefabData BMCGNJAOJFL, BJJPLMGINJG DHAJKIPAFEE);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(Guid, MHMDDCOCPKH, ComponentTypeList, GJPEGJCBBMJ)> KICOOFHCFDM(NativeArray<(AEHNMCPGHOA primitiveType, MHMDDCOCPKH prefabType)> OONDHNCMJDD);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void GJPEGJCBBMJ(MHMDDCOCPKH BMCGNJAOJFL, BJJPLMGINJG DHAJKIPAFEE);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BJJPLMGINJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity OFJKELIPJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager CCPBGAMLKKA;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2ED1A90", Offset = "0x2ED0890", VA = "0x182ED1A90")]
	public BJJPLMGINJG(Entity OFJKELIPJNP, EntityManager CCPBGAMLKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x36A08E0", Offset = "0x369F6E0", VA = "0x1836A08E0")]
	public void KDAEEABIJCL<T>(T OAIIHELJHLG) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x36A0B00", Offset = "0x369F900", VA = "0x1836A0B00")]
	public void PCNKKNBCCBJ<T>(T OAIIHELJHLG) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7F59760", Offset = "0x7F58560", VA = "0x187F59760")]
	public void IKIHEPNHODM()
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
