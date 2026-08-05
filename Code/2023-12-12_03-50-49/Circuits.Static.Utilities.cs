using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class JKNHKAEFLEN<TData> : IJJELFILJOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string PPBOJGLMBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData GKMCBGMNDLA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "7")]
	public override string PJMGMONBGLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x38A5550", Offset = "0x38A3D50", VA = "0x1838A5550")]
	internal JKNHKAEFLEN(string OLDFIJBKFKG, [In] TData FCHBDAMJEHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LKMOMPIDCCN
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1D11950", Offset = "0x1D10150", VA = "0x181D11950")]
	public static JKNHKAEFLEN<EGJHPKNOBOC> AKKFLOCCMNP(string OLDFIJBKFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2329A70", Offset = "0x2328270", VA = "0x182329A70")]
	public static JKNHKAEFLEN<TData> AKKFLOCCMNP<TData>(string OLDFIJBKFKG, [In] TData FCHBDAMJEHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MPGJLKJAPHF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x25AF2C0", Offset = "0x25ADAC0", VA = "0x1825AF2C0")]
	public static LBFOJMHFNLD<TOk, AABCOILMPHO> NCLINKNDGBH<TOk>([In] this LBFOJMHFNLD<TOk, AABCOILMPHO> PIEBBHMNEOG, string OLDFIJBKFKG)
	{
		return default(LBFOJMHFNLD<TOk, AABCOILMPHO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class IJJELFILJOP : CLJHHCKGBLK, AABCOILMPHO, NFLDLKGILAB
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1CDC0B0", Offset = "0x1CDA8B0", VA = "0x181CDC0B0")]
	protected IJJELFILJOP()
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
