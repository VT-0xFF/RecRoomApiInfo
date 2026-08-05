using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KHEICJCPMFB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6BE4A00", Offset = "0x6BE3400", VA = "0x186BE4A00")]
	public static KeepsakeTheme JNMNOBAEIEP(this HIJFLCFLCAJ CMHMDBNCGCO, Guid OOOJEGNMLIB)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6BE4950", Offset = "0x6BE3350", VA = "0x186BE4950")]
	public static KeepsakeTheme JNMNOBAEIEP(this HIJFLCFLCAJ CMHMDBNCGCO, EFNAILPKJGE PIPGLBCIELA)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6BE4890", Offset = "0x6BE3290", VA = "0x186BE4890")]
	public static List<KeepsakeTheme> DBFEHKFLDIK(this HIJFLCFLCAJ CMHMDBNCGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6BE4AF0", Offset = "0x6BE34F0", VA = "0x186BE4AF0")]
	public static EFNAILPKJGE PBKDGCPOGEJ(this HIJFLCFLCAJ CMHMDBNCGCO, Guid OOOJEGNMLIB)
	{
		return default(EFNAILPKJGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6BE4810", Offset = "0x6BE3210", VA = "0x186BE4810")]
	public static int AKIAOBCKHNA(this HIJFLCFLCAJ CMHMDBNCGCO, EFNAILPKJGE EMPFDKECDCP)
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
