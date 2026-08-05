using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HOMKGJGLPHH
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class AODJLOBDCKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public HCKPLALPEPN logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
		public AODJLOBDCKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x729BF70", Offset = "0x729AF70", VA = "0x18729BF70")]
		internal bool AJNIKLBADOE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x729C150", Offset = "0x729B150", VA = "0x18729C150")]
		internal void FNOKBFHOLMK(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x729BFD0", Offset = "0x729AFD0", VA = "0x18729BFD0")]
		internal bool ALLNLEBOGFH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x729C0A0", Offset = "0x729B0A0", VA = "0x18729C0A0")]
		internal void DEIMAMCOGLB(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x729C2B0", Offset = "0x729B2B0", VA = "0x18729C2B0")]
		internal bool PBADLKLPJJG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x729C200", Offset = "0x729B200", VA = "0x18729C200")]
		internal void OGKHMKFKMHM(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly IFJIFHFLDAL PCFKPPACGDB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x729CC30", Offset = "0x729BC30", VA = "0x18729CC30")]
	private static CHJIMMFGJNF MGGEJKOCNMA(HCKPLALPEPN GKBNGGKDBGF)
	{
		return default(CHJIMMFGJNF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x729C380", Offset = "0x729B380", VA = "0x18729C380")]
	private static IFJIFHFLDAL GMJJLHEPBFH()
	{
		return default(IFJIFHFLDAL);
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
