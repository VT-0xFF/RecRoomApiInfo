using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class EHNDBDNHPIC<TData> : PBKMDGOJDEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string GMJKGFMAAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData EELMKJIGLGI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
	public override string ECJFEDANMLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3B98880", Offset = "0x3B97C80", VA = "0x183B98880")]
	internal EHNDBDNHPIC(string NFKMLKNHFEM, [In] TData EIFGKHNPLEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class IJGDNIEDLKL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x22E03D0", Offset = "0x22DF7D0", VA = "0x1822E03D0")]
	public static EHNDBDNHPIC<FHMPKELNMGN> GIIIFAJNKEL(string NFKMLKNHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2CDE720", Offset = "0x2CDDB20", VA = "0x182CDE720")]
	public static EHNDBDNHPIC<TData> GIIIFAJNKEL<TData>(string NFKMLKNHFEM, [In] TData EIFGKHNPLEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DFJCJFDDING
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2CE2440", Offset = "0x2CE1840", VA = "0x182CE2440")]
	public static BMFECDODLAB<TOk, JLOPLHOLGBP> ANKELOJNLDH<TOk>([In] this BMFECDODLAB<TOk, JLOPLHOLGBP> EAFEIEDNLNL, string NFKMLKNHFEM)
	{
		return default(BMFECDODLAB<TOk, JLOPLHOLGBP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class PBKMDGOJDEJ : MBCBLBGJNJI, JLOPLHOLGBP, JPIHCAEEFCD
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x229FCB0", Offset = "0x229F0B0", VA = "0x18229FCB0")]
	protected PBKMDGOJDEJ()
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
