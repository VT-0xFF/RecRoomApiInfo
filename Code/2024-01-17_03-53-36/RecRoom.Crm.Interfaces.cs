using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MHBPEGAFDLD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x23DCF389589C04", Offset = "0x0", VA = "0x23DCF509589C04", Slot = "0")]
	void HPFJMOPEGID(string KNHAGEIGOMA, string GNOJHGJEGNO, bool ELDMFOKPGOA);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9589C128023DCFB", Offset = "0x0", VA = "0x9589C140023DCFB", Slot = "1")]
	void KBNNCKNEMDF();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x23DD4A8023DCFB", Offset = "0x0", VA = "0x23DD4C0023DCFB", Slot = "2")]
	void AJMABBJKDPJ();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x23DD4E89589C04", Offset = "0x0", VA = "0x23DD5009589C04", Slot = "3")]
	void CIBGJAIHPGN();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x94908828023DD75", Offset = "0x0", VA = "0x94908840023DD75", Slot = "4")]
	void FOFJCGKGBNK(string BIBKCOFJIKA, [Optional] string IFKJHKNFCLN);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FJJIGNMENBP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NKPALGDDNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x23DE1A8023DD75", Offset = "0x0", VA = "0x23DE1C0023DD75", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface HKPPJGHMHCF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool HHPLIKBLNPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x23DE1A895891E8", Offset = "0x0", VA = "0x23DE1C095891E8", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<JIGGMMPKGLA> DKLAKCNMOCG;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x23DE7189589214", Offset = "0x0", VA = "0x23DE7309589214", Slot = "3")]
	Task CGDOOEBPPMG();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x95892028023DEC4", Offset = "0x0", VA = "0x95892040023DEC4", Slot = "4")]
	void KGLPDGAIIAF();
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
