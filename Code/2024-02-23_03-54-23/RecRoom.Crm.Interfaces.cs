using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KPCGMOPCMNI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x971130E8023C2A5", Offset = "0x0", VA = "0x97113100023C2A5", Slot = "0")]
	void OCKCOPOCKPN(string IIPPJCPOAME, string KBIKAEAGFEE, bool BODBOOCIKIN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x23C2A98023C2A5", Offset = "0x0", VA = "0x23C2AB0023C2A5", Slot = "1")]
	void GENIMNODAPJ();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x23C2A989711320", Offset = "0x0", VA = "0x23C2AB09711320", Slot = "2")]
	void MLJDGGIEKAJ();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x971130E8023C2FC", Offset = "0x0", VA = "0x97113100023C2FC", Slot = "3")]
	void PDPADGJIOIE();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x23C3238023C300", Offset = "0x0", VA = "0x23C3250023C300", Slot = "4")]
	void NDOKDFJHOIJ(string LFGJDFDHDAL, [Optional] string BGOIKAFONAA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HANEFLPALEB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DFLKICBEKAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x23C323895783D4", Offset = "0x0", VA = "0x23C325095783D4", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JFDOLPEPIGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool GMICNHJIKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x97117728023C3CC", Offset = "0x0", VA = "0x97117740023C3CC", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<PCPFBPLOFLH> JABEJHLDNML;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x971179E8023C423", Offset = "0x0", VA = "0x97117A00023C423", Slot = "3")]
	Task NGFHLNOOHDK();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x23C4728023C423", Offset = "0x0", VA = "0x23C4740023C423", Slot = "4")]
	void KECAPFPCLAM();
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
