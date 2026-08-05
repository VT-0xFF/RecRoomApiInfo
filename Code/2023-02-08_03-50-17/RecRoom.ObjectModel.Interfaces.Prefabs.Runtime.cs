using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public delegate void LMBACJGJLJD(FIMAOKHBMMB JPILKLCBOKG, Entity DNMNICOEECM, EntityManager ECFOMHOIDDI);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KLDHFAOGDPE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(FIMAOKHBMMB, ComponentTypeList, LMBACJGJLJD)> HDJOIBCEBLM(GALPBDFCHLD ONDFKMMBLDC);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GALPBDFCHLD
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(MKFEGIBJCLL, FIMAOKHBMMB)> PPOGLBJLLAA();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class BLLCBCJEKHF : DCDFAAPOFND
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8A95E0", Offset = "0x8A83E0", VA = "0x1808A95E0")]
	public BLLCBCJEKHF()
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
