using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IJPBLAHKLDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class ABLGEGBBBOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public MMDOEEFOKJE logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public ABLGEGBBBOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x668DBA0", Offset = "0x668CBA0", VA = "0x18668DBA0")]
		internal bool <MakeLogDelegates>b__0()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x668DC00", Offset = "0x668CC00", VA = "0x18668DC00")]
		internal void <MakeLogDelegates>b__1(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x668DCB0", Offset = "0x668CCB0", VA = "0x18668DCB0")]
		internal bool <MakeLogDelegates>b__2()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x668DD70", Offset = "0x668CD70", VA = "0x18668DD70")]
		internal void <MakeLogDelegates>b__3(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x668DE20", Offset = "0x668CE20", VA = "0x18668DE20")]
		internal bool <MakeLogDelegates>b__4()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x668DEE0", Offset = "0x668CEE0", VA = "0x18668DEE0")]
		internal void <MakeLogDelegates>b__5(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly IAKMNHKAOPB FDNKALDKIIB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x668E600", Offset = "0x668D600", VA = "0x18668E600")]
	private static AFDHFIMBHFJ GBAAOCEGEIM(MMDOEEFOKJE FHLMFMHEANJ)
	{
		return default(AFDHFIMBHFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x668DF90", Offset = "0x668CF90", VA = "0x18668DF90")]
	private static IAKMNHKAOPB BKEBPNPMFMM()
	{
		return default(IAKMNHKAOPB);
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
