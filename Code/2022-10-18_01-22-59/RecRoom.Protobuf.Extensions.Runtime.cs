using System;
using System.Reflection;
using Cpp2IlInjected;
using Google.Protobuf;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EEPEPEKALDH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E9CE30", Offset = "0x5E9BE30", VA = "0x185E9CE30")]
	public static Guid MIOHFDLCDME(this ByteString CFFPEBFKEAC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E9CCD0", Offset = "0x5E9BCD0", VA = "0x185E9CCD0")]
	public static ByteString JHMKMPECGAK(this Guid CFFPEBFKEAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KKPGLMGLNFP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E9D050", Offset = "0x5E9C050", VA = "0x185E9D050")]
	public static BJPEGONHHAI DGAMFOBEJMM(this in Guid CFFPEBFKEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E9D180", Offset = "0x5E9C180", VA = "0x185E9D180")]
	public static Guid HJFKJCGGCHL(this BJPEGONHHAI CFFPEBFKEAC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E9CF20", Offset = "0x5E9BF20", VA = "0x185E9CF20")]
	public static Guid? CIOEFFDCILH(this BJPEGONHHAI CFFPEBFKEAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IKGOGHMFJOF
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x25CB1B0", Offset = "0x25CA1B0", VA = "0x1825CB1B0")]
	public static bool POAKAOLFEHG<T>(this MessageParser<T> PFEEPPPICOM, byte[] HFAIGCGNPJJ, out T BBLJKOEKFJI) where T : IMessage<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ECLCBMAOOFH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E9CC90", Offset = "0x5E9BC90", VA = "0x185E9CC90")]
	public static int FLDEFMECINK(this IOFNFGHMKGC DBFKJDOIKKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xA1A7F0", Offset = "0xA197F0", VA = "0x180A1A7F0")]
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
