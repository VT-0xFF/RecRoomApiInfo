using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DDFHNHCMPIA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AECMBOJCKCE(HLKLEDFOFOB HCBFDEJPHHJ, NFDPLPECEIF MCNJCGFGJDI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<(HLKLEDFOFOB, ComponentTypeList, IBCPMIKKEBG)> IOGFIHBOHLN(HNGOGMKFMHK DILPHNGODBO);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void IBCPMIKKEBG(HLKLEDFOFOB HCBFDEJPHHJ, NFDPLPECEIF MCNJCGFGJDI);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct NFDPLPECEIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Entity JLCPBIBMCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityManager MDAGMBDMCCO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2251EC0", Offset = "0x2250CC0", VA = "0x182251EC0")]
	public NFDPLPECEIF(Entity JLCPBIBMCCJ, EntityManager MDAGMBDMCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2866070", Offset = "0x2864E70", VA = "0x182866070")]
	public void DFGFKLLLOGA<T>(T MAEBFBHFPDE) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2865FF0", Offset = "0x2864DF0", VA = "0x182865FF0")]
	public void ANEEOHDNAAC<T>(T MAEBFBHFPDE) where T : struct, ISharedComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x61A1D10", Offset = "0x61A0B10", VA = "0x1861A1D10")]
	public void PBBPBFDDEHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HNGOGMKFMHK
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(JIBPCJADACN, HLKLEDFOFOB)> BCPPOMDHEFK();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class KMLINPBCIGM : CMGDOCIHCPF
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C9100", Offset = "0x7C7F00", VA = "0x1807C9100")]
	public KMLINPBCIGM()
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
