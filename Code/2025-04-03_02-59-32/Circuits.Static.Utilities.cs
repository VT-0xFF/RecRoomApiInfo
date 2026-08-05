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
	[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
	public override string JIBLDGHIHFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5F40080", Offset = "0x5F3F480", VA = "0x185F40080")]
	internal BINEHOAJCJP(string DAMFJFKKFBI, [In] TData HPMNBNLACCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BKEINCEJCDL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x26EC0D0", Offset = "0x26EB4D0", VA = "0x1826EC0D0")]
	public static BINEHOAJCJP<LPCAMBCOBBH> HBLBJMFGHFK(string DAMFJFKKFBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3385030", Offset = "0x3384430", VA = "0x183385030")]
	public static BINEHOAJCJP<TData> HBLBJMFGHFK<TData>(string DAMFJFKKFBI, [In] TData HPMNBNLACCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CJCICHLPBBB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x33EB930", Offset = "0x33EAD30", VA = "0x1833EB930")]
	public static KGPHFOFOMPJ<TOk, HEGOEPNOLEN> PONKIHLPCGP<TOk>([In] this KGPHFOFOMPJ<TOk, HEGOEPNOLEN> JOCJBPPJMJJ, string DAMFJFKKFBI)
	{
		return default(KGPHFOFOMPJ<TOk, HEGOEPNOLEN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class IOLFOONCHKI : ADGPAJEIFGP, HEGOEPNOLEN, ALOCPDILHNE
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x26A91A0", Offset = "0x26A85A0", VA = "0x1826A91A0")]
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
