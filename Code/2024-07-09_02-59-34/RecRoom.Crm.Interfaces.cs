using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GFMEGINMGCL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x280A6380280A40", Offset = "0x0", VA = "0x280A6500280A40", Slot = "0")]
	void BGODDFOHBDK(string OKFKLGMFNBL, string CBICEPOMNFI, bool IOJAEHNDKFM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x280A638A20D794", Offset = "0x0", VA = "0x280A650A20D794", Slot = "1")]
	void PPANOAJEENN();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA421CDA80280B16", Offset = "0x0", VA = "0xA421CDC00280B16", Slot = "2")]
	void FKHMAHIKFEK();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x280B6580280B16", Offset = "0x0", VA = "0x280B6700280B16", Slot = "3")]
	void GPKKPHKFPOI();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x280B658A421CF8", Offset = "0x0", VA = "0x280B670A421CF8", Slot = "4")]
	void LNMNEBDEBOK(string GMDDPLAAPGL, [Optional] string DCONDDOOCOA);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ACAMOCFPNDB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BFJDLJBADHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA421D0680280B6D", Offset = "0x0", VA = "0xA421D0800280B6D", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LOODGDEHGAP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool CPMKDIBHNDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x280BBC80280B6D", Offset = "0x0", VA = "0x280BBE00280B6D", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<GPOOMPIJPDG> FAMGMDDIKOO;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x280C9E80280BE5", Offset = "0x0", VA = "0x280CA000280BE5", Slot = "3")]
	Task NJFEGHENHFC();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x280C9E8A421ADC", Offset = "0x0", VA = "0x280CA00A421ADC", Slot = "4")]
	void LEJCELDJPNB();
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
