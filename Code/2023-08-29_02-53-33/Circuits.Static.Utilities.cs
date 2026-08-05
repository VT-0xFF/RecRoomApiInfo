using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class ENFHEJLIMCP : GCOABNGNKLA, ODEJFAIDODH, FMOECAIIOJO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2B9DD60", Offset = "0x2B9D160", VA = "0x182B9DD60")]
	protected ENFHEJLIMCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class PIIMOMKBJFG<TData> : ENFHEJLIMCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string GDOICJCLMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData PFGIEBFKMGE;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "7")]
	public override string APIKMAODCDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x26AECF0", Offset = "0x26AE0F0", VA = "0x1826AECF0")]
	internal PIIMOMKBJFG(string HGJHDPGFLKO, in TData KJFNAECAHBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class KGPKBNOAIMN
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FB16D0", Offset = "0x6FB0AD0", VA = "0x186FB16D0")]
	public static PIIMOMKBJFG<GPBBNBCMMCG> OHIOHLNJBHE(string HGJHDPGFLKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x12C99D0", Offset = "0x12C8DD0", VA = "0x1812C99D0")]
	public static PIIMOMKBJFG<TData> OHIOHLNJBHE<TData>(string HGJHDPGFLKO, in TData KJFNAECAHBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KIPEIGGBKHC
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2418080", Offset = "0x2417480", VA = "0x182418080")]
	public static FKHOBCEMFFK<TOk, ODEJFAIDODH> EJJFPOJPCLN<TOk>(this in FKHOBCEMFFK<TOk, ODEJFAIDODH> JCOLBAAGCGE, string HGJHDPGFLKO)
	{
		return default(FKHOBCEMFFK<TOk, ODEJFAIDODH>);
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
