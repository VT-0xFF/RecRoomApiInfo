using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LAAIABKCFDN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCLCDLFBCHO(EFKHMPACCDB CMPCNPHKCOC, ALJPPMJGLAL ACCHIDDPJFP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(EFKHMPACCDB, ComponentTypeList, NPADEMMKPCB)> EDCKDKONBGP(EKBDBEICDII EMCPDLFGKKA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void NPADEMMKPCB(EFKHMPACCDB CMPCNPHKCOC, ALJPPMJGLAL ACCHIDDPJFP);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct ALJPPMJGLAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity FHDCFAANCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager PFHEMIPIMIH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x22A3DD0", Offset = "0x22A2DD0", VA = "0x1822A3DD0")]
	public ALJPPMJGLAL(Entity FHDCFAANCBM, EntityManager PFHEMIPIMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2D86E70", Offset = "0x2D85E70", VA = "0x182D86E70")]
	public void PCMENIKJJKG<T>(T CFJDHAGGAJO) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2D86DF0", Offset = "0x2D85DF0", VA = "0x182D86DF0")]
	public void MDLHCLGPPHD<T>(T CFJDHAGGAJO) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6250320", Offset = "0x624F320", VA = "0x186250320")]
	public void DICKBNCIPMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EKBDBEICDII
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(MOFBPNJFCKE, EFKHMPACCDB)> OBFBMEMIEKI();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class EEACEPOALJN : MCJPEDFJCPC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB100", Offset = "0x7CA100", VA = "0x1807CB100")]
	public EEACEPOALJN()
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
