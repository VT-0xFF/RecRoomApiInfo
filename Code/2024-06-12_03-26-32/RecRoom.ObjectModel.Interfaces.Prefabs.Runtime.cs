using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IKADCBFODGD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IMDAMFOIFJD(KGAFPCDNLAE BNEADFDDBLJ, DOLBOFMMPFG AELELCJBBPC);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(KGAFPCDNLAE, ComponentTypeList, IBCOGDGNNFA)> OCHEHHFLMDO(JLCAALPAGFK MJGPDIKJHJE);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void IBCOGDGNNFA(KGAFPCDNLAE BNEADFDDBLJ, DOLBOFMMPFG AELELCJBBPC);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct DOLBOFMMPFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity NGLCFDBCFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager NJHBFCFCNCD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x252FEB0", Offset = "0x252EAB0", VA = "0x18252FEB0")]
	public DOLBOFMMPFG(Entity NGLCFDBCFFC, EntityManager NJHBFCFCNCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2956BE0", Offset = "0x29557E0", VA = "0x182956BE0")]
	public void CBGDEMCKLAL<T>(T GLMEMJNJKAN) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2956E00", Offset = "0x2955A00", VA = "0x182956E00")]
	public void DILJHBLDEOE<T>(T GLMEMJNJKAN) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69C08E0", Offset = "0x69BF4E0", VA = "0x1869C08E0")]
	public void CGHBJLPIDMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JLCAALPAGFK
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(IPMKGJBCEGN, KGAFPCDNLAE)> FLHFAKAIEEB();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class EMGENKHEMEE : NFNGONMACMA
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x14BF290", Offset = "0x14BDE90", VA = "0x1814BF290")]
	public EMGENKHEMEE()
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
