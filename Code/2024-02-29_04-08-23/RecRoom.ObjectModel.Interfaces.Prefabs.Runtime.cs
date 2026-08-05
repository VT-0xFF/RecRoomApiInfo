using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HPMDDONHAAO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KDACFMMFAKJ(EGPFMLCEFJD MLPCHFIIHMO, KAKHMPDFPGM HIIDENCMOJI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(EGPFMLCEFJD, ComponentTypeList, PHLHNEKOGAO)> CGAGMJHJJKF(CHPENABOIFE EPNALMLDGDN);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void PHLHNEKOGAO(EGPFMLCEFJD MLPCHFIIHMO, KAKHMPDFPGM HIIDENCMOJI);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct KAKHMPDFPGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity KEAAKDKHLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager FAPAMPDMFAG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2215170", Offset = "0x2213F70", VA = "0x182215170")]
	public KAKHMPDFPGM(Entity KEAAKDKHLOM, EntityManager FAPAMPDMFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2770CF0", Offset = "0x276FAF0", VA = "0x182770CF0")]
	public void FOBLAMHLHCD<T>(T NKKIECLCEML) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2770F10", Offset = "0x276FD10", VA = "0x182770F10")]
	public void IGFGJADMNLO<T>(T NKKIECLCEML) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60B7640", Offset = "0x60B6440", VA = "0x1860B7640")]
	public void OIOMCBHJDAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CHPENABOIFE
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(MCEJPAIOHJF, EGPFMLCEFJD)> GCIKODPCCJF();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class FHECGNJHJPH : NBLHBEOGGMJ
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7B9100", Offset = "0x7B7F00", VA = "0x1807B9100")]
	public FHECGNJHJPH()
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
