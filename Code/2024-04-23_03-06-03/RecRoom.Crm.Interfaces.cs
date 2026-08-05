using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JGEEGKDOFAK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9B7E662802547BC", Offset = "0x0", VA = "0x9B7E664002547BC", Slot = "0")]
	void PNNLIBJGDJJ(string IFFLEGIBJJK, string DDDMPLHMEBN, bool EPFDOGMLMDN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2547E3802547C0", Offset = "0x0", VA = "0x2547E5002547C0", Slot = "1")]
	void NNCNCPFADPF();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2547E3899770F8", Offset = "0x0", VA = "0x2547E5099770F8", Slot = "2")]
	void HNLLDOKNAHL();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x9B7CC868025488C", Offset = "0x0", VA = "0x9B7CC880025488C", Slot = "3")]
	void EJNFIAPPONP();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2548DB8025488C", Offset = "0x0", VA = "0x2548DD0025488C", Slot = "4")]
	void MMNNKCLNCJP(string GFNEMAMDBJO, [Optional] string PNHMJEGBOOM);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CCNDNJAFIMM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PIGBBAIEDCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2548DB89B7CCA4", Offset = "0x0", VA = "0x2548DD09B7CCA4", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ONBNLCKPFOB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FHAIMDBLBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9B7CCB2802548E3", Offset = "0x0", VA = "0x9B7CCB4002548E3", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<CJDEGPNNPAI> GNPEDJPCCAD;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x997F8CA80254964", Offset = "0x0", VA = "0x997F8CC00254964", Slot = "3")]
	Task CJMKLAKCCOG();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2549F780254964", Offset = "0x0", VA = "0x2549F900254964", Slot = "4")]
	void KNIDJLMEEBL();
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
