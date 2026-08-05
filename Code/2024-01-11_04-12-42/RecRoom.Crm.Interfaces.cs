using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FDNGMDHPNGE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x23CB0E8958A15C", Offset = "0x0", VA = "0x23CB100958A15C", Slot = "0")]
	void KPAANAKPFKC(string IHLEIMCELKM, string IDJIICHDCOC, bool NGGOANNFDPN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x93EC16A8023CB35", Offset = "0x0", VA = "0x93EC16C0023CB35", Slot = "1")]
	void HOJLNINCHLL();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x23CBD28023CB35", Offset = "0x0", VA = "0x23CBD40023CB35", Slot = "2")]
	void CDKLCAKEBNK();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x23CBD289588A00", Offset = "0x0", VA = "0x23CBD409588A00", Slot = "3")]
	void OECAEKFJCCE();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9588A1A8023CC25", Offset = "0x0", VA = "0x9588A1C0023CC25", Slot = "4")]
	void DBPMCGBFHBP(string CECOAMKIDGD, [Optional] string IGJAEMJCBIC);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IKBCEDDLMJI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GEADCBKOIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x23CC298023CC25", Offset = "0x0", VA = "0x23CC2B0023CC25", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FNJDFOBCNMC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool JAOOPKDFEJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x23CC2989588A2C", Offset = "0x0", VA = "0x23CC2B09588A2C", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<MHABOOMPOOO> HILPPEPFEML;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x23CCA3893EC16C", Offset = "0x0", VA = "0x23CCA5093EC16C", Slot = "3")]
	Task IAMMEFBKIFH();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x95894FE8023CD44", Offset = "0x0", VA = "0x95895000023CD44", Slot = "4")]
	void JGPBMMKLMDA();
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
