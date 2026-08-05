using System;
using System.Reflection;
using Cpp2IlInjected;
using Google.Protobuf;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EEPEPEKALDH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C150", Offset = "0x5E9AF50", VA = "0x185E9C150")]
	public static Guid MIOHFDLCDME(this ByteString CFFPEBFKEAC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E9BFF0", Offset = "0x5E9ADF0", VA = "0x185E9BFF0")]
	public static ByteString JHMKMPECGAK(this Guid CFFPEBFKEAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KKPGLMGLNFP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C370", Offset = "0x5E9B170", VA = "0x185E9C370")]
	public static BJPEGONHHAI DGAMFOBEJMM(this in Guid CFFPEBFKEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C4A0", Offset = "0x5E9B2A0", VA = "0x185E9C4A0")]
	public static Guid HJFKJCGGCHL(this BJPEGONHHAI CFFPEBFKEAC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C240", Offset = "0x5E9B040", VA = "0x185E9C240")]
	public static Guid? CIOEFFDCILH(this BJPEGONHHAI CFFPEBFKEAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IKGOGHMFJOF
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x22B2F60", Offset = "0x22B1D60", VA = "0x1822B2F60")]
	public static bool POAKAOLFEHG<T>(this MessageParser<T> PFEEPPPICOM, byte[] HFAIGCGNPJJ, out T BBLJKOEKFJI) where T : IMessage<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ECLCBMAOOFH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E9BFB0", Offset = "0x5E9ADB0", VA = "0x185E9BFB0")]
	public static int FLDEFMECINK(this IOFNFGHMKGC DBFKJDOIKKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x833BA0", Offset = "0x8329A0", VA = "0x180833BA0")]
	public static int PCFOGONOLFA()
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
