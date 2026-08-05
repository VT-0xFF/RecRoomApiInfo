using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class GOPIDPGAJCE<TData> : ODKGPKGHBED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string DCDNDNHHMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData ELDOIBMHPAJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
	public override string OEJBHPKDIJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x445F110", Offset = "0x445E310", VA = "0x18445F110")]
	internal GOPIDPGAJCE(string CBCJFCINKPJ, [In] TData LFDKFEEPNFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EJDOHPMJFGC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2587DB0", Offset = "0x2586FB0", VA = "0x182587DB0")]
	public static GOPIDPGAJCE<HEGEDEFNLEJ> PAJOIGLPBMN(string CBCJFCINKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x304C770", Offset = "0x304B970", VA = "0x18304C770")]
	public static GOPIDPGAJCE<TData> PAJOIGLPBMN<TData>(string CBCJFCINKPJ, [In] TData LFDKFEEPNFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LJFPINHDENE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x334ACA0", Offset = "0x3349EA0", VA = "0x18334ACA0")]
	public static EBOICGKKPAM<TOk, LKEBDJCDIFL> MHBOOONJNFC<TOk>([In] this EBOICGKKPAM<TOk, LKEBDJCDIFL> MLNFAKCEGNM, string CBCJFCINKPJ)
	{
		return default(EBOICGKKPAM<TOk, LKEBDJCDIFL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class ODKGPKGHBED : ENAONJKJOID, LKEBDJCDIFL, MNCKOMAJMKB
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2546420", Offset = "0x2545620", VA = "0x182546420")]
	protected ODKGPKGHBED()
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
