using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IFCLDJOEAJK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2A2CDA802A2C8B", Offset = "0x0", VA = "0x2A2CDC002A2C8B", Slot = "0")]
	void MFJOBGIOPDC(string GEBKJHCMKFM, string CHNAOHBNBEE, bool PJCHMKIFJGD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2A2CDA8A9AB30C", Offset = "0x0", VA = "0x2A2CDC0A9AB30C", Slot = "1")]
	void NEIEMKIKPDI();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA9AB31A802A2CE2", Offset = "0x0", VA = "0xA9AB31C002A2CE2", Slot = "2")]
	void OHBDILPJNED();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2A2D31802A2CE2", Offset = "0x0", VA = "0x2A2D33002A2CE2", Slot = "3")]
	void IDPKIODCCII();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A2D3E8A9AB30C", Offset = "0x0", VA = "0x2A2D400A9AB30C", Slot = "4")]
	void HIJPAGBIKIO(string PLAJOBIONGF, [Optional] string EJIGIAFHGEE);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DNJOAIACIEB
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EFILFKKENPE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MEOGFFCBCLD CNPDPHDLIGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA945F1E802A2D65", Offset = "0x0", VA = "0xA945F20002A2D65", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LNHMCPJOFLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2A2E1E802A2D65", Offset = "0x0", VA = "0x2A2E20002A2D65", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<BHIOCACHCNM> BOLLLLADOAH;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E75802A2E71", Offset = "0x0", VA = "0x2A2E77002A2E71", Slot = "4")]
	Task JLABJFAHLGH();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E758A9ABB1C", Offset = "0x0", VA = "0x2A2E770A9ABB1C", Slot = "5")]
	void AEAEDDMNDLB();
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
