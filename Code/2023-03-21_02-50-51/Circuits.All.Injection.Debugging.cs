using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KPHEIJLEOLK
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class IOOGCELHJOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public JHONFPAIDLA logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public IOOGCELHJOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xE8FF80", Offset = "0xE8E780", VA = "0x180E8FF80")]
		internal bool <MakeLogDelegates>b__0()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xE8FFE0", Offset = "0xE8E7E0", VA = "0x180E8FFE0")]
		internal void <MakeLogDelegates>b__1(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xE90090", Offset = "0xE8E890", VA = "0x180E90090")]
		internal bool <MakeLogDelegates>b__2()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE90150", Offset = "0xE8E950", VA = "0x180E90150")]
		internal void <MakeLogDelegates>b__3(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xE90200", Offset = "0xE8EA00", VA = "0x180E90200")]
		internal bool <MakeLogDelegates>b__4()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE902C0", Offset = "0xE8EAC0", VA = "0x180E902C0")]
		internal void <MakeLogDelegates>b__5(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly LFPEMJPEJLL PDCOCJBICGC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xE909E0", Offset = "0xE8F1E0", VA = "0x180E909E0")]
	private static LHPLNPIOLFB FEECFCNKOCA(JHONFPAIDLA DAFOPJEJJBL)
	{
		return default(LHPLNPIOLFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xE90370", Offset = "0xE8EB70", VA = "0x180E90370")]
	private static LFPEMJPEJLL FCLNDDLJOHN()
	{
		return default(LFPEMJPEJLL);
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
