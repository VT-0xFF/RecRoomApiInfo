using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface AJGNEMGLDPE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x27B4BE8A163E08", Offset = "0x0", VA = "0x27B4C00A163E08", Slot = "0")]
	void KDFOGBFENMO(string CMEGBCLBCMD, string FCBFAALPDEG, bool JGOEHKMHDLE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA160D0A8027B541", Offset = "0x0", VA = "0xA160D0C0027B541", Slot = "1")]
	void FIAOFCGPJPK();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x27B5D78027B550", Offset = "0x0", VA = "0x27B5D90027B550", Slot = "2")]
	void ECNFOPLLFKK();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x27B5DE8A162DFC", Offset = "0x0", VA = "0x27B5E00A162DFC", Slot = "3")]
	void HAHHNKCJBHA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA163E068027B674", Offset = "0x0", VA = "0xA163E080027B674", Slot = "4")]
	void FNJIGNCKGJF(string MLJCPGIBJAD, [Optional] string KBJFLCEDPNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MEABEKFHPPH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BKHDIJOHCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x27B7078027B680", Offset = "0x0", VA = "0x27B7090027B680", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LLPOGCNCKLG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LCBIJEILKIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x27B70E8A162DFC", Offset = "0x0", VA = "0x27B7100A162DFC", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<CLJABHNENNG> PBEAMBOGEJB;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x27B83E8A160D0C", Offset = "0x0", VA = "0x27B8400A160D0C", Slot = "3")]
	Task MGIGIPLLEKC();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA162DFA8027B8C9", Offset = "0x0", VA = "0xA162DFC0027B8C9", Slot = "4")]
	void FCLPPFCBMBC();
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
