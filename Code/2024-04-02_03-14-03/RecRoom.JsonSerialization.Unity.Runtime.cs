using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Preserve]
public class IPJMKHEBACB : NPNHDPODLKO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x282CBB0", Offset = "0x282B7B0", VA = "0x18282CBB0", Slot = "4")]
	public string IGAJFBILIJN<T>(T OGGNGHKHHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x282CBC0", Offset = "0x282B7C0", VA = "0x18282CBC0", Slot = "5")]
	public T MFNDOKFJNNF<T>(string BLKAHBIJBJO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public IPJMKHEBACB()
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
