using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LKEGFHLHCNL : IAHGLICJHAB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public DateTime EHJHAKOGCDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x72F5ED0", Offset = "0x72F4ED0", VA = "0x1872F5ED0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float BDLGGIIAFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA91AF0", Offset = "0xA90AF0", VA = "0x180A91AF0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	[Preserve]
	internal LKEGFHLHCNL()
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
