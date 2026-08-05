using System;
using System.Reflection;
using Cpp2IlInjected;
using Google.Protobuf;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FFHGHJBKEJP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6011150", Offset = "0x6010550", VA = "0x186011150")]
	public static Guid GPIFFOKBIIA(this ByteString DMBAJFNFPGC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6010FF0", Offset = "0x60103F0", VA = "0x186010FF0")]
	public static ByteString DKLIHNBDKFH(this Guid DMBAJFNFPGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MHJNCKNKFAB
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6011280", Offset = "0x6010680", VA = "0x186011280")]
	public static CCMGOGGNIAP CAOILNKOGOI(this in Guid DMBAJFNFPGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60113B0", Offset = "0x60107B0", VA = "0x1860113B0")]
	public static Guid DBBEJMFMHKH(this CCMGOGGNIAP DMBAJFNFPGC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6011480", Offset = "0x6010880", VA = "0x186011480")]
	public static Guid? FIOPLMDKMLE(this CCMGOGGNIAP DMBAJFNFPGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JIHFENFMLBE
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2616C60", Offset = "0x2616060", VA = "0x182616C60")]
	public static bool LMNJKEHEOOP<T>(this MessageParser<T> MFNLAFEBOKL, byte[] OGILIIFBKAD, out T HNCBGLIPCEM) where T : IMessage<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KBLMGPMPOAF
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6011240", Offset = "0x6010640", VA = "0x186011240")]
	public static int IABLDJIMDBC(this NDKLHPOCFKB IALLIBEMNLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xA12250", Offset = "0xA11650", VA = "0x180A12250")]
	public static int ELEBKEIBGIF()
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
