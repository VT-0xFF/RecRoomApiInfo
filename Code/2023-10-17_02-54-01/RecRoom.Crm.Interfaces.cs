using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface ILCOPMLHIAI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x22B37E890E34C4", Offset = "0x0", VA = "0x22B380090E34C4", Slot = "0")]
	void BGDPNMPENKG(string AKONLBPHNLE, string JNLCEHFKJBN, bool ELACGDBIMAL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8FF9DAA8022B3A5", Offset = "0x0", VA = "0x8FF9DAC0022B3A5", Slot = "1")]
	void EAPAHGDEHPA();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x22B44A8022B3A5", Offset = "0x0", VA = "0x22B44C0022B3A5", Slot = "2")]
	void CBLCIJCGCLE();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x22B44A890E33A8", Offset = "0x0", VA = "0x22B44C090E33A8", Slot = "3")]
	void JDGKOODAABM();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x90E33C28022B49D", Offset = "0x0", VA = "0x90E33C40022B49D", Slot = "4")]
	void NJOEFNJGEFP(string OEHJGBNCEDG, [Optional] string EFFOJPODIEM);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JKMDHKCKKHD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LJMMKGDPNNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x22B4A18022B49D", Offset = "0x0", VA = "0x22B4A30022B49D", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AEMLCOKEFEJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool CABOPOEFJKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x22B4A1890E33D4", Offset = "0x0", VA = "0x22B4A3090E33D4", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<EMMMNIGFAGN> AHOBMJDIEDE;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x22B52388F3A3DC", Offset = "0x0", VA = "0x22B52508F3A3DC", Slot = "3")]
	Task GLJEDCMMNGN();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x90E1F268022B5DC", Offset = "0x0", VA = "0x90E1F280022B5DC", Slot = "4")]
	void FCKDKLKEHNJ();
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
