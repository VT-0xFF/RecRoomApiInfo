using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BFLMJCGILJA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJNGCBIGFCA(GNCNNCODHCF OINDNEFNLBC, BHENEGJJHHO PJOJODHMOPM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(GNCNNCODHCF, ComponentTypeList, LDCFBFBOPFD)> LOFAECDODJN(KCJDBGJDBIN PNBABPHIAJE);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void LDCFBFBOPFD(GNCNNCODHCF OINDNEFNLBC, BHENEGJJHHO PJOJODHMOPM);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct BHENEGJJHHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity EIJPPJGEAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager BBGFDBOHPKJ;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x20BE0C0", Offset = "0x20BC8C0", VA = "0x1820BE0C0")]
	public BHENEGJJHHO(Entity EIJPPJGEAJM, EntityManager BBGFDBOHPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x22CA840", Offset = "0x22C9040", VA = "0x1822CA840")]
	public void INHNMALGLOD<T>(T DOLICEBFIPF) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x22CAAE0", Offset = "0x22C92E0", VA = "0x1822CAAE0")]
	public void KHJKJDDGGHN<T>(T DOLICEBFIPF) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5EE53D0", Offset = "0x5EE3BD0", VA = "0x185EE53D0")]
	public void CLBEMGODPMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KCJDBGJDBIN
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(ICDPOAEHPOL, GNCNNCODHCF)> MMCGDHKNIBA();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class BMFFGOGNDMF : LOAGKKLHIFP
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x782100", Offset = "0x780900", VA = "0x180782100")]
	public BMFFGOGNDMF()
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
