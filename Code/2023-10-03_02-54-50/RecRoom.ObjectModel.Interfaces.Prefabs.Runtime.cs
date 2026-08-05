using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NHDKNOCJODI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PGBHMCGMABM(KNBFLDNEILM FGDLEJGCDOG, LBLEPMNCKJI NPPKBAFACFB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(KNBFLDNEILM, ComponentTypeList, CNFDOFPMGKL)> EDGOPHDDJKB(OJKNCGAFDBJ FNJHIEAKNJO);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void CNFDOFPMGKL(KNBFLDNEILM FGDLEJGCDOG, LBLEPMNCKJI NPPKBAFACFB);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LBLEPMNCKJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity MFFDEAINOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager DHDOKMIFNAD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8570", Offset = "0x1FD6D70", VA = "0x181FD8570")]
	public LBLEPMNCKJI(Entity MFFDEAINOPL, EntityManager DHDOKMIFNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x244D720", Offset = "0x244BF20", VA = "0x18244D720")]
	public void ABNCEPDOIJI<T>(T IFKKLLBODIE) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x244D9C0", Offset = "0x244C1C0", VA = "0x18244D9C0")]
	public void JMNPGGFPGJH<T>(T IFKKLLBODIE) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5D6CC60", Offset = "0x5D6B460", VA = "0x185D6CC60")]
	public void MCHNJJAMJJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OJKNCGAFDBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(DFMGIJCAPCL, KNBFLDNEILM)> NGGKKKEHDBK();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class DKPJFNCINEE : KPKFEINJGIH
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x771100", Offset = "0x76F900", VA = "0x180771100")]
	public DKPJFNCINEE()
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
