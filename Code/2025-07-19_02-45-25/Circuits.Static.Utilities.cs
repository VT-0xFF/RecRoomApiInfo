using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class DAFCGHPDBGH<TData> : NFLHKGJKCPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string PKCPPLKFBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData FGNOGEEOKID;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
	public override string OFBAEHEOPOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6E6BE10", Offset = "0x6E6AE10", VA = "0x186E6BE10")]
	internal DAFCGHPDBGH(string OBCNAJEENCI, [In] TData INCJDDLACNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class FBNHFOBDDBA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2AB0330", Offset = "0x2AAF330", VA = "0x182AB0330")]
	public static DAFCGHPDBGH<GAAICFLNCNK> MPFKOOIPONO(string OBCNAJEENCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x39DD070", Offset = "0x39DC070", VA = "0x1839DD070")]
	public static DAFCGHPDBGH<TData> MPFKOOIPONO<TData>(string OBCNAJEENCI, [In] TData INCJDDLACNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HFFAABLHBFL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3C72510", Offset = "0x3C71510", VA = "0x183C72510")]
	public static DAFIFKKNPFP<TOk, AGMCGONFHKP> CIMMFPGANNC<TOk>([In] this DAFIFKKNPFP<TOk, AGMCGONFHKP> OLHDOIOOPGE, string OBCNAJEENCI)
	{
		return default(DAFIFKKNPFP<TOk, AGMCGONFHKP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class NFLHKGJKCPB : JFHNFKOLNEJ, AGMCGONFHKP, BJPMMCEJAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A67AD0", Offset = "0x2A66AD0", VA = "0x182A67AD0")]
	protected NFLHKGJKCPB()
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
