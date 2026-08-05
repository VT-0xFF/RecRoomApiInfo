using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface AMGALOLOOAN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x24762480247580", Offset = "0x0", VA = "0x24762600247580", Slot = "0")]
	void MMOLFPGHGJK(string GCHCBCLCJKH, string DGLLEALALLK, bool CPJEPKNAKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x24762E8977F92C", Offset = "0x0", VA = "0x2476300977F92C", Slot = "1")]
	void OKFAHCMBPLC();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x977C902802476B7", Offset = "0x0", VA = "0x977C904002476B7", Slot = "2")]
	void KDNKNFJLIDM();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x247745802476C0", Offset = "0x0", VA = "0x247747002476C0", Slot = "3")]
	void NALAGFBIGLE();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x24774E8977C904", Offset = "0x0", VA = "0x2477500977C904", Slot = "4")]
	void BMLACAMBCJB(string EOLEOINDEFC, [Optional] string CHPKLPMEPNH);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IDDPMLODMHG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HFAEGBKGIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x997421680247850", Offset = "0x0", VA = "0x997421800247850", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LLAGKAIMLOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LHELJEDNEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x24792E80247850", Offset = "0x0", VA = "0x24793000247850", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<GIPIKNPBNCF> PINAHOANLNE;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x247A6D802479E0", Offset = "0x0", VA = "0x247A6F002479E0", Slot = "3")]
	Task AKCGAJHNOGB();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x247A6E8977E944", Offset = "0x0", VA = "0x247A700977E944", Slot = "4")]
	void HBHCINBKNHF();
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
