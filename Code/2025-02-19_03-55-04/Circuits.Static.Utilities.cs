using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class BOEBKGLNJLL<TData> : HJOMFIPJJDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string JMJNOKCIMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData JBDHCGELIFD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
	public override string CNPDCBKGCII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x581FCC0", Offset = "0x581E8C0", VA = "0x18581FCC0")]
	internal BOEBKGLNJLL(string KBPDEFFIKOJ, [In] TData LLDJIJICLJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OJAEPFFFLOM
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x25A8590", Offset = "0x25A7190", VA = "0x1825A8590")]
	public static BOEBKGLNJLL<BODKGJBCKHC> JPHABLICNHB(string KBPDEFFIKOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x30E9000", Offset = "0x30E7C00", VA = "0x1830E9000")]
	public static BOEBKGLNJLL<TData> JPHABLICNHB<TData>(string KBPDEFFIKOJ, [In] TData LLDJIJICLJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NBKGGAHJOHN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x34D71F0", Offset = "0x34D5DF0", VA = "0x1834D71F0")]
	public static PNJEPLMEKHI<TOk, GEJJJMKDLKA> JNNKEKLIPDE<TOk>([In] this PNJEPLMEKHI<TOk, GEJJJMKDLKA> DKGDAEBOJKO, string KBPDEFFIKOJ)
	{
		return default(PNJEPLMEKHI<TOk, GEJJJMKDLKA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class HJOMFIPJJDB : KLJHHNJNNDG, GEJJJMKDLKA, PKJJHJMDMCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x25681E0", Offset = "0x2566DE0", VA = "0x1825681E0")]
	protected HJOMFIPJJDB()
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
