using System;
using System.Reflection;
using Cpp2IlInjected;
using Google.Protobuf;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PJDCHLOEKDN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1ED1CE0", Offset = "0x1ED04E0", VA = "0x181ED1CE0")]
	public static Guid AAEGHBFLEMG(this ByteString IPNNIJODOPO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1ED1DD0", Offset = "0x1ED05D0", VA = "0x181ED1DD0")]
	public static ByteString KEBHENPFBNP(this Guid IPNNIJODOPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CJNCBPCGOJP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1ED1B70", Offset = "0x1ED0370", VA = "0x181ED1B70")]
	public static EGKNLKAKAIL HHDOHEHKDKI(this in Guid IPNNIJODOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1ED1970", Offset = "0x1ED0170", VA = "0x181ED1970")]
	public static Guid ADHMOLAJGDE(this EGKNLKAKAIL IPNNIJODOPO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1ED1A40", Offset = "0x1ED0240", VA = "0x181ED1A40")]
	public static Guid? EONLBGCKLGN(this EGKNLKAKAIL IPNNIJODOPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DHBJEAPLIJC
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x36A67F0", Offset = "0x36A4FF0", VA = "0x1836A67F0")]
	public static bool DDGJCBJKGIL<T>(this MessageParser<T> EEGKHDCEMHB, byte[] CDDAIIMDJCN, out T BBELMPNHPOK) where T : IMessage<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OMFFCBABCFH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1ED1CA0", Offset = "0x1ED04A0", VA = "0x181ED1CA0")]
	public static int JPHHMOOCLCP(this KHMOACGNIHJ FELFFCMELCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x941E10", Offset = "0x940610", VA = "0x180941E10")]
	public static int OPHFNFIIOEJ()
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
