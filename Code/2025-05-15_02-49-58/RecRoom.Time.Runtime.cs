using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class OHLPDEEKBCL : CFFBBPKENGE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public DateTime JDNILLIMBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8717120", Offset = "0x8715720", VA = "0x188717120", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float OJMJBBKEHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x11E6500", Offset = "0x11E4B00", VA = "0x1811E6500", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	[Preserve]
	internal OHLPDEEKBCL()
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
