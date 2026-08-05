using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class ONNGGILNJJP : BFLIDGJOJDI, MNMNGBCAHAO, AGHPCJDDHII
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2EF8A00", Offset = "0x2EF7000", VA = "0x182EF8A00")]
	protected ONNGGILNJJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class JHBEJEEGBMC<TData> : ONNGGILNJJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string JKDINHEMKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData DFGNNPLGGHA;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
	public override string EIGPMPLDIJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3726170", Offset = "0x3724770", VA = "0x183726170")]
	internal JHBEJEEGBMC(string JIEHBANCLJP, in TData GOMDNNCBLHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HCFHJDIIOAP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7275220", Offset = "0x7273820", VA = "0x187275220")]
	public static JHBEJEEGBMC<DABEAPPDAMA> JBGFDEKBNPE(string JIEHBANCLJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x178E290", Offset = "0x178C890", VA = "0x18178E290")]
	public static JHBEJEEGBMC<TData> JBGFDEKBNPE<TData>(string JIEHBANCLJP, in TData GOMDNNCBLHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MOAOEBMIOHB
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x178E0B0", Offset = "0x178C6B0", VA = "0x18178E0B0")]
	public static EGKNCMFMAMB<TOk, MNMNGBCAHAO> HIFJNOFKKHE<TOk>(this in EGKNCMFMAMB<TOk, MNMNGBCAHAO> PBJDHAKDMFG, string JIEHBANCLJP)
	{
		return default(EGKNCMFMAMB<TOk, MNMNGBCAHAO>);
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
