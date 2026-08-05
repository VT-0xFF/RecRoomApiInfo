using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LIAFIHOPLIK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(LCMPCAIJMDL, DGAJAJLJOIP)> NLDNCEPANFM();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class)]
public class BJEJPKFJHPF : FLIAAMNMIFP
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9CACE0", Offset = "0x9C9CE0", VA = "0x1809CACE0")]
	public BJEJPKFJHPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OHMKDEEFIJL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LNAMHOJKJJB(DGAJAJLJOIP LAABEELPEOO, LJDLKBEBEMC MMIFPMJFGHL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(DGAJAJLJOIP, ComponentTypeList, EJGEOPPOBKJ)> GOEJOOADFPJ(LIAFIHOPLIK JJJBGAPEFGH);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void EJGEOPPOBKJ(DGAJAJLJOIP LAABEELPEOO, LJDLKBEBEMC MMIFPMJFGHL);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct LJDLKBEBEMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity OIDNDCEGFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager DKCFIIHAPKN;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x20DBC10", Offset = "0x20DAC10", VA = "0x1820DBC10")]
	public LJDLKBEBEMC(Entity OIDNDCEGFCN, EntityManager DKCFIIHAPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2358380", Offset = "0x2357380", VA = "0x182358380")]
	public void FNPACIDIMCD<T>(T CKMKMNKGMMC) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2358460", Offset = "0x2357460", VA = "0x182358460")]
	public void HMINDGFICAO<T>(T CKMKMNKGMMC) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72CD360", Offset = "0x72CC360", VA = "0x1872CD360")]
	public void LLMHPBKHOPH()
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
