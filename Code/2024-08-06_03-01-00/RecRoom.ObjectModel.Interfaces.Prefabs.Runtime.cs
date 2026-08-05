using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BOFAEHCOHLP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LCJIHODOFMI(MEMKGEEBKGM LMIHIKMDJBH, IOBAKAGLHIP KMLFHPCOMNM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(MEMKGEEBKGM, ComponentTypeList, MKOFIFONMLE)> LLAHGLPDDEB(DCGOBGAIKHM OPKEMKAFHMF);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void MKOFIFONMLE(MEMKGEEBKGM LMIHIKMDJBH, IOBAKAGLHIP KMLFHPCOMNM);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct IOBAKAGLHIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity PEMPNCNIDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager ELCBIAGEOKB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x25A26A0", Offset = "0x25A0CA0", VA = "0x1825A26A0")]
	public IOBAKAGLHIP(Entity PEMPNCNIDJF, EntityManager ELCBIAGEOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2BABC00", Offset = "0x2BAA200", VA = "0x182BABC00")]
	public void FNIGGHLNDBN<T>(T FEBGGALLBNN) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2BABB80", Offset = "0x2BAA180", VA = "0x182BABB80")]
	public void APLKOFAAAID<T>(T FEBGGALLBNN) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6AA2550", Offset = "0x6AA0B50", VA = "0x186AA2550")]
	public void AJJEODDGAPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DCGOBGAIKHM
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(KKIGPGIMOPI, MEMKGEEBKGM)> PBNJKADJBPB();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class DKNBPIAPDNP : APLCPBPAMAE
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x15B7D00", Offset = "0x15B6300", VA = "0x1815B7D00")]
	public DKNBPIAPDNP()
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
