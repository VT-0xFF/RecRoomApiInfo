using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PHGOFMOGCFH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGLNHDJIIPD(IDEDIMNMLPE MDDJDHCOALA, IHFBLFIPFDF KFDGOPFFIOK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(IDEDIMNMLPE, ComponentTypeList, CIMCONDIMPH)> GGJOEBJNLCH(GAJCNHNFHBA ENMNIMACKPL);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void CIMCONDIMPH(IDEDIMNMLPE MDDJDHCOALA, IHFBLFIPFDF KFDGOPFFIOK);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct IHFBLFIPFDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity PIKIMHFFNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager NKGJNOFNMMD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x25B78F0", Offset = "0x25B5EF0", VA = "0x1825B78F0")]
	public IHFBLFIPFDF(Entity PIKIMHFFNIJ, EntityManager NKGJNOFNMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2BC8080", Offset = "0x2BC6680", VA = "0x182BC8080")]
	public void ECADPABFBJL<T>(T DMNGPNKHPKF) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2BC82A0", Offset = "0x2BC68A0", VA = "0x182BC82A0")]
	public void LNLLDMJKEKB<T>(T DMNGPNKHPKF) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6AFA150", Offset = "0x6AF8750", VA = "0x186AFA150")]
	public void LCIJIKLGOHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GAJCNHNFHBA
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(JNBPIKMLHDI, IDEDIMNMLPE)> KHKAGCNLBOD();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class LOECIAPDBND : JNNEJNBGCCH
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x15163B0", Offset = "0x15149B0", VA = "0x1815163B0")]
	public LOECIAPDBND()
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
