using System;
using System.Reflection;
using Cpp2IlInjected;
using Google.Protobuf;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EEPEPEKALDH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E9CBB0", Offset = "0x5E9B9B0", VA = "0x185E9CBB0")]
	public static Guid MIOHFDLCDME(this ByteString CFFPEBFKEAC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E9CA50", Offset = "0x5E9B850", VA = "0x185E9CA50")]
	public static ByteString JHMKMPECGAK(this Guid CFFPEBFKEAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KKPGLMGLNFP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E9CDD0", Offset = "0x5E9BBD0", VA = "0x185E9CDD0")]
	public static BJPEGONHHAI DGAMFOBEJMM(this in Guid CFFPEBFKEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E9CF00", Offset = "0x5E9BD00", VA = "0x185E9CF00")]
	public static Guid HJFKJCGGCHL(this BJPEGONHHAI CFFPEBFKEAC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E9CCA0", Offset = "0x5E9BAA0", VA = "0x185E9CCA0")]
	public static Guid? CIOEFFDCILH(this BJPEGONHHAI CFFPEBFKEAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IKGOGHMFJOF
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x23F3CC0", Offset = "0x23F2AC0", VA = "0x1823F3CC0")]
	public static bool POAKAOLFEHG<T>(this MessageParser<T> PFEEPPPICOM, byte[] HFAIGCGNPJJ, out T BBLJKOEKFJI) where T : IMessage<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ECLCBMAOOFH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E9CA10", Offset = "0x5E9B810", VA = "0x185E9CA10")]
	public static int FLDEFMECINK(this IOFNFGHMKGC DBFKJDOIKKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x983020", Offset = "0x981E20", VA = "0x180983020")]
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
