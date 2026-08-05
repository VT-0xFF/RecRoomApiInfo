using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MAJGNFAGBGN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x28E3A38028E380", Offset = "0x0", VA = "0x28E3A50028E380", Slot = "0")]
	void DDLNNHELJCE(string JGAEPMNLCIL, string EAMEKKAKLCC, bool GIGBPJKOCBJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x28E3A38A696334", Offset = "0x0", VA = "0x28E3A50A696334", Slot = "1")]
	void OPHBALJGAJI();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA8AC85A8028E450", Offset = "0x0", VA = "0xA8AC85C0028E450", Slot = "2")]
	void FNPKCIEGJAK();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x28E49F8028E450", Offset = "0x0", VA = "0x28E4A10028E450", Slot = "3")]
	void OMEMILBAKGP();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28E49F8A8AC878", Offset = "0x0", VA = "0x28E4A10A8AC878", Slot = "4")]
	void OAJBGOAHMDP(string OPFGDKAACDG, [Optional] string KHOPPDDOBME);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BNGLBMGNBLE
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FLELEOFJDIK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OEBPLANCGOE HFOJDBCGFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA8AC8868028E4A7", Offset = "0x0", VA = "0xA8AC8880028E4A7", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool APKNJOHBFDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28E4F68028E4A7", Offset = "0x0", VA = "0x28E4F80028E4A7", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<FLCOBGMKAAI> KPFJCPHHLFG;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x28E5D68028E525", Offset = "0x0", VA = "0x28E5D80028E525", Slot = "4")]
	Task KMAKNPIEEHP();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x28E5D68A8AC47C", Offset = "0x0", VA = "0x28E5D80A8AC47C", Slot = "5")]
	void OMNFNMJPOGD();
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
