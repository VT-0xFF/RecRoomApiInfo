using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class OJNHOEIDBOB
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class DPCIMNOGMCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public MCIFGLAOFBP logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public DPCIMNOGMCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xEA3320", Offset = "0xEA2520", VA = "0x180EA3320")]
		internal bool <MakeLogDelegates>b__0()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xEA3380", Offset = "0xEA2580", VA = "0x180EA3380")]
		internal void <MakeLogDelegates>b__1(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xEA3430", Offset = "0xEA2630", VA = "0x180EA3430")]
		internal bool <MakeLogDelegates>b__2()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xEA34F0", Offset = "0xEA26F0", VA = "0x180EA34F0")]
		internal void <MakeLogDelegates>b__3(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xEA35A0", Offset = "0xEA27A0", VA = "0x180EA35A0")]
		internal bool <MakeLogDelegates>b__4()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xEA3660", Offset = "0xEA2860", VA = "0x180EA3660")]
		internal void <MakeLogDelegates>b__5(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly CKKEHIGCHFO HNEIEBONIJN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xEA3E30", Offset = "0xEA3030", VA = "0x180EA3E30")]
	private static JAMLNMKHDFE OHFKCKMFMGF(MCIFGLAOFBP PBFKDCHNBGG)
	{
		return default(JAMLNMKHDFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xEA3710", Offset = "0xEA2910", VA = "0x180EA3710")]
	private static CKKEHIGCHFO DGDHNOEPMJI()
	{
		return default(CKKEHIGCHFO);
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
