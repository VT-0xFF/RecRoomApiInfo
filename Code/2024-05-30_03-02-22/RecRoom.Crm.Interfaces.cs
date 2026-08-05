using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KFGDDNFGFJL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x25569E89D9643C", Offset = "0x0", VA = "0x2556A009D9643C", Slot = "0")]
	void CCIPAAFLPIB(string CNEMOKCLLIN, string HPEAGOMHJLB, bool IHFEHBDDOAC);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9B9821E802556C4", Offset = "0x0", VA = "0x9B98220002556C4", Slot = "1")]
	void PFHLGCAIAHH();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x255751802556C4", Offset = "0x0", VA = "0x255753002556C4", Slot = "2")]
	void DJKLGCFMLGI();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x25575189D96CE0", Offset = "0x0", VA = "0x25575309D96CE0", Slot = "3")]
	void PEMLPJJDOMI();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9D96CFA802557A4", Offset = "0x0", VA = "0x9D96CFC002557A4", Slot = "4")]
	void AABCLEOEEPE(string IJPBCGPKMHE, [Optional] string HFCBICBKMOM);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IEKPDOOCBJP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PJJFPBOBPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2557A8802557A4", Offset = "0x0", VA = "0x2557AA002557A4", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CBBBNGDEDHO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool JHDEJDCMKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2557A889D96D0C", Offset = "0x0", VA = "0x2557AA09D96D0C", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<KBBFFPMJAPI> PMCNCKCOAMI;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x25582389BB8708", Offset = "0x0", VA = "0x25582509BB8708", Slot = "3")]
	Task CNOOLEDIEBH();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x9D96F1E802558D6", Offset = "0x0", VA = "0x9D96F20002558D6", Slot = "4")]
	void CFPPHLPBNAM();
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
