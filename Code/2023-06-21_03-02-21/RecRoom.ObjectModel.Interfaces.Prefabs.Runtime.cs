using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Components;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DABPBKLKDDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(PrimitiveShapeType, ObjectPrefabType)> DMIPKPCMHNE();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class)]
public class CBNGFBMBMPB : HMEEAGFGNAN
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x956D50", Offset = "0x955F50", VA = "0x180956D50")]
	public CBNGFBMBMPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JJBECBLKGBP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEDNELCELJM(ObjectPrefabType DDFDFJDKPLL, GCDGACELAMC DFNLKBKKKDG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(ObjectPrefabType, ComponentTypeList, JMGPBHDPADI)> GOFFKMKOEPF(DABPBKLKDDJ FDDNKJCGNFI);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void JMGPBHDPADI(ObjectPrefabType DDFDFJDKPLL, GCDGACELAMC DFNLKBKKKDG);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GCDGACELAMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity FADPOFMJIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager NBACICFMHBN;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x86FA50", Offset = "0x86EC50", VA = "0x18086FA50")]
	public GCDGACELAMC(Entity FADPOFMJIJF, EntityManager NBACICFMHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2AFECC0", Offset = "0x2AFDEC0", VA = "0x182AFECC0")]
	public void EBIKLMMGLOI<T>(T ACKOJNNBEBO) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2AFEDA0", Offset = "0x2AFDFA0", VA = "0x182AFEDA0")]
	public void MJPALAJFNOC<T>(T ACKOJNNBEBO) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x70F9A80", Offset = "0x70F8C80", VA = "0x1870F9A80")]
	public void OIHEAKNGKMI()
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
