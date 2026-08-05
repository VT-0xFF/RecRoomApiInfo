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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public CJBMHJCEBKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x205A870", Offset = "0x2058E70", VA = "0x18205A870")]
		internal bool BHJFJCAMGLI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x205AA20", Offset = "0x2059020", VA = "0x18205AA20")]
		internal void GFEGHAJNBJE(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x205A8C0", Offset = "0x2058EC0", VA = "0x18205A8C0")]
		internal bool DBDEBBOMBAC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x205AAD0", Offset = "0x20590D0", VA = "0x18205AAD0")]
		internal void HNAIFIOLKJJ(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x205A970", Offset = "0x2058F70", VA = "0x18205A970")]
		internal bool GBLGEHEKLAN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x205AB80", Offset = "0x2059180", VA = "0x18205AB80")]
		internal void OPAEEDGKNME(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly MNENPHOBABE DFEEMNKDOMA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x205AC30", Offset = "0x2059230", VA = "0x18205AC30")]
	private static MPCJFPCFBLE CFMBBCJMCOO(FGIKIPNBDNO EHCEJBNFDAP)
	{
		return default(MPCJFPCFBLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x205AF60", Offset = "0x2059560", VA = "0x18205AF60")]
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
