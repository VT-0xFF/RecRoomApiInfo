using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GIFHEGMPJIO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6B33F30", Offset = "0x6B32D30", VA = "0x186B33F30")]
	public static KeepsakeTheme NOGKMJDJBCL(this JFFHBKMMKFJ GPCKGMCLNIA, Guid PGDCMKGLNJL)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6B33E90", Offset = "0x6B32C90", VA = "0x186B33E90")]
	public static KeepsakeTheme NOGKMJDJBCL(this JFFHBKMMKFJ GPCKGMCLNIA, JHAAPFBDNOG DOALNJCLMJO)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6B33CD0", Offset = "0x6B32AD0", VA = "0x186B33CD0")]
	public static List<KeepsakeTheme> DMCCOHILAIL(this JFFHBKMMKFJ GPCKGMCLNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6B33D80", Offset = "0x6B32B80", VA = "0x186B33D80")]
	public static JHAAPFBDNOG FNNEAOGIOHH(this JFFHBKMMKFJ GPCKGMCLNIA, Guid PGDCMKGLNJL)
	{
		return default(JHAAPFBDNOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B33E10", Offset = "0x6B32C10", VA = "0x186B33E10")]
	public static int ICBBMGAKBJJ(this JFFHBKMMKFJ GPCKGMCLNIA, JHAAPFBDNOG LFNDIBOEPAC)
	{
		return default(int);
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
