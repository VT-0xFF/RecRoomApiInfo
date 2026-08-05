using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KBLLMJDKLMH
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class CJBMHJCEBKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public FGIKIPNBDNO logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public CJBMHJCEBKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x20FB760", Offset = "0x20FA160", VA = "0x1820FB760")]
		internal bool BHJFJCAMGLI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x20FB910", Offset = "0x20FA310", VA = "0x1820FB910")]
		internal void GFEGHAJNBJE(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x20FB7B0", Offset = "0x20FA1B0", VA = "0x1820FB7B0")]
		internal bool DBDEBBOMBAC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x20FB9C0", Offset = "0x20FA3C0", VA = "0x1820FB9C0")]
		internal void HNAIFIOLKJJ(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x20FB860", Offset = "0x20FA260", VA = "0x1820FB860")]
		internal bool GBLGEHEKLAN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x20FBA70", Offset = "0x20FA470", VA = "0x1820FBA70")]
		internal void OPAEEDGKNME(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly MNENPHOBABE DFEEMNKDOMA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x20FBB20", Offset = "0x20FA520", VA = "0x1820FBB20")]
	private static MPCJFPCFBLE CFMBBCJMCOO(FGIKIPNBDNO EHCEJBNFDAP)
	{
		return default(MPCJFPCFBLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x20FBE50", Offset = "0x20FA850", VA = "0x1820FBE50")]
	private static MNENPHOBABE DBJHMKIGPEC()
	{
		return default(MNENPHOBABE);
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
