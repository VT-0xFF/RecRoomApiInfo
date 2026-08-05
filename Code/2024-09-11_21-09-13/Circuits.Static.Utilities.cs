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
	[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
	public override string CKGPGAAGKNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3D02A60", Offset = "0x3D01060", VA = "0x183D02A60")]
	internal FBILELGFNMK(string KFAOBDLOMDC, [In] TData JGCMECODHDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PHDKOJECBPP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x211F000", Offset = "0x211D600", VA = "0x18211F000")]
	public static FBILELGFNMK<BLGMJKLPHOM> GGBAHLJJLHO(string KFAOBDLOMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2B1A630", Offset = "0x2B18C30", VA = "0x182B1A630")]
	public static FBILELGFNMK<TData> GGBAHLJJLHO<TData>(string KFAOBDLOMDC, [In] TData JGCMECODHDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HHILHONPNIA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8DC0", Offset = "0x2CF73C0", VA = "0x182CF8DC0")]
	public static BCLNLKLFCPB<TOk, OBJIPJOMIPB> PDCDOOPCHEG<TOk>([In] this BCLNLKLFCPB<TOk, OBJIPJOMIPB> BJNJBGHPMEH, string KFAOBDLOMDC)
	{
		return default(BCLNLKLFCPB<TOk, OBJIPJOMIPB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class NGACCPLNJOL : LBGFPGMHGDG, OBJIPJOMIPB, JHLAIJINHDF
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x20E0300", Offset = "0x20DE900", VA = "0x1820E0300")]
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
