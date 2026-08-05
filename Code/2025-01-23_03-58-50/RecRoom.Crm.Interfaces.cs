using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FAHMGGOODKM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A96802A6A47", Offset = "0x0", VA = "0x2A6A98002A6A47", Slot = "0")]
	void FNHJHIPMIPM(string PHEKENOJCKN, string LDCEGNIAPJL, bool ACLFLADKEHA);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A9E8AC8BD38", Offset = "0x0", VA = "0x2A6AA00AC8BD38", Slot = "1")]
	void NADLEHNJJGM();

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xAC2A2A2802A6AC5", Offset = "0x0", VA = "0xAC2A2A4002A6AC5", Slot = "2")]
	void DDKPFGGBPIL();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2A6B76802A6AC5", Offset = "0x0", VA = "0x2A6B78002A6AC5", Slot = "3")]
	void PLNGNBCAHFA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A6B768AC8B61C", Offset = "0x0", VA = "0x2A6B780AC8B61C", Slot = "4")]
	void IOOFMDGLNCE(string DCDLHONMOIF, [Optional] string PPCNPJDCMBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CAMAGMKOFAD
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NGIPGGIIHJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BCJPPNMGNPJ LBDNFBMMGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAC8B636802A6BC9", Offset = "0x0", VA = "0xAC8B638002A6BC9", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool MHMPKDNPNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2A6BCD802A6BC9", Offset = "0x0", VA = "0x2A6BCF002A6BC9", Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<JGBOIKELMAL> ELPGOBIEAOI;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C43802A6C20", Offset = "0x0", VA = "0x2A6C45002A6C20", Slot = "4")]
	Task EHFCOOMFLME();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C438AC2A2A4", Offset = "0x0", VA = "0x2A6C450AC2A2A4", Slot = "5")]
	void FGGFCKBCIEA();
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
