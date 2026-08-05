using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PCAOIPAFGJL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NMHLDMOAKGO(FEEGIAELFJM LOMFHENOOIC, GGLEMOGDIAI FKGAKGDMHBK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(FEEGIAELFJM, ComponentTypeList, JHKAHJILPBI)> BMODABEFALB(EOBFMFFHCNI BGAOBLBKKNC);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void JHKAHJILPBI(FEEGIAELFJM LOMFHENOOIC, GGLEMOGDIAI FKGAKGDMHBK);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct GGLEMOGDIAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity FEMCIAKBEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager FINHDKAKKGK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28543A0", Offset = "0x28537A0", VA = "0x1828543A0")]
	public GGLEMOGDIAI(Entity FEMCIAKBEIF, EntityManager FINHDKAKKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2EB03C0", Offset = "0x2EAF7C0", VA = "0x182EB03C0")]
	public void NBJJIKECOBK<T>(T PFKKDHPJFEH) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2EB0340", Offset = "0x2EAF740", VA = "0x182EB0340")]
	public void IKMLNJGCPCB<T>(T PFKKDHPJFEH) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6E65590", Offset = "0x6E64990", VA = "0x186E65590")]
	public void IOMGDIFFAMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EOBFMFFHCNI
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(FBIGPHOIMBB, FEEGIAELFJM)> NLLEONDDBAF();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class IJHDMEGOFNP : KHDMNEKENHC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1970D50", Offset = "0x1970150", VA = "0x181970D50")]
	public IJHDMEGOFNP()
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
