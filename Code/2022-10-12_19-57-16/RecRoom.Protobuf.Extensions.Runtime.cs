using System;
using System.Reflection;
using Cpp2IlInjected;
using Google.Protobuf;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PJDCHLOEKDN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E48D90", Offset = "0x5E47D90", VA = "0x185E48D90")]
	public static Guid AAEGHBFLEMG(this ByteString IPNNIJODOPO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E48E80", Offset = "0x5E47E80", VA = "0x185E48E80")]
	public static ByteString KEBHENPFBNP(this Guid IPNNIJODOPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CJNCBPCGOJP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E48C20", Offset = "0x5E47C20", VA = "0x185E48C20")]
	public static EGKNLKAKAIL HHDOHEHKDKI(this in Guid IPNNIJODOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E48A20", Offset = "0x5E47A20", VA = "0x185E48A20")]
	public static Guid ADHMOLAJGDE(this EGKNLKAKAIL IPNNIJODOPO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E48AF0", Offset = "0x5E47AF0", VA = "0x185E48AF0")]
	public static Guid? EONLBGCKLGN(this EGKNLKAKAIL IPNNIJODOPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DHBJEAPLIJC
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x27B8A00", Offset = "0x27B7A00", VA = "0x1827B8A00")]
	public static bool DDGJCBJKGIL<T>(this MessageParser<T> EEGKHDCEMHB, byte[] CDDAIIMDJCN, out T BBELMPNHPOK) where T : IMessage<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OMFFCBABCFH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E48D50", Offset = "0x5E47D50", VA = "0x185E48D50")]
	public static int JPHHMOOCLCP(this KHMOACGNIHJ FELFFCMELCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xA0B6A0", Offset = "0xA0A6A0", VA = "0x180A0B6A0")]
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
