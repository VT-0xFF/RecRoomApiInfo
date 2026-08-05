using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KBGIIGIAHEH
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class FAIJJHEPNLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public DKLMPGHKHFH logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public FAIJJHEPNLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x21062E0", Offset = "0x2104EE0", VA = "0x1821062E0")]
		internal bool DFGEOBACLNF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x21063E0", Offset = "0x2104FE0", VA = "0x1821063E0")]
		internal void FOIJKKEJAIL(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2106490", Offset = "0x2105090", VA = "0x182106490")]
		internal bool KPBDGGEBOKF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2106230", Offset = "0x2104E30", VA = "0x182106230")]
		internal void AEOMLPNDIFG(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2106540", Offset = "0x2105140", VA = "0x182106540")]
		internal bool MJLHMMCKLDE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2106330", Offset = "0x2104F30", VA = "0x182106330")]
		internal void FEOMHOMKOEC(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly LAFOMMJKDEI AAGIFLNDKEI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2106EB0", Offset = "0x2105AB0", VA = "0x182106EB0")]
	private static BAABCOCOIPM EHENLMJCACF(DKLMPGHKHFH DNHMKNMJMBE)
	{
		return default(BAABCOCOIPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x21065F0", Offset = "0x21051F0", VA = "0x1821065F0")]
	private static LAFOMMJKDEI EFEOMNCFMDN()
	{
		return default(LAFOMMJKDEI);
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
