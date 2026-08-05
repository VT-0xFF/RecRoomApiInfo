using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class IKOKJDDGOAC : ACKGNKJEADG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Guid PMNICFEDMGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCDB3C0", Offset = "0xCD9BC0", VA = "0x180CDB3C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
	public void Bind(PLNBDHPLFLH OMDHGKPJDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xCE0D90", Offset = "0xCDF590", VA = "0x180CE0D90")]
	public IKOKJDDGOAC(Guid CNMALJMHIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xEA18C0", Offset = "0xEA00C0", VA = "0x180EA18C0")]
	public static IKOKJDDGOAC HHEHBEMBBBF(Guid CNMALJMHIOD)
	{
		return null;
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
