using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EKIBHOBLILG
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class OADAAMIPKBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public JHJMJFFJEOO logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public OADAAMIPKBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x69FD870", Offset = "0x69FC270", VA = "0x1869FD870")]
		internal bool <MakeLogDelegates>b__0()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x69FD8D0", Offset = "0x69FC2D0", VA = "0x1869FD8D0")]
		internal void <MakeLogDelegates>b__1(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x69FD980", Offset = "0x69FC380", VA = "0x1869FD980")]
		internal bool <MakeLogDelegates>b__2()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69FDA40", Offset = "0x69FC440", VA = "0x1869FDA40")]
		internal void <MakeLogDelegates>b__3(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69FDAF0", Offset = "0x69FC4F0", VA = "0x1869FDAF0")]
		internal bool <MakeLogDelegates>b__4()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69FDBB0", Offset = "0x69FC5B0", VA = "0x1869FDBB0")]
		internal void <MakeLogDelegates>b__5(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly OMIENLBAECC AGBLMGNNIDO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69FCDA0", Offset = "0x69FB7A0", VA = "0x1869FCDA0")]
	private static ICDJBKHKFDL FBCJAKIIMKK(JHJMJFFJEOO KJHKAEFGNNP)
	{
		return default(ICDJBKHKFDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69FD090", Offset = "0x69FBA90", VA = "0x1869FD090")]
	private static OMIENLBAECC OILKGNAGKNI()
	{
		return default(OMIENLBAECC);
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
