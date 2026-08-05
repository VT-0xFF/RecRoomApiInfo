using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JHONEHCGPPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x22DF4D893239B8", Offset = "0x0", VA = "0x22DF4F093239B8", Slot = "0")]
	void ICCFPFBKFPJ(string MDIOFAKPKAH, string FGJMMPOPBBP, bool JHAIEEKKOOE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x93239C68022DF55", Offset = "0x0", VA = "0x93239C80022DF55", Slot = "1")]
	void PCOPNDNMGKL();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x22DFA48022DF55", Offset = "0x0", VA = "0x22DFA60022DF55", Slot = "2")]
	void FPFAEMMPBMF();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x22DFAE893239B8", Offset = "0x0", VA = "0x22DFB0093239B8", Slot = "3")]
	void LHFPDGFGJBF();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x92429068022DFD5", Offset = "0x0", VA = "0x92429080022DFD5", Slot = "4")]
	void JOGAJCHOGDE(string KAOHJFECCHG, [Optional] string CCLPDIGMFNH);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FLJHBJJNKGE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MFPNBFEOLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x22E0828022DFD5", Offset = "0x0", VA = "0x22E0840022DFD5", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KKEEJIJFNFK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool COFIDEEJANJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x22E082893249DC", Offset = "0x0", VA = "0x22E084093249DC", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<NICDOOJAEGN> HMMFNEKLEPA;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x22E0D989324A08", Offset = "0x0", VA = "0x22E0DB09324A08", Slot = "3")]
	Task EBEAKPIECKB();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x93249F68022E12C", Offset = "0x0", VA = "0x93249F80022E12C", Slot = "4")]
	void EINJMPIPEHC();
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
