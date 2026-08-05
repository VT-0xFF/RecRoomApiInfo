using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JAMOOHJKIKM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMGHLBEEIGD(APJHGHONFKE JJJPIBKENDJ, BPNIDDMAPNG MMOBBLLPPNK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(APJHGHONFKE, ComponentTypeList, EBGNOPPOABI)> PGAJDPNBLIA(PMIIFMFOIAJ ANNDDACELHA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void EBGNOPPOABI(APJHGHONFKE JJJPIBKENDJ, BPNIDDMAPNG MMOBBLLPPNK);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct BPNIDDMAPNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity KFLBPHJAJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager BIDAOIBGIKA;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x27FB790", Offset = "0x27FAB90", VA = "0x1827FB790")]
	public BPNIDDMAPNG(Entity KFLBPHJAJJL, EntityManager BIDAOIBGIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2BF6A30", Offset = "0x2BF5E30", VA = "0x182BF6A30")]
	public void MCAKFOHFDBM<T>(T EEPLCHCGAIN) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2BF6C50", Offset = "0x2BF6050", VA = "0x182BF6C50")]
	public void NAACHPNEBNE<T>(T EEPLCHCGAIN) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6EE31C0", Offset = "0x6EE25C0", VA = "0x186EE31C0")]
	public void JDBIDILEEFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PMIIFMFOIAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(KONBFGBHLIN, APJHGHONFKE)> OBMFHOGGBEH();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class LGCIGGGLIFB : MADNEGOOBGO
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x198B2B0", Offset = "0x198A6B0", VA = "0x18198B2B0")]
	public LGCIGGGLIFB()
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
