using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class FBILELGFNMK<TData> : NGACCPLNJOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string OCGNGJODMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData MJHCHFCOEOK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
	public override string CKGPGAAGKNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3DD62F0", Offset = "0x3DD4CF0", VA = "0x183DD62F0")]
	internal FBILELGFNMK(string KFAOBDLOMDC, [In] TData JGCMECODHDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PHDKOJECBPP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x21C0AA0", Offset = "0x21BF4A0", VA = "0x1821C0AA0")]
	public static FBILELGFNMK<BLGMJKLPHOM> GGBAHLJJLHO(string KFAOBDLOMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4D70", Offset = "0x2BD3770", VA = "0x182BD4D70")]
	public static FBILELGFNMK<TData> GGBAHLJJLHO<TData>(string KFAOBDLOMDC, [In] TData JGCMECODHDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HHILHONPNIA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2DD8400", Offset = "0x2DD6E00", VA = "0x182DD8400")]
	public static BCLNLKLFCPB<TOk, OBJIPJOMIPB> PDCDOOPCHEG<TOk>([In] this BCLNLKLFCPB<TOk, OBJIPJOMIPB> BJNJBGHPMEH, string KFAOBDLOMDC)
	{
		return default(BCLNLKLFCPB<TOk, OBJIPJOMIPB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class NGACCPLNJOL : LBGFPGMHGDG, OBJIPJOMIPB, JHLAIJINHDF
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2181BF0", Offset = "0x21805F0", VA = "0x182181BF0")]
	protected NGACCPLNJOL()
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
