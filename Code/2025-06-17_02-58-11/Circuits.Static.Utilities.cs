using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class BHHHMDBENBL<TData> : NNALLDHJADJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string PGOOIHNHDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData JLKLNDPHPHM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
	public override string BKOEAJIGHJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x61154E0", Offset = "0x6113EE0", VA = "0x1861154E0")]
	internal BHHHMDBENBL(string IJOJGNJMCGP, [In] TData HPGIDELCODH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PJCCGHPAOML
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2960000", Offset = "0x295EA00", VA = "0x182960000")]
	public static BHHHMDBENBL<NOHGHNIBNOG> FMDOFBCLPJB(string IJOJGNJMCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3000800", Offset = "0x2FFF200", VA = "0x183000800")]
	public static BHHHMDBENBL<TData> FMDOFBCLPJB<TData>(string IJOJGNJMCGP, [In] TData HPGIDELCODH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FCNGODKLGGN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3A47F60", Offset = "0x3A46960", VA = "0x183A47F60")]
	public static KAFLOHEKGBO<TOk, EOIBCJECGDC> MNGEANPKHLG<TOk>([In] this KAFLOHEKGBO<TOk, EOIBCJECGDC> NMEFAPBBOCD, string IJOJGNJMCGP)
	{
		return default(KAFLOHEKGBO<TOk, EOIBCJECGDC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class NNALLDHJADJ : GJIFJLKDAGC, EOIBCJECGDC, NCGHLGNIAEG
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x291C210", Offset = "0x291AC10", VA = "0x18291C210")]
	protected NNALLDHJADJ()
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
