using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PHJJDOAHPFI
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class PBMPKPEHJFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public KHNCKODIPDJ logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public PBMPKPEHJFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1CEB180", Offset = "0x1CEA580", VA = "0x181CEB180")]
		internal bool FBCOKAJKFAN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1CEB0D0", Offset = "0x1CEA4D0", VA = "0x181CEB0D0")]
		internal void BAKIABAOGKP(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1CEB1D0", Offset = "0x1CEA5D0", VA = "0x181CEB1D0")]
		internal bool KNGENKJIBOA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1CEB350", Offset = "0x1CEA750", VA = "0x181CEB350")]
		internal void POHNPNMHGDF(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1CEB290", Offset = "0x1CEA690", VA = "0x181CEB290")]
		internal bool NPFLAPOIGLK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1CEB020", Offset = "0x1CEA420", VA = "0x181CEB020")]
		internal void AKOGIPIEHHK(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly BEFIEBENEAK OKALMGBNAPE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1CEB400", Offset = "0x1CEA800", VA = "0x181CEB400")]
	private static FGBHEDLOALH JKMCHBKDLFF(KHNCKODIPDJ POPGJHMJAOH)
	{
		return default(FGBHEDLOALH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1CEB740", Offset = "0x1CEAB40", VA = "0x181CEB740")]
	private static BEFIEBENEAK NKECMPILOLO()
	{
		return default(BEFIEBENEAK);
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
