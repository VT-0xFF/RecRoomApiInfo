using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LAEKPNBOHDG : KECEFGLCHBO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public DateTime KOKODFPODEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x795C8F0", Offset = "0x795B0F0", VA = "0x18795C8F0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float GGNNPHNHDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD585A0", Offset = "0xD56DA0", VA = "0x180D585A0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	[Preserve]
	internal LAEKPNBOHDG()
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
