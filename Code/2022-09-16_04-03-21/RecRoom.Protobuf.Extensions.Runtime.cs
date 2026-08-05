using System;
using System.Reflection;
using Cpp2IlInjected;
using Google.Protobuf;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CHBIOBHHNLM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4217EF0", Offset = "0x42166F0", VA = "0x184217EF0")]
	public static Guid AIBLDLLHGGE(this ByteString KBMECNBEFEN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4217DA0", Offset = "0x42165A0", VA = "0x184217DA0")]
	public static ByteString ABPPGPMEONB(this Guid KBMECNBEFEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DABKIAFAEMK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4217FF0", Offset = "0x42167F0", VA = "0x184217FF0")]
	public static OCDALMEABON BAGHAKDDGPK(this in Guid KBMECNBEFEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4218110", Offset = "0x4216910", VA = "0x184218110")]
	public static Guid JDKEMADGCJE(this OCDALMEABON KBMECNBEFEN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x42181F0", Offset = "0x42169F0", VA = "0x1842181F0")]
	public static Guid? NBNNIPDOAEL(this OCDALMEABON KBMECNBEFEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class AOLKINCJIAK
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4217D70", Offset = "0x4216570", VA = "0x184217D70")]
	public static int HFFMDKONGAE(this NEJKIEIFAPA IALAPFKAFLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x718790", Offset = "0x716F90", VA = "0x180718790")]
	public static int OBPEEPPPPDM()
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
