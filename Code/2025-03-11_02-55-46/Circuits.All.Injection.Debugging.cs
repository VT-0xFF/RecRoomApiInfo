using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LBADALPJOGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class ACFJFNHMEBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public BNOKINAHBNJ logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public ACFJFNHMEBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x255E9D0", Offset = "0x255DDD0", VA = "0x18255E9D0")]
		internal bool IFACMMPMBOK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x255EA20", Offset = "0x255DE20", VA = "0x18255EA20")]
		internal void JOBJIAOLAEH(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x255E920", Offset = "0x255DD20", VA = "0x18255E920")]
		internal bool HOHMELEDOLN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x255E7C0", Offset = "0x255DBC0", VA = "0x18255E7C0")]
		internal void ABHEMLGGLFN(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x255EAD0", Offset = "0x255DED0", VA = "0x18255EAD0")]
		internal bool LPNADEPBHDD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x255E870", Offset = "0x255DC70", VA = "0x18255E870")]
		internal void BAMPFFBAMMH(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly POKGHDLKLOL AJPLFLPAHGP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x255F440", Offset = "0x255E840", VA = "0x18255F440")]
	private static ABLGJAKKLME NAJAIFNNFAE(BNOKINAHBNJ DIBLNLFOHAF)
	{
		return default(ABLGJAKKLME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x255EB80", Offset = "0x255DF80", VA = "0x18255EB80")]
	private static POKGHDLKLOL HPEDIOGFHAA()
	{
		return default(POKGHDLKLOL);
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
