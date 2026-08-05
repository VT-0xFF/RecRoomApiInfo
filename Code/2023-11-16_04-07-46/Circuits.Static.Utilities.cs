using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class CBLLDJACKHA<TData> : GIOJECGONFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string OOADICBDJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData ALHHFFKAKHN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
	public override string FNCBJKOJOIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x47EB8F0", Offset = "0x47EA8F0", VA = "0x1847EB8F0")]
	internal CBLLDJACKHA(string NCBOINMNCHO, [In] TData FCLEEDACIMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JGOFEDPGMHB
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1CFF0D0", Offset = "0x1CFE0D0", VA = "0x181CFF0D0")]
	public static CBLLDJACKHA<DBKAPBMMCGK> ANBAJJBGINK(string NCBOINMNCHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x231D780", Offset = "0x231C780", VA = "0x18231D780")]
	public static CBLLDJACKHA<TData> ANBAJJBGINK<TData>(string NCBOINMNCHO, [In] TData FCLEEDACIMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NEFIIAEAIKI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x25FBAE0", Offset = "0x25FAAE0", VA = "0x1825FBAE0")]
	public static CJDJPCEAKND<TOk, ONNOIFLMODG> PGCNBKDMICF<TOk>([In] this CJDJPCEAKND<TOk, ONNOIFLMODG> IEOMMHOPOKN, string NCBOINMNCHO)
	{
		return default(CJDJPCEAKND<TOk, ONNOIFLMODG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class GIOJECGONFO : PKPFPNLKHDF, ONNOIFLMODG, JBBODHKIFJN
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA080", Offset = "0x1CC9080", VA = "0x181CCA080")]
	protected GIOJECGONFO()
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
