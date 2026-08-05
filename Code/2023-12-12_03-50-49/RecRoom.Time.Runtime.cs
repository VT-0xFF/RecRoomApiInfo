using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class GMNECMLJALO : OEGJAJEGLEH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public DateTime CPCJCJINMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6538CE0", Offset = "0x65374E0", VA = "0x186538CE0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float NMLMHFNHKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1CA2590", Offset = "0x1CA0D90", VA = "0x181CA2590", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	[Preserve]
	internal GMNECMLJALO()
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
