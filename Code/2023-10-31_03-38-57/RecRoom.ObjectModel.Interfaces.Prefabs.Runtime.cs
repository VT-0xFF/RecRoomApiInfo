using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LOBOHAAJOKC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBKOKPFHJEO(JMFEOGDEHDH INONPCNKMNK, FHIPBEDIKIE KKJGLJIBMFJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(JMFEOGDEHDH, ComponentTypeList, PPHIMCBHLLA)> EODJAHLIBBA(JGNBMNCOBBD FELCGCIPFKP);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void PPHIMCBHLLA(JMFEOGDEHDH INONPCNKMNK, FHIPBEDIKIE KKJGLJIBMFJ);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FHIPBEDIKIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity FILKDLNBIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager OKJDPAMBACM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x201FF20", Offset = "0x201F320", VA = "0x18201FF20")]
	public FHIPBEDIKIE(Entity FILKDLNBIJH, EntityManager OKJDPAMBACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x236D420", Offset = "0x236C820", VA = "0x18236D420")]
	public void GMFKOPHMECD<T>(T EOHMJBFGDPD) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x236D3A0", Offset = "0x236C7A0", VA = "0x18236D3A0")]
	public void FLGNOCMCBOG<T>(T EOHMJBFGDPD) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5D4CE80", Offset = "0x5D4C280", VA = "0x185D4CE80")]
	public void PGMNAGLBBGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JGNBMNCOBBD
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(AFADFPDANEE, JMFEOGDEHDH)> DCEFFKHOMGF();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class PPBAAGIACHL : ICCFEBIBGCG
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x76D100", Offset = "0x76C500", VA = "0x18076D100")]
	public PPBAAGIACHL()
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
