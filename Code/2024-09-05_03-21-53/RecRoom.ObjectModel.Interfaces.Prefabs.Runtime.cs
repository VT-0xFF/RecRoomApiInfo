using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IIJPHCMKDOE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJKFAMFAJGB(KFELEOEDBBF DPMCJCFIMPM, FOBBNFKPBFP BCEJBGDCBJD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(KFELEOEDBBF, ComponentTypeList, MPPIHEJPKOG)> CGADKNGMPFG(KKHNJLEOLHD LFHOOGNCFOI);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void MPPIHEJPKOG(KFELEOEDBBF DPMCJCFIMPM, FOBBNFKPBFP BCEJBGDCBJD);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FOBBNFKPBFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity HLKOPNMJGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager PBPLCKDKLPP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x267EBD0", Offset = "0x267D5D0", VA = "0x18267EBD0")]
	public FOBBNFKPBFP(Entity HLKOPNMJGHO, EntityManager PBPLCKDKLPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2C76E10", Offset = "0x2C75810", VA = "0x182C76E10")]
	public void IDPEEMDPGBG<T>(T CLMKDBDPNNH) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2C76D90", Offset = "0x2C75790", VA = "0x182C76D90")]
	public void BEMPMNHCDLI<T>(T CLMKDBDPNNH) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE900", Offset = "0x6CAD300", VA = "0x186CAE900")]
	public void JGCNPBICDLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KKHNJLEOLHD
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(KHHCEDFJMMM, KFELEOEDBBF)> INEDPJBEMLH();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class IJAOHDPGIFA : NDHJEEIONBB
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x16FBD20", Offset = "0x16FA720", VA = "0x1816FBD20")]
	public IJAOHDPGIFA()
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
