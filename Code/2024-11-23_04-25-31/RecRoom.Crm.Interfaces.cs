using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface OFDBPFAALJG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2A41EB802A4117", Offset = "0x0", VA = "0x2A41ED002A4117", Slot = "0")]
	void FBFKPKCMFJK(string AAEOKDMHIOA, string KKEABGPJCFG, bool OJHFMHPCFDM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2A41EB8A9C7114", Offset = "0x0", VA = "0x2A41ED0A9C7114", Slot = "1")]
	void GFLKEOHLPCD();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA9C712E802A423E", Offset = "0x0", VA = "0xA9C7130002A423E", Slot = "2")]
	void JLMOOFJKGEE();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2A4242802A423E", Offset = "0x0", VA = "0x2A4244002A423E", Slot = "3")]
	void KCMEDIOJILC();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A42428A9C7140", Offset = "0x0", VA = "0x2A42440A9C7140", Slot = "4")]
	void AOHGEJMOBHC(string DMHEEMFLNHE, [Optional] string MKGOFLCFFFO);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ENGLJLEGCAC
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MHLCFJIHHAB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NCMHCFIKOKO NPKFJGLPDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA9C712E802A4295", Offset = "0x0", VA = "0xA9C7130002A4295", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool PJNGPPBJKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2A42C2802A42A0", Offset = "0x0", VA = "0x2A42C4002A42A0", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<ABCNMKOMDFH> HGNMFFNADMB;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2A43BA802A436B", Offset = "0x0", VA = "0x2A43BC002A436B", Slot = "4")]
	Task GCHKJEOLKFE();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2A43BA8A9C80D0", Offset = "0x0", VA = "0x2A43BC0A9C80D0", Slot = "5")]
	void ENPPBKGKMKJ();
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
