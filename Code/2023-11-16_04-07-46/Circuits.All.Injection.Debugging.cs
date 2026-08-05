using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CHMHPGIEENN
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class BGPOJMDHCCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public CMIINAELBNH logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public BGPOJMDHCCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1C89DB0", Offset = "0x1C88DB0", VA = "0x181C89DB0")]
		internal bool KGCFELAPCDH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1C89E00", Offset = "0x1C88E00", VA = "0x181C89E00")]
		internal void NJACMIFMEAB(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1C89CF0", Offset = "0x1C88CF0", VA = "0x181C89CF0")]
		internal bool DKECBAKBIDI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1C89AD0", Offset = "0x1C88AD0", VA = "0x181C89AD0")]
		internal void ACACBJDJGMH(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1C89C30", Offset = "0x1C88C30", VA = "0x181C89C30")]
		internal bool CJIJDHKOPAP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1C89B80", Offset = "0x1C88B80", VA = "0x181C89B80")]
		internal void APBLABHOAEJ(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly LAKDCIJNKMI NKFKDADGOPA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1C89EB0", Offset = "0x1C88EB0", VA = "0x181C89EB0")]
	private static IDIGKCEIICE COLGJFNLHOC(CMIINAELBNH LBEBGFMGCCF)
	{
		return default(IDIGKCEIICE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1C8A1F0", Offset = "0x1C891F0", VA = "0x181C8A1F0")]
	private static LAKDCIJNKMI KEGDFKPIKGH()
	{
		return default(LAKDCIJNKMI);
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
