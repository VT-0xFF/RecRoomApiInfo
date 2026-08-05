using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public delegate void CIICOMNJJDE(CMECOJAJFAB LBEKIEDKPCN, Entity OCMABEPCGDM, EntityManager EJMLDDGCGJO);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NFPGFGDIFCL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(CMECOJAJFAB, MHAFPGDIKFN, CIICOMNJJDE)> EIIBPCNKAPF(OMPFHPKIHIB PNALABGJPMO);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface IKBKLCEIKJI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MHAFPGDIKFN ACEDCJNDAOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	MHAFPGDIKFN LBNMCMPENOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	MHAFPGDIKFN IGABLDGKEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	MHAFPGDIKFN LOPJAKHBFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	MHAFPGDIKFN CFNHDOKDJJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	MHAFPGDIKFN OJGEJKPNFML
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	MHAFPGDIKFN BLPNINBKDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OMPFHPKIHIB
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IKBKLCEIKJI BEBAIMGEABC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(HNGFAHNAKGA, CMECOJAJFAB)> OONOPHGEGGN();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class IOHEPIEKAPF : LDEEMDKGMLN
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public IOHEPIEKAPF()
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
