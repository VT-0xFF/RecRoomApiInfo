using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class OHBPHCJMNMC
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class KKKJAFGGPPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public MEIHHKOBOJC logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public KKKJAFGGPPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1F65480", Offset = "0x1F63E80", VA = "0x181F65480")]
		internal bool CIBAEBAJMHG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1F65700", Offset = "0x1F64100", VA = "0x181F65700")]
		internal void LIMMDGHHDOF(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1F654D0", Offset = "0x1F63ED0", VA = "0x181F654D0")]
		internal bool DEFFHPEEOCL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1F657B0", Offset = "0x1F641B0", VA = "0x181F657B0")]
		internal void PECAKCPFFBJ(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1F65590", Offset = "0x1F63F90", VA = "0x181F65590")]
		internal bool KEFFFJBNIDP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1F65650", Offset = "0x1F64050", VA = "0x181F65650")]
		internal void LHPOILPDJNP(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly AOJADKMOBFK MJFJCBEEADM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1F66110", Offset = "0x1F64B10", VA = "0x181F66110")]
	private static LCGCCPHPOMO JJONKILKIKA(MEIHHKOBOJC GECIHBDKJFH)
	{
		return default(LCGCCPHPOMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1F65860", Offset = "0x1F64260", VA = "0x181F65860")]
	private static AOJADKMOBFK BONIFEPLNHO()
	{
		return default(AOJADKMOBFK);
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
