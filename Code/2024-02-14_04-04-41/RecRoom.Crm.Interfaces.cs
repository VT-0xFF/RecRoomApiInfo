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
	[Cpp2IlInjected.Address(RVA = "0x2386918023868D", Offset = "0x0", VA = "0x2386930023868D", Slot = "0")]
	void OCKCOPOCKPN(string IIPPJCPOAME, string KBIKAEAGFEE, bool BODBOOCIKIN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x238691894DFEF0", Offset = "0x0", VA = "0x238693094DFEF0", Slot = "1")]
	void GENIMNODAPJ();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x94DFEDE802386E4", Offset = "0x0", VA = "0x94DFEE0002386E4", Slot = "2")]
	void MLJDGGIEKAJ();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x238713802386F0", Offset = "0x0", VA = "0x238715002386F0", Slot = "3")]
	void PDPADGJIOIE();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2387138934583C", Offset = "0x0", VA = "0x2387150934583C", Slot = "4")]
	void NDOKDFJHOIJ(string LFGJDFDHDAL, [Optional] string BGOIKAFONAA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HANEFLPALEB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DFLKICBEKAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x94E0E82802387B4", Offset = "0x0", VA = "0x94E0E84002387B4", Slot = "0")]
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
		[Cpp2IlInjected.Address(RVA = "0x238803802387B4", Offset = "0x0", VA = "0x238805002387B4", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<PCPFBPLOFLH> JABEJHLDNML;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x23885A8023880B", Offset = "0x0", VA = "0x23885C0023880B", Slot = "3")]
	Task NGFHLNOOHDK();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x23885E894E0EA0", Offset = "0x0", VA = "0x238860094E0EA0", Slot = "4")]
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
