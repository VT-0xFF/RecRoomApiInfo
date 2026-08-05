using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class GCIKFDBBJED<TData> : AGGGGDAGIKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string EPAABOBMNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData GHKHBJDIPKA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "7")]
	public override string EMIBBFOKDML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x36918F0", Offset = "0x36906F0", VA = "0x1836918F0")]
	internal GCIKFDBBJED(string EMKENBOOEOH, [In] TData OMHIFBJFAGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GAMCEEIBEIP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1DD9DC0", Offset = "0x1DD8BC0", VA = "0x181DD9DC0")]
	public static GCIKFDBBJED<JEGFFGGMBEH> KJKFMOENPNA(string EMKENBOOEOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x25C62C0", Offset = "0x25C50C0", VA = "0x1825C62C0")]
	public static GCIKFDBBJED<TData> KJKFMOENPNA<TData>(string EMKENBOOEOH, [In] TData OMHIFBJFAGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GGBLDCLBAPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x26F3810", Offset = "0x26F2610", VA = "0x1826F3810")]
	public static FBEPHKHKLJE<TOk, BEPKJMJJJMM> HOCPNMLMNEE<TOk>([In] this FBEPHKHKLJE<TOk, BEPKJMJJJMM> CNFBJPGPBBJ, string EMKENBOOEOH)
	{
		return default(FBEPHKHKLJE<TOk, BEPKJMJJJMM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class AGGGGDAGIKE : KOAMPGHKKDA, BEPKJMJJJMM, LNKCFDGMPAP
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1DA1A90", Offset = "0x1DA0890", VA = "0x181DA1A90")]
	protected AGGGGDAGIKE()
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
