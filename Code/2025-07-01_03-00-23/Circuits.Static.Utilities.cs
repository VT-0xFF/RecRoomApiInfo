using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class EHGOHMMIFNE<TData> : CKEJBHKCKAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string FMPMDNIMCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData IKFGCCPLOBI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
	public override string GNDOFJNNOIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4785A20", Offset = "0x4784020", VA = "0x184785A20")]
	internal EHGOHMMIFNE(string CJIMOMNMAGD, [In] TData ACJFHCNBBBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class AEJEGEOKDKE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x29FB1B0", Offset = "0x29F97B0", VA = "0x1829FB1B0")]
	public static EHGOHMMIFNE<DICNEKFFPEP> BFOPDLPDKBM(string CJIMOMNMAGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x30ACE80", Offset = "0x30AB480", VA = "0x1830ACE80")]
	public static EHGOHMMIFNE<TData> BFOPDLPDKBM<TData>(string CJIMOMNMAGD, [In] TData ACJFHCNBBBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class BFCINCJNNFN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x38B5A00", Offset = "0x38B4000", VA = "0x1838B5A00")]
	public static FANMKCKHALG<TOk, GNLHMHNEEGO> BGMKFFGIDCM<TOk>([In] this FANMKCKHALG<TOk, GNLHMHNEEGO> PIKMBNLEPPK, string CJIMOMNMAGD)
	{
		return default(FANMKCKHALG<TOk, GNLHMHNEEGO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class CKEJBHKCKAO : PELIOLHOEHA, GNLHMHNEEGO, KNIOCFDMLBC
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x29B4360", Offset = "0x29B2960", VA = "0x1829B4360")]
	protected CKEJBHKCKAO()
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
