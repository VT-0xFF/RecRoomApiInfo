using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FKIONHGCPAH
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class OCLDCACFKMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public IAPDJFOCNPM logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public OCLDCACFKMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1FAAB50", Offset = "0x1FA9B50", VA = "0x181FAAB50")]
		internal bool MACJFNIMDNG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA9E0", Offset = "0x1FA99E0", VA = "0x181FAA9E0")]
		internal void JPIGGGAACCO(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA870", Offset = "0x1FA9870", VA = "0x181FAA870")]
		internal bool GHHFLGAHIJG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA7C0", Offset = "0x1FA97C0", VA = "0x181FAA7C0")]
		internal void GDPGNAEEICI(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1FAAA90", Offset = "0x1FA9A90", VA = "0x181FAAA90")]
		internal bool LADHLLKDNDN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1FAA930", Offset = "0x1FA9930", VA = "0x181FAA930")]
		internal void JLLJMKLLEHK(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly PHPJDLLGMIB PNNELGGLBHA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1FAA310", Offset = "0x1FA9310", VA = "0x181FAA310")]
	private static FAECHCHMHFD LCJJJFLMEOE(IAPDJFOCNPM PGNCAELKNKP)
	{
		return default(FAECHCHMHFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1FA9A60", Offset = "0x1FA8A60", VA = "0x181FA9A60")]
	private static PHPJDLLGMIB CEALPFLGPHM()
	{
		return default(PHPJDLLGMIB);
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
