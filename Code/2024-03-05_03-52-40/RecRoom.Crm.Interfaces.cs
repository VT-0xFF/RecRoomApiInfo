using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HENAJALENEG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x96E90DE8024964E", Offset = "0x0", VA = "0x96E90E00024964E", Slot = "0")]
	void BHHAIFDPDMO(string ILKOBLOHNIN, string DNCIGIDEEKC, bool PIHNDAAGLKA);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x24967C80249650", Offset = "0x0", VA = "0x24967E00249650", Slot = "1")]
	void ALHOHIPBAPJ();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x24968E896E7A80", Offset = "0x0", VA = "0x249690096E7A80", Slot = "2")]
	void DMCBJHKIPLA();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x96E90DE802496C0", Offset = "0x0", VA = "0x96E90E0002496C0", Slot = "3")]
	void KPJLLHDKPBH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2496E4802496C0", Offset = "0x0", VA = "0x2496E6002496C0", Slot = "4")]
	void NEOOKDNFNDF(string ALDHKAEGBEL, [Optional] string PFEOJPELPBO);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EHDMOCFPOAK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JJHLICHOGOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2496EE896E7A80", Offset = "0x0", VA = "0x2496F0096E7A80", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LGGPJAEHEGH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool PONJNOAMOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x96F22EA80249772", Offset = "0x0", VA = "0x96F22EC00249772", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<IMDNGEEPEDP> LHOMEEEEFAH;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x96E8D3A802497F8", Offset = "0x0", VA = "0x96E8D3C002497F8", Slot = "3")]
	Task KCJBJGBIMAI();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x24982E80249800", Offset = "0x0", VA = "0x24983000249800", Slot = "4")]
	void BMDNDNAFIJG();
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
