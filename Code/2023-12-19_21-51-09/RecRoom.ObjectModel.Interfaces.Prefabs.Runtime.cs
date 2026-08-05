using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GBGCBCLKLEG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJJEHLLLNKG(LGFPBEODEOP LMBLGMDMJHB, LMFOGDHOHLD EDCOGOFOMHL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(LGFPBEODEOP, ComponentTypeList, OPINLBJDKBA)> GFIBGCEFJHK(AALKPFBHPIK LFFIPIKJPMF);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void OPINLBJDKBA(LGFPBEODEOP LMBLGMDMJHB, LMFOGDHOHLD EDCOGOFOMHL);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LMFOGDHOHLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity BMHPCOMOJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager INPODDDIDHO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x20B07C0", Offset = "0x20AF3C0", VA = "0x1820B07C0")]
	public LMFOGDHOHLD(Entity BMHPCOMOJJA, EntityManager INPODDDIDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2574B60", Offset = "0x2573760", VA = "0x182574B60")]
	public void INLCAGHFLDH<T>(T GCPEEAODAIB) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2574E00", Offset = "0x2573A00", VA = "0x182574E00")]
	public void KHDIIFEFBMN<T>(T GCPEEAODAIB) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6EE0", Offset = "0x5EE5AE0", VA = "0x185EE6EE0")]
	public void HNNAHIFKMKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AALKPFBHPIK
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(DGEEPCMBCIA, LGFPBEODEOP)> BDPJDMDOIMG();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class ENIAMIDCOCA : LFDNJHDOLMF
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x781100", Offset = "0x77FD00", VA = "0x180781100")]
	public ENIAMIDCOCA()
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
