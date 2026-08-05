using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PCAPNCEMGNC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NICPHAFECOA(ILMCDCGEOPC CCAOKKILBOM, FDKIMAGAPLG MKFEEDKFABP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(ILMCDCGEOPC, ComponentTypeList, JMNKOMAOELA)> JBADFELNHCM(FGDJJOLJALF CLEKEDNIBLB);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void JMNKOMAOELA(ILMCDCGEOPC CCAOKKILBOM, FDKIMAGAPLG MKFEEDKFABP);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FDKIMAGAPLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity KCMPKMKBCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager IDCNBIGHJII;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1FDA380", Offset = "0x1FD8B80", VA = "0x181FDA380")]
	public FDKIMAGAPLG(Entity KCMPKMKBCOO, EntityManager IDCNBIGHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x234F040", Offset = "0x234D840", VA = "0x18234F040")]
	public void NLGFMFNDGBJ<T>(T FKKGMPDEPMA) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x234EFC0", Offset = "0x234D7C0", VA = "0x18234EFC0")]
	public void JCPHMFADBKC<T>(T FKKGMPDEPMA) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5DA5400", Offset = "0x5DA3C00", VA = "0x185DA5400")]
	public void ADAOOLBGMFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FGDJJOLJALF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(IHOKJCEFOEN, ILMCDCGEOPC)> DKPHGGOAJNH();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class DBLDNICLIJB : LCBKPFMJPPL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770900", VA = "0x180772100")]
	public DBLDNICLIJB()
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
