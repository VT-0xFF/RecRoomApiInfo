using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class NPFOIEKIIEE<TData> : BCBJAFAHBED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string MPIOCLAPHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData COKNLHIJAIB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "7")]
	public override string FGIPLPDCCEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x453AB20", Offset = "0x4539720", VA = "0x18453AB20")]
	internal NPFOIEKIIEE(string NKAJDDICLFH, [In] TData JGFKFMMOAJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NALOEOOFDIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x203D3A0", Offset = "0x203BFA0", VA = "0x18203D3A0")]
	public static NPFOIEKIIEE<HGAAMJINHPI> FCDPFGJNKNI(string NKAJDDICLFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2B38FF0", Offset = "0x2B37BF0", VA = "0x182B38FF0")]
	public static NPFOIEKIIEE<TData> FCDPFGJNKNI<TData>(string NKAJDDICLFH, [In] TData JGFKFMMOAJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LPPFODIGFCM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2C20070", Offset = "0x2C1EC70", VA = "0x182C20070")]
	public static NLDGPBPIIJN<TOk, MFMODGJHEIL> LLFDJDNBNAO<TOk>([In] this NLDGPBPIIJN<TOk, MFMODGJHEIL> ENEDBNLKLJL, string NKAJDDICLFH)
	{
		return default(NLDGPBPIIJN<TOk, MFMODGJHEIL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class BCBJAFAHBED : LGLBGBDJHMM, MFMODGJHEIL, MLPOHKBMKMA
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FFCC70", Offset = "0x1FFB870", VA = "0x181FFCC70")]
	protected BCBJAFAHBED()
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
