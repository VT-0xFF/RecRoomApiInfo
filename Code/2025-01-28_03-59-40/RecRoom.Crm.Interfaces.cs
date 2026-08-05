using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CFNHHAKDLKO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2C56D2802C5640", Offset = "0x0", VA = "0x2C56D4002C5640", Slot = "0")]
	void PGMCPFEEOAF(string DBECDMAHNEI, string FOAECPINKAK, bool BJFDHIBLLLI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2C56DE8ADCC850", Offset = "0x0", VA = "0x2C56E00ADCC850", Slot = "1")]
	void MDAOKFILIII();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xADCC84E802C5774", Offset = "0x0", VA = "0xADCC850002C5774", Slot = "2")]
	void BEFFLKECCDP();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2C5807802C5780", Offset = "0x0", VA = "0x2C5809002C5780", Slot = "3")]
	void EOPLKJJDCLI();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2C580E8ADC9210", Offset = "0x0", VA = "0x2C58100ADC9210", Slot = "4")]
	void BBPFAAPCMOJ(string ECCBIDHOHJB, [Optional] string FLECCKBEBDM);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CGABNJCCDLB
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PKHKCJIMCHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HDKPBCHJACN KOFELJDHCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xADCC84E802C58A4", Offset = "0x0", VA = "0xADCC850002C58A4", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LAGDMNFNLEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2C5937802C58B0", Offset = "0x0", VA = "0x2C5939002C58B0", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<CFDFKHFAJNP> AEHFHFKOIHK;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A57802C59D0", Offset = "0x0", VA = "0x2C5A59002C59D0", Slot = "4")]
	Task GGPOBANFNOP();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2C5A5E8ADC9210", Offset = "0x0", VA = "0x2C5A600ADC9210", Slot = "5")]
	void OKECIINHNOA();
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
