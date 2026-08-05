using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DDBFKDJCIKN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2A36CE8A871390", Offset = "0x0", VA = "0x2A36D00A871390", Slot = "0")]
	void BNBBHKGIAGA(string EIBBPNEBINN, string NAAIGKICFMG, bool PIKKPPGHILL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA8734E6802A375F", Offset = "0x0", VA = "0xA8734E8002A375F", Slot = "1")]
	void BPNAAGGKDNI();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2A37ED802A3760", Offset = "0x0", VA = "0x2A37EF002A3760", Slot = "2")]
	void BNPMKCLNFFM();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2A37EE8A8734E8", Offset = "0x0", VA = "0x2A37F00A8734E8", Slot = "3")]
	void FKJINFKGFNA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA87138E802A3877", Offset = "0x0", VA = "0xA871390002A3877", Slot = "4")]
	void CGEBNLCCEJM(string PFEOCJNAHIN, [Optional] string PMLDJJMALNA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GIBHLEAAICK
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LGFHHIBMDBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	ADDKKECANOD ABGPMEKFHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2A390D802A3880", Offset = "0x0", VA = "0x2A390F002A3880", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FMPJMMKMGJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2A390E8A8734E8", Offset = "0x0", VA = "0x2A39100A8734E8", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<LHELEEPJFKH> JHAFCNKHMPI;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2A3A3E8A8734E8", Offset = "0x0", VA = "0x2A3A400A8734E8", Slot = "4")]
	Task CPDDJGLEDNE();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA87138E802A3AC7", Offset = "0x0", VA = "0xA871390002A3AC7", Slot = "5")]
	void CMJEOBEPHJG();
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
