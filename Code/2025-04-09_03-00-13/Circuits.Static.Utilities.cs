using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class BINEHOAJCJP<TData> : IOLFOONCHKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string FOLBMPKOGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData EEHHJHNNGPO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
	public override string JIBLDGHIHFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5F259D0", Offset = "0x5F24DD0", VA = "0x185F259D0")]
	internal BINEHOAJCJP(string DAMFJFKKFBI, [In] TData HPMNBNLACCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BKEINCEJCDL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x26ED820", Offset = "0x26ECC20", VA = "0x1826ED820")]
	public static BINEHOAJCJP<LPCAMBCOBBH> HBLBJMFGHFK(string DAMFJFKKFBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x339B040", Offset = "0x339A440", VA = "0x18339B040")]
	public static BINEHOAJCJP<TData> HBLBJMFGHFK<TData>(string DAMFJFKKFBI, [In] TData HPMNBNLACCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CJCICHLPBBB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x33FFB30", Offset = "0x33FEF30", VA = "0x1833FFB30")]
	public static KGPHFOFOMPJ<TOk, HEGOEPNOLEN> PONKIHLPCGP<TOk>([In] this KGPHFOFOMPJ<TOk, HEGOEPNOLEN> JOCJBPPJMJJ, string DAMFJFKKFBI)
	{
		return default(KGPHFOFOMPJ<TOk, HEGOEPNOLEN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class IOLFOONCHKI : ADGPAJEIFGP, HEGOEPNOLEN, ALOCPDILHNE
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x26AC470", Offset = "0x26AB870", VA = "0x1826AC470")]
	protected IOLFOONCHKI()
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
