using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface ELOPABOMIIE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNCNBJHIFNK(EKPAFNPHKFE LMKPBPFJEKM, KLKJGNBOLOD CNHFDLJBOMM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(EKPAFNPHKFE, ComponentTypeList, ECHEDOKKLGG)> NLPIELOOALM(EFBKABEBAEM HPFFLLHLOPL);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void ECHEDOKKLGG(EKPAFNPHKFE LMKPBPFJEKM, KLKJGNBOLOD CNHFDLJBOMM);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct KLKJGNBOLOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity OKNDNPBNCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager DPCAAACILIP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2766BB0", Offset = "0x27657B0", VA = "0x182766BB0")]
	public KLKJGNBOLOD(Entity OKNDNPBNCCC, EntityManager DPCAAACILIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2ECB760", Offset = "0x2ECA360", VA = "0x182ECB760")]
	public void GAOLHIMCFIN<T>(T CABLCDOIFFL) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2ECB6E0", Offset = "0x2ECA2E0", VA = "0x182ECB6E0")]
	public void BJGGNKNNCLF<T>(T CABLCDOIFFL) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6D7BA70", Offset = "0x6D7A670", VA = "0x186D7BA70")]
	public void JJOEPLFCEBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EFBKABEBAEM
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(FLDGGDEOLHM, EKPAFNPHKFE)> AHIPJEPEFFA();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class DFDCPPDEJEN : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1738690", Offset = "0x1737290", VA = "0x181738690")]
	public DFDCPPDEJEN()
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
