using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class OFCGCKEOFBL<TData> : JMMAFLLBCOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string DIJFEMNHICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData GLBGLIBCAOD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
	public override string MMDDBBBPGKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4B80680", Offset = "0x4B7FA80", VA = "0x184B80680")]
	internal OFCGCKEOFBL(string LNICHECHJFC, [In] TData JGCOLLOOLHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MLDFAJBCIPO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2399C60", Offset = "0x2399060", VA = "0x182399C60")]
	public static OFCGCKEOFBL<ALHKDJHEAFJ> ODOFIFAGLAJ(string LNICHECHJFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2E46D50", Offset = "0x2E46150", VA = "0x182E46D50")]
	public static OFCGCKEOFBL<TData> ODOFIFAGLAJ<TData>(string LNICHECHJFC, [In] TData JGCOLLOOLHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class EPMPHLJIEJD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2EC1540", Offset = "0x2EC0940", VA = "0x182EC1540")]
	public static ABNAGONECLM<TOk, IAAGGMEHHFI> BFFIDEKBFOP<TOk>([In] this ABNAGONECLM<TOk, IAAGGMEHHFI> MPLBPEBNKFP, string LNICHECHJFC)
	{
		return default(ABNAGONECLM<TOk, IAAGGMEHHFI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class JMMAFLLBCOF : PJPEMJHFJLC, IAAGGMEHHFI, NAONGKGFBLO
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x235A5F0", Offset = "0x23599F0", VA = "0x18235A5F0")]
	protected JMMAFLLBCOF()
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
