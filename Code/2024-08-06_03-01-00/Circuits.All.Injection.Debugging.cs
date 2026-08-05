using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MNBHACHAKEA
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class MFNMIEICLBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public PHBCBPKFGFE logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public MFNMIEICLBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1F85A40", Offset = "0x1F84040", VA = "0x181F85A40")]
		internal bool EGMGCDCAIHE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1F85BF0", Offset = "0x1F841F0", VA = "0x181F85BF0")]
		internal void MJOPABDGBGA(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1F85B40", Offset = "0x1F84140", VA = "0x181F85B40")]
		internal bool LJGINLODFOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1F85CA0", Offset = "0x1F842A0", VA = "0x181F85CA0")]
		internal void MMCEECPGHKE(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1F85A90", Offset = "0x1F84090", VA = "0x181F85A90")]
		internal bool INJGIDDCFCD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1F85D50", Offset = "0x1F84350", VA = "0x181F85D50")]
		internal void OPILENAOCKK(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly HECCGJLDIAB HHHOBHGDEHO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1F85E00", Offset = "0x1F84400", VA = "0x181F85E00")]
	private static MBJKCKFJKGI LFINNABLBJJ(PHBCBPKFGFE OGKKKNLLFKF)
	{
		return default(MBJKCKFJKGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1F86130", Offset = "0x1F84730", VA = "0x181F86130")]
	private static HECCGJLDIAB LGFGNLBAHBG()
	{
		return default(HECCGJLDIAB);
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
