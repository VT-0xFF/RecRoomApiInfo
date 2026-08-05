using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HJGANNBFMPB
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class DIDCLOCBDMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public IJMBKFAKMBJ logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public DIDCLOCBDMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7A90", Offset = "0x6FC6090", VA = "0x186FC7A90")]
		internal bool EJMBOLEGJAK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7C70", Offset = "0x6FC6270", VA = "0x186FC7C70")]
		internal void OCEIAKOANCA(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7910", Offset = "0x6FC5F10", VA = "0x186FC7910")]
		internal bool AJDJAPNOHEE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7AF0", Offset = "0x6FC60F0", VA = "0x186FC7AF0")]
		internal void JIDHLNPILFJ(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7BA0", Offset = "0x6FC61A0", VA = "0x186FC7BA0")]
		internal bool KDDFLNIKIEJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC79E0", Offset = "0x6FC5FE0", VA = "0x186FC79E0")]
		internal void EEEBGIHIOIG(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly KAOFBHABMJC HAMPJMKDJOL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FC85D0", Offset = "0x6FC6BD0", VA = "0x186FC85D0")]
	private static JGGPPBGFMPG MPEJGJGLOLL(IJMBKFAKMBJ HFDHFJBHGFA)
	{
		return default(JGGPPBGFMPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FC7D20", Offset = "0x6FC6320", VA = "0x186FC7D20")]
	private static KAOFBHABMJC GDIGKGFJAAF()
	{
		return default(KAOFBHABMJC);
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
