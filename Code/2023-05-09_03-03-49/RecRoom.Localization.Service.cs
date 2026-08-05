using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GLCKFCABCOA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	string MJNLOJALFMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string PLDGCNHJFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LONEAFAJOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Enum)]
public class KHCEIAPNBON : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string HJOHNBGPOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D2880", Offset = "0x7D1280", VA = "0x1807D2880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x847190", Offset = "0x845B90", VA = "0x180847190")]
	public KHCEIAPNBON(string GGDCFAHDLJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Field)]
public class PCNNEGCENHF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string ONBMIOJBCHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7D2880", Offset = "0x7D1280", VA = "0x1807D2880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool POHOADCHJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x80ADB0", Offset = "0x8097B0", VA = "0x18080ADB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x80A4B0", Offset = "0x808EB0", VA = "0x18080A4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x918D70", Offset = "0x917770", VA = "0x180918D70")]
	public PCNNEGCENHF(string MFBGAMJDOKA, bool OCHECLDNNBL = true)
	{
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
