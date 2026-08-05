using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FAGJPMOMHLB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x25113380251110", Offset = "0x0", VA = "0x25113500251110", Slot = "0")]
	void AFAODDAEBIE(string BBNNHLDHKCH, string OOIIIJNHNOO, bool JMFMNEEOMGG);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x251133898D289C", Offset = "0x0", VA = "0x251135098D289C", Slot = "1")]
	void MFFIAFBKGAP();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9AD64F2802511CE", Offset = "0x0", VA = "0x9AD64F4002511CE", Slot = "2")]
	void GOICGMADBGD();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x25121D802511CE", Offset = "0x0", VA = "0x25121F002511CE", Slot = "3")]
	void PNFNEBAFMEC();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x25121D89AD6510", Offset = "0x0", VA = "0x25121F09AD6510", Slot = "4")]
	void ILMJNEAPHLL(string CHJHIJIAALG, [Optional] string JAFLEONHPAP);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OBFDCJHIPBF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EBMKJKJFKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9AD651E80251225", Offset = "0x0", VA = "0x9AD652000251225", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface HEBEHLHMOGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool HHEOLBNEHFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x25127480251225", Offset = "0x0", VA = "0x25127600251225", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<GHAAFJFFOGP> NJEDCBFBCFN;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x251331802512A4", Offset = "0x0", VA = "0x251333002512A4", Slot = "3")]
	Task HBPIHILNAPB();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x25133189AD6B14", Offset = "0x0", VA = "0x25133309AD6B14", Slot = "4")]
	void HJOLGBAAIAG();
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
