using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public delegate void OPJMAKEOONE(MIJMGOMOBGM PKKAOLKCAGJ, Entity EBOGCLNNJGN, EntityManager KACBFFMHDCF);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KDECOMFEFKC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(MIJMGOMOBGM, LOBFHLEPAGP, OPJMAKEOONE)> GLBDGKNGPCA(NJEAHKKJHJL JFOCGIPFIDL);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NJEAHKKJHJL
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(BKPIKMGJOND, MIJMGOMOBGM)> DMDKGMKGICI();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class LBHLCFIIMFP : MMHNEAAGHNG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public LBHLCFIIMFP()
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
