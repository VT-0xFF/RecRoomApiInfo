using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NEJDLNHCPBP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA4ACF928028F8C7", Offset = "0x0", VA = "0xA4ACF940028F8C7", Slot = "0")]
	void DMLLJEKGGPN(string BJEKILICGCP, string CKDCBGILEJM, bool HHJALLNHNFF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x28F95D8028F8D0", Offset = "0x0", VA = "0x28F95F0028F8D0", Slot = "1")]
	void OPFLKDNPOIN();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x28F95E8A4AF0D0", Offset = "0x0", VA = "0x28F9600A4AF0D0", Slot = "2")]
	void CLCHMLIKPEG();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA4ACF928028F9E7", Offset = "0x0", VA = "0xA4ACF940028F9E7", Slot = "3")]
	void PJBOHBOPOHN();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28FA758028F9F0", Offset = "0x0", VA = "0x28FA770028F9F0", Slot = "4")]
	void FONIHAJFAGK(string OJALFDDIFCK, [Optional] string OLFEADFDDHB);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AFHPBMOONKO
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface INEBAIGJMLF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AJJGLGCKMHP PNMGJNHENFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28FA7E8A4ACF94", Offset = "0x0", VA = "0x28FA800A4ACF94", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool OBCOLJNCAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA4ACF928028FB07", Offset = "0x0", VA = "0xA4ACF940028FB07", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<HIHMCOFAJNC> IAEMCKMKJOG;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA4ACF928028FC27", Offset = "0x0", VA = "0xA4ACF940028FC27", Slot = "4")]
	Task PCEEADECCDH();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x28FCC88028FC30", Offset = "0x0", VA = "0x28FCCA0028FC30", Slot = "5")]
	void CGBFLDMMJFM();
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
