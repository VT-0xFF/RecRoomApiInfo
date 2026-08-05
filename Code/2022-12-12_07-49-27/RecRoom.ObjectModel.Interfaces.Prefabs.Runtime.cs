using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public delegate void KPCPJNHBGBE(HLEPLICHNKK IGDDGFIHFCA, Entity FLADPKIONGF, EntityManager LNPEGOPJJGK);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ECJOKHEDOAA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(HLEPLICHNKK, ODIEFIPMBGL, KPCPJNHBGBE)> PKAJKBCMFDA(MCHHLOEOAAJ EJCAANKBGPG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MCHHLOEOAAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(KFKBMIIJOHI, HLEPLICHNKK)> IGFEMMPCLOO();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class LKHEIKPBOME : EIOKMAELDBG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x779A60", Offset = "0x778060", VA = "0x180779A60")]
	public LKHEIKPBOME()
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
