using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class BJODBAHIAIE : LFDOIPOIKHN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool COJAMEIKMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x577B90", Offset = "0x576790", VA = "0x180577B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	private BJODBAHIAIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x17EAFE0", Offset = "0x17E9BE0", VA = "0x1817EAFE0")]
	public static BJODBAHIAIE EEJCKKCGPGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "4")]
	public void OAGOINPBJGJ(Func<string> FFOAIHIIDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
	public void CAEJCKJDFIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x17EB030", Offset = "0x17E9C30", VA = "0x1817EB030", Slot = "6")]
	public void IGOIENFEDGD(object MCDGHKDLPFF)
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
