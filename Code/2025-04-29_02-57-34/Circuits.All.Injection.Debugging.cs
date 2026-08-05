using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PEKFMOIFEJB
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class AIPEEIGLJEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public GDFDMFMFFAD logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public AIPEEIGLJEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x269E200", Offset = "0x269D600", VA = "0x18269E200")]
		internal bool FJOEONHNMLH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x269E150", Offset = "0x269D550", VA = "0x18269E150")]
		internal void EGLCMMBFOCC(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x269E250", Offset = "0x269D650", VA = "0x18269E250")]
		internal bool LPEHDHOMFAP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x269DFF0", Offset = "0x269D3F0", VA = "0x18269DFF0")]
		internal void AEFDMHJLOEC(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x269E300", Offset = "0x269D700", VA = "0x18269E300")]
		internal bool NNFBKHBJFKN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x269E0A0", Offset = "0x269D4A0", VA = "0x18269E0A0")]
		internal void ALNBDNGCPBA(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly CHFDMMFBDCO IADGMEFIGGI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x269E3B0", Offset = "0x269D7B0", VA = "0x18269E3B0")]
	private static PFJPNDJBJHP CIKLOAAOOON(GDFDMFMFFAD FNLMMCBBDLK)
	{
		return default(PFJPNDJBJHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x269E6E0", Offset = "0x269DAE0", VA = "0x18269E6E0")]
	private static CHFDMMFBDCO LJPHFHMOIPA()
	{
		return default(CHFDMMFBDCO);
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
