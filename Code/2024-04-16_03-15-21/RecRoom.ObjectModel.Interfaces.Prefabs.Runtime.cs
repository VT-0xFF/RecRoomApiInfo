using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JACBABDECLE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BPEINODAIKL(AIMLLPOCAAB BCOGJAIKHDP, JPINNCODEEN PPPJPIIEFNP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(AIMLLPOCAAB, ComponentTypeList, FMGOMILDNII)> BDBGBNCAPNP(PDBNBPDCGNP KHANELEHECM);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void FMGOMILDNII(AIMLLPOCAAB BCOGJAIKHDP, JPINNCODEEN PPPJPIIEFNP);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct JPINNCODEEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity ACPAMCNIKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager EIHNJKMOIAM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2361860", Offset = "0x2360A60", VA = "0x182361860")]
	public JPINNCODEEN(Entity ACPAMCNIKHM, EntityManager EIHNJKMOIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x28EB8D0", Offset = "0x28EAAD0", VA = "0x1828EB8D0")]
	public void HPPDEOLAJNB<T>(T EKDDCPALANJ) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x28EBAF0", Offset = "0x28EACF0", VA = "0x1828EBAF0")]
	public void OEFAEEOJELM<T>(T EKDDCPALANJ) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6205AA0", Offset = "0x6204CA0", VA = "0x186205AA0")]
	public void JNPAMFJILLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PDBNBPDCGNP
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(DBGCOLPIMDG, AIMLLPOCAAB)> NKNDBKIJNCO();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class IIAOHCKJNFP : GNEIIAKNNFI
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F40", Offset = "0x7C3140", VA = "0x1807C3F40")]
	public IIAOHCKJNFP()
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
