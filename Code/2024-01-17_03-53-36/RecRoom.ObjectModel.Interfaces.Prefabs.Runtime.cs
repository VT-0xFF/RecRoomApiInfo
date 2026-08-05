using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HGDLHGKIAAN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHMLHIDMEFL(AILCPGEEFDG GHLJMGMIJJK, FOOJINEPLFM BHIACDNNPOM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(AILCPGEEFDG, ComponentTypeList, DILKDLLFDGF)> BLGDGMHDEOJ(OFHLPPJPPBD DHEBKCLNNFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void DILKDLLFDGF(AILCPGEEFDG GHLJMGMIJJK, FOOJINEPLFM BHIACDNNPOM);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FOOJINEPLFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity NIELJJHKFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager HGAJDDKIMHE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x216C470", Offset = "0x216B270", VA = "0x18216C470")]
	public FOOJINEPLFM(Entity NIELJJHKFLG, EntityManager HGAJDDKIMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x25B8ED0", Offset = "0x25B7CD0", VA = "0x1825B8ED0")]
	public void COLNBMOOCNM<T>(T MBDKMNBCLGF) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x25B9170", Offset = "0x25B7F70", VA = "0x1825B9170")]
	public void IKJGHBAOJCB<T>(T MBDKMNBCLGF) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60B1EE0", Offset = "0x60B0CE0", VA = "0x1860B1EE0")]
	public void FGIEBGNNBNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OFHLPPJPPBD
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(HEGAFJHKMAG, AILCPGEEFDG)> FCKLLEFHCGF();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class NOOKEDBHFJN : KCIILHAHFBL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x79E100", Offset = "0x79CF00", VA = "0x18079E100")]
	public NOOKEDBHFJN()
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
