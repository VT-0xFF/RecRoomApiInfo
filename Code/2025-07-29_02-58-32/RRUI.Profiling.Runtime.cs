using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KMIKFBLKAEP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly BDLOKINEGIJ MDIDCHAOBJK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static BDLOKINEGIJ HMAKNAAMMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8FCB830", Offset = "0x8FCA230", VA = "0x188FCB830")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct MMFNNFLOPBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public int CBIJFBFKIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public int JFNOOJLPPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public int LCEPPKOLJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int MMJLJKPJLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int BDOGBELMOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int AAOPNIDAFDM;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ONNPJGMMDCO
{
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
