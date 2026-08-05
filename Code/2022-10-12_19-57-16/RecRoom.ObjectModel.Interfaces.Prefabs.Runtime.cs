using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public delegate void OAICBAFPMDG(IOFCPOJDKFL OHBBEKBPFPH, Entity GDNDJKDEKFN, EntityManager JGGNCNMICJO);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NPOMLBPEKKD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(IOFCPOJDKFL, BCIHOINOBGK, OAICBAFPMDG)> MCCKGNGDJPD(PFBOOACIMCB KBJJNECALFP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LMCNNPNEEFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BCIHOINOBGK IJFJOBFMOEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	BCIHOINOBGK GMBHPGBMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	BCIHOINOBGK LAOGIAIAKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	BCIHOINOBGK EFKGEOHBODD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BCIHOINOBGK CEBACLBJNLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	BCIHOINOBGK LLONECCMPKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	BCIHOINOBGK DHFDECHIELC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PFBOOACIMCB
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	LMCNNPNEEFJ ANPBJOPPILE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(KOILODOMKMM, IOFCPOJDKFL)> IPBMGPMALFC();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class GEGOAFDFLMF : KFLPBOMAPGE
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public GEGOAFDFLMF()
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
